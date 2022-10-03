<template>
  <!-- <hello-world /> -->
  <div>
    <v-row class="pa-4" align="center" justify="center">
      <v-col cols="4">
        <h1 class="h1Class">Security Consults</h1>
        <p>Lots of security for you to be secure and stuff.</p>
        <p>Lots of security for you to be secure and stuff.</p>
        <p>Lots of security for you to be secure and stuff.</p>
        <p>Lots of security for you to be secure and stuff.</p>
      </v-col>
      <v-col cols="4">
        <v-carousel
          class="carouselClass pd-6"
          hide-delimiters
          show-arrows-on-hover
          cycle
          :interval="5000"
          height="300px"
        >
          <v-carousel-item
            v-for="(item, i) in items"
            :key="i"
            :src="item.src"
          ></v-carousel-item>
        </v-carousel>
      </v-col>
      <v-col cols="4">
        <h1 class="h1Class">Security Consults</h1>
        <p>Lots of security for you to be secure and stuff.</p>
        <p>Lots of security for you to be secure and stuff.</p>
        <p>Lots of security for you to be secure and stuff.</p>
        <p>Lots of security for you to be secure and stuff.</p>
      </v-col>
    </v-row>
    <v-row class="pa-4" align="center" justify="center">
      <h1></h1>
    </v-row>
  </div>
</template>

<script>
// import HelloWorld from '../components/HelloWorld'
// import shared from "../Shared/shared.js";
import axios from "axios";

export default {
  name: "HomeView",
  data() {
    return {
      items: [
        {
          src: "https://cdn.vuetifyjs.com/images/carousel/squirrel.jpg",
        },
        {
          src: "https://cdn.vuetifyjs.com/images/carousel/sky.jpg",
        },
        {
          src: "https://cdn.vuetifyjs.com/images/carousel/bird.jpg",
        },
        {
          src: "https://cdn.vuetifyjs.com/images/carousel/planet.jpg",
        },
      ],
      employees: [],
      clients: [],
      services: [],
      appointments: [],
    };
  },
  methods: {
    getAllEmployees() {
      axios.get("employee").then((response) => {
        response.data.forEach((element) => {
          this.employees.push({
            AccessID: element.AccessID,
            Email: element.Email,
            EmployeeID: element.EmployeeID,
            EmployeePhoneNumber: element.EmployeePhoneNumber,
            FName: element.FName,
            LName: element.LName,
            MName: element.MName,
          });
        });
      });
    },
    getAllClients() {
      axios.get("client").then((response) => {
        response.data.forEach((element) => {
          this.clients.push({
            AccessID: element.AccessID,
            Email: element.Email,
            ClientID: element.EmployeeID,
            ClientPhoneNumber: element.EmployeePhoneNumber,
            FName: element.FName,
            LName: element.LName,
            MName: element.MName,
          });
        });
      });
    },
    getAllServices() {
      axios.get("service").then((response) => {
        response.data.forEach((element) => {
          this.services.push({
            ServiceID: element.ServiceID,
            ServiceName: element.ServiceName,
            ServiceDescription: element.ServiceDescription,
          });
        });
      });
    },
    getAppointments() {
      axios.get("appointment").then((response) => {
        response.data.forEach((element) => {
          this.appointments.push({
            AppointmentID: element.AppointmentID,
            DateCreated: element.DateCreated,
            ClientID: element.ClientID,
            EmployeeID: element.EmployeeID,
            StreetAddress: element.StreetAddress,
            City: element.City,
            State: element.State,
            ZipCode: element.ZipCode,
            StartTime: element.StartTime,
            EndTime: element.EndTime,
            Cancel: element.Cancel,
            Description: element.Description,
          });
        });
      });
    },
  },
  mounted: function () {
    this.getAllEmployees();
    this.getAllClients();
    this.getAllServices();
    this.getAppointments();
    console.log(this.employees);
    console.log(this.clients);
    console.log(this.services);
    console.log(this.appointments);
  },
};
</script>

<style scoped>
.carouselClass {
  /* max-width: 50%; */
  align-content: center !important;
  justify-content: center !important;
}
/* .h1Class {
  text-align: start;
  align-self: auto;
  justify-self: auto;
} */
.v-application p,
.v-application h1 {
  text-align: center;
}
</style>