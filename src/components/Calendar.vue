<template>
  <v-row class="fill-height">
    <v-col>
      <v-sheet height="64">
        <v-toolbar flat>
          <v-btn outlined class="mr-4" color="grey darken-2" @click="setToday">
            Today
          </v-btn>
          <v-btn fab text small color="grey darken-2" @click="prev">
            <v-icon small> mdi-chevron-left </v-icon>
          </v-btn>
          <v-btn fab text small color="grey darken-2" @click="next">
            <v-icon small> mdi-chevron-right </v-icon>
          </v-btn>
          <v-toolbar-title v-if="$refs.calendar">
            {{ $refs.calendar.title }}
          </v-toolbar-title>
          <v-spacer></v-spacer>
          <v-menu bottom right>
            <template v-slot:activator="{ on, attrs }">
              <v-btn outlined color="grey darken-2" v-bind="attrs" v-on="on">
                <span>{{ typeToLabel[type] }}</span>
                <v-icon right> mdi-menu-down </v-icon>
              </v-btn>
            </template>
            <v-list>
              <v-list-item @click="type = 'day'">
                <v-list-item-title>Day</v-list-item-title>
              </v-list-item>
              <v-list-item @click="type = 'week'">
                <v-list-item-title>Week</v-list-item-title>
              </v-list-item>
              <v-list-item @click="type = 'month'">
                <v-list-item-title>Month</v-list-item-title>
              </v-list-item>
              <v-list-item @click="type = '4day'">
                <v-list-item-title>4 days</v-list-item-title>
              </v-list-item>
            </v-list>
          </v-menu>
        </v-toolbar>
      </v-sheet>
      <v-sheet height="600">
        <v-calendar
          ref="calendar"
          v-model="focus"
          color="green"
          :events="events"
          :event-color="getEventColor"
          :type="type"
          @click:event="showEvent"
          @click:more="viewDay"
          @click:date="viewDay"
          @change="updateRange"
        ></v-calendar>
        <v-menu
          v-model="selectedOpen"
          :close-on-content-click="false"
          :activator="selectedElement"
          offset-x
        >
          <v-card color="grey lighten-4" min-width="350px" flat>
            <v-toolbar :color="selectedEvent.color" dark>
              <v-toolbar-title v-html="selectedEvent.name"></v-toolbar-title>
              <v-spacer></v-spacer>
              <v-btn @click="approveAppointment(selectedEvent.id)" icon>
                <v-icon>mdi-check</v-icon>
              </v-btn>
              <v-btn @click="deleteConfirmation = true" icon>
                <v-icon>mdi-delete</v-icon>
              </v-btn>
              <v-row justify="center">
                <v-dialog
                  v-model="deleteConfirmation"
                  persistent
                  max-width="290"
                >
                  <v-card>
                    <v-card-title class="text-h5 error"> Delete </v-card-title>
                    <v-card-text
                      >Are you sure you want to delete this
                      appointment?</v-card-text
                    >
                    <v-card-actions>
                      <v-spacer></v-spacer>
                      <v-btn
                        color="error"
                        text
                        @click="deleteAppointment(selectedEvent.id)"
                      >
                        Agree
                      </v-btn>
                      <v-btn
                        color="grey"
                        text
                        @click="deleteConfirmation = false"
                        @keypress.esc="deleteConfirmation = false"
                      >
                        Disagree
                      </v-btn>
                    </v-card-actions>
                  </v-card>
                </v-dialog>
              </v-row>
            </v-toolbar>
            <v-card-text>
              <span v-html="selectedEvent.details"></span>
            </v-card-text>
            <v-card-actions>
              <v-btn text color="secondary" @click="selectedOpen = false">
                Cancel
              </v-btn>
            </v-card-actions>
          </v-card>
        </v-menu>
      </v-sheet>
    </v-col>
  </v-row>
</template>

<script>
import firebase from "../firebaseInit.js";
const db = firebase.firestore();
// import Confirm from "@/components/Confirm.vue";

export default {
  //   components: { Confirm },
  data: () => ({
    today: new Date().toISOString().substr(0, 10),
    focus: new Date().toISOString().substr(0, 10),
    type: "month",
    typeToLabel: {
      month: "Month",
      week: "Week",
      day: "Day",
      "4day": "4 Days",
    },
    deleteConfirmation: false,
    confirm: false,
    name: "Calendar",
    details: null,
    start: null,
    end: null,
    color: "#1976D2",
    currentlyEditing: null,
    selectedEvent: {},
    selectedElement: null,
    selectedOpen: false,
    dialog: false,
    events: [],
    check: false,
    colors: {
      blue: "blue",
      indigo: "indigo",
      deep_purple: "deep-purple",
      cyan: "cyan",
      green: "green",
      orange: "orange",
      grey: "grey darken-1",
    },
  }),
  methods: {
    async getAppointments() {
      this.events = [];
      let snapshot = await db.collection("appointments").get();
      let events = [];
      snapshot.forEach((doc) => {
        let appData = doc.data();
        let endDate = "" + doc.data().EndDate + " " + doc.data().EndTime;
        let startDate = "" + doc.data().StartDate + " " + doc.data().StartTime;
        appData.id = doc.id;
        events.push(appData);
        this.events.push({
          details: doc.data().Description,
          name: doc.data().Name,
          end: endDate,
          start: startDate,
          color: this.colors.grey,
          approved: doc.data().Approved,
          id: doc.id,
        });
      });
      //   console.log(this.events);
    },
    async approveAppointment(ev) {
      this.getAppointmentCheckByID(ev);
      if (!this.check) {
        await db.collection("appointments").doc(ev).update({
          Approved: true,
        });
        this.selectedOpen = false;
        console.log("Updated firebase: Approved: true" );
      } else {
        console.log("Did not update firebase");
        this.selectedOpen = false;
      }
    },
    async deleteAppointment(ev) {
      await db.collection("appointments").doc(ev).delete();
      this.selectedOpen = false;
      this.getAppointments();
    },
    //Goes through the array to check if the appointment with that id has been approved or not
    getAppointmentCheckByID(id) {
      this.events.forEach((app) => {
        if (app.id === id) {
          this.check = app.approved;
        }
      });
    },
    viewDay({ date }) {
      this.focus = date;
      this.type = "day";
    },
    getEventColor(event) {
      return event.color;
    },
    setToday() {
      this.focus = "";
    },
    prev() {
      this.$refs.calendar.prev();
    },
    next() {
      this.$refs.calendar.next();
    },
    showEvent({ nativeEvent, event }) {
      const open = () => {
        this.selectedEvent = event;
        this.selectedElement = nativeEvent.target;
        requestAnimationFrame(() =>
          requestAnimationFrame(() => (this.selectedOpen = true))
        );
      };

      if (this.selectedOpen) {
        this.selectedOpen = false;
        requestAnimationFrame(() => requestAnimationFrame(() => open()));
      } else {
        open();
      }

      nativeEvent.stopPropagation();
    },
    updateRange({ start, end }) {
      this.start = start;
      this.end = end;
    },
    rnd(a, b) {
      return Math.floor((b - a + 1) * Math.random()) + a;
    },
  },
  mounted() {
    this.getAppointments();
    this.$refs.calendar.checkChange();
  },
  computed: {
    title() {
      const { start, end } = this;
      if (!start || !end) {
        return "";
      }
      const startMonth = this.monthFormatter(start);
      const endMonth = this.monthFormatter(end);
      const suffixMonth = startMonth === endMonth ? "" : endMonth;
      const startYear = start.year;
      const endYear = end.year;
      const suffixYear = startYear === endYear ? "" : endYear;
      const startDay = start.day + this.nth(start.day);
      const endDay = end.day + this.nth(end.day);
      switch (this.type) {
        case "month":
          return `${startMonth} ${startYear}`;
        case "week":
        case "4day":
          return `${startMonth} ${startDay} ${startYear} - ${suffixMonth} ${endDay} ${suffixYear}`;
        case "day":
          return `${startMonth} ${startDay} ${startYear}`;
      }
      return "";
    },
    monthFormatter() {
      return this.$refs.calendar.getFormatter({
        timeZone: "UTC",
        month: "long",
      });
    },
  },
};
</script>

<style scoped>
.error {
  color: red !important;
  background-color: grey !important;
}
</style>