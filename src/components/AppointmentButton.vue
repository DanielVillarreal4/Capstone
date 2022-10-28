<template>
  <div>
    <v-btn class="Click mr-4" @click="dialog = true">Create Appointment</v-btn>
    <v-dialog v-model="dialog" max-width="600">
      <v-card>
        <v-container>
          <v-card-title>Create Appointment</v-card-title>
          <v-form @submit.prevent="addAppointment">
            <v-row>
              <v-col cols="12" sm="6" md="12">
                <v-text-field
                  v-model="name"
                  type="text"
                  label="Your Name/Business Name"
                ></v-text-field
              ></v-col>
              <v-col cols="12" sm="6" md="6">
                <v-text-field
                  v-model="phonenumber"
                  type="text"
                  label="Phone Number"
                ></v-text-field
              ></v-col>
              <v-col cols="12" sm="6" md="6">
                <v-text-field
                  v-model="email"
                  type="text"
                  label="Email Address"
                ></v-text-field
              ></v-col>
              <v-col cols="12" sm="6" md="6">
                <v-text-field
                  v-model="streetaddress"
                  type="text"
                  label="Street Address"
                ></v-text-field
              ></v-col>
              <v-col cols="12" sm="6" md="6">
                <v-text-field
                  v-model="city"
                  type="text"
                  label="City"
                ></v-text-field
              ></v-col>
              <v-col cols="12" sm="6" md="6">
                <v-text-field
                  v-model="state"
                  type="text"
                  label="State"
                ></v-text-field
              ></v-col>
              <v-col cols="12" sm="6" md="6">
                <v-text-field
                  v-model="zipcode"
                  type="text"
                  label="Zip Code"
                ></v-text-field
              ></v-col>
              <v-col cols="12" sm="12" md="12">
                <v-menu
                  v-model="menu1"
                  :close-on-content-click="false"
                  :nudge-right="40"
                  transition="scale-transition"
                  offset-y
                  min-width="auto"
                >
                  <template v-slot:activator="{ on, attrs }">
                    <v-text-field
                      v-model="dateFormatted"
                      label="Appointment Date"
                      prepend-icon="mdi-calendar"
                      readonly
                      v-bind="attrs"
                      v-on="on"
                    ></v-text-field>
                  </template>
                  <v-date-picker
                    v-model="date"
                    @input="menu1 = false"
                  ></v-date-picker> </v-menu
              ></v-col>
              <v-col cols="12" sm="6" md="6">
                <v-menu
                  ref="menu"
                  v-model="menu3"
                  :close-on-content-click="false"
                  :nudge-right="40"
                  :return-value.sync="time"
                  transition="scale-transition"
                  offset-y
                  max-width="290px"
                  min-width="290px"
                >
                  <template v-slot:activator="{ on, attrs }">
                    <v-text-field
                      v-model="formattedStartTime"
                      label="Start Time"
                      prepend-icon="mdi-clock-time-four-outline"
                      readonly
                      v-bind="attrs"
                      v-on="on"
                    ></v-text-field>
                  </template>
                  <v-time-picker
                    v-if="menu3"
                    v-model="starttime"
                    :allowed-hours="allowedHours"
                    min="9:00"
                    max="20:00"
                    full-width
                    @click:minute="$refs.menu.save(time)"
                  ></v-time-picker> </v-menu
              ></v-col>
              <v-col cols="12" sm="12" md="6">
                <v-menu
                  ref="menu"
                  v-model="menu2"
                  :close-on-content-click="false"
                  :nudge-right="40"
                  :return-value.sync="time"
                  transition="scale-transition"
                  offset-y
                  max-width="290px"
                  min-width="290px"
                >
                  <template v-slot:activator="{ on, attrs }">
                    <v-text-field
                      v-model="formattedEndTime"
                      label="End Time"
                      prepend-icon="mdi-clock-time-four-outline"
                      readonly
                      v-bind="attrs"
                      v-on="on"
                    ></v-text-field>
                  </template>
                  <v-time-picker
                    v-if="menu2"
                    v-model="endtime"
                    :allowed-hours="allowedHours"
                    min="9:00"
                    max="20:00"
                    full-width
                    @click:minute="$refs.menu.save(time)"
                  ></v-time-picker>
                </v-menu>
              </v-col>
              <v-col cols="12" sm="12" md="12">
                <v-textarea
                  v-model="details"
                  type="text"
                  label="Details"
                  rows="2"
                ></v-textarea
              ></v-col>
            </v-row>
            <v-btn type="submit" class="mr-4 Click" @click.stop="dialog = false"
              >Create Appointment</v-btn
            >
            <v-btn @click="cancel" class="space">Cancel</v-btn>
          </v-form>
        </v-container>
      </v-card>
    </v-dialog>
  </div>
</template>
<script>
import firebase from "../firebaseInit.js";
const db = firebase.firestore();
export default {
  data: (vm) => ({
    dialog: false,
    name: "",
    phonenumber: "",
    email: "",
    streetaddress: "",
    city: "",
    state: "",
    zipcode: "",
    details: "",
    starttime: "",
    endtime: "",
    formattedStartTime: "",
    formattedEndTime: "",
    time: "",

    date: new Date(Date.now() - new Date().getTimezoneOffset() * 60000)
      .toISOString()
      .substr(0, 10),
    dateFormatted: vm.formatDate(
      new Date(Date.now() - new Date().getTimezoneOffset() * 60000)
        .toISOString()
        .substr(0, 10)
    ),
    menu1: false,
    menu2: false,
    menu3: false,
  }),
  computed: {
    computedDateFormatted() {
      return this.formatDate(this.date);
    },
    dateRangeText() {
      return this.dates.join(" ~ ");
    },
  },

  watch: {
    date(val) {
      if (val != null) {
        this.dateFormatted = this.formatDate(this.date);
      }
    },
    starttime(val) {
      let splitNum = val.split(":");
      let num = parseInt(splitNum[0]) - 12;
      splitNum = splitNum[1];

      if (num > 0) {
        this.formattedStartTime =
          num.toString() + ":" + splitNum.toString() + " PM";
      } else if (val.length == 0) {
        this.formattedStartTime = "";
      } else {
        this.formattedStartTime = val + " AM";
      }
    },
    endtime(val) {
      let splitNum = val.split(":");
      let num = parseInt(splitNum[0]) - 12;
      splitNum = splitNum[1];

      if (num > 0) {
        this.formattedEndTime =
          num.toString() + ":" + splitNum.toString() + " PM";
      } else if (val.length == 0) {
        this.formattedStartTime = "";
      } else {
        this.formattedEndTime = val + " AM";
      }
    },
  },

  methods: {
    allowedHours: (v) => v >= 9 && v <= 20,
    async addAppointment() {
      let Address = {
        City: this.city,
        State: this.state,
        StreetAddress: this.streetaddress,
        ZipCode: this.zipcode,
      };
      if (this.name && this.starttime && this.endtime && this.date) {
        await db.collection("appointments").add({
          Name: this.name,
          PhoneNumber: this.phonenumber,
          Description: this.details,
          Address: Address,
          Approved: false,
          Email: this.email,
          StartDate: this.date,
          EndDate: this.date,
          StartTime: this.starttime,
          EndTime: this.endtime,
        });
        console.log("Submitted Successfully.");
      } else {
        alert("Name, start and end date are required");
      }
    },
    cancel() {
      this.name = "";
      this.phonenumber = "";
      this.city = "";
      this.state = "";
      this.streetaddress = "";
      this.zipcode = "";
      this.email = "";
      this.date = "";
      this.starttime = "";
      this.endtime = "";
      this.details = "";
      this.formattedStartTime = "";
      this.formattedEndTime = "";
      this.dialog = false;
    },
    formatDate(date) {
      if (!date) return null;

      const [year, month, day] = date.split("-");
      return `${month}/${day}/${year}`;
    },
    parseDate(date) {
      if (!date) return null;

      const [month, day, year] = date.split("/");
      return `${year}-${month.padStart(2, "0")}-${day.padStart(2, "0")}`;
    },
  },
};
</script>

<style scoped>
/* click button style */
.Click {
  display: inline-block;
  text-decoration-line: none;
  color: red;
  border: 2px solid #ffffff;
  padding: 15px 30px;
  font-size: 15px;
  background: repeat;
  position: relative;
  cursor: pointer;
  background-image: linear-gradient(rgba(4,9,30,0.7),rgba(4,9,30,0.7)),
url("https://cdn.vuetifyjs.com/images/carousel/planet.jpg");
  text-transform: unset;
  font-weight: unset;
}

.Click:hover {
  border: 2px solid #4524bc;
  background: #4524bc;
  transition: 0.1s;
}
.space {
  float: right;
}
</style>