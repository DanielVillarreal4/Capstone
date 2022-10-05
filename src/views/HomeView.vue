<template>
  <div>
    <!-- first section header -->
    <section class="header">
      <nav>
        <!-- LOGO -->
        <v-img src="public\CC_Icon.png" alt="LOGO" height="120"></v-img>

        <!-- menu class-->
        <div class="menu-text" id="menu">
          <!-- icon open menu for phons -->
          <i class="fa fa-remove" onClick="CloseMenu()"></i>
          <!-- menu-->
          <!-- <ul>
						<li> <a href="HomePage.html">HOME</a></li>
						<li> <a href="">ABOUT</a></li>
						<li> <a href="">CONTACT US</a></li>
						<li> <a href="">LOGIN</a></li>
					</ul> -->
        </div>

        <!-- icon close menu for phons -->
        <i class="fa fa-reorder" onClick="OpenMenu()"></i>
      </nav>

      <!--  Welcomeing text-->
      <div class="text-box">
        <h1 class="text-center">
          <br />
          Welcome to C and C Systems
        </h1>
        <p>Some quick example text content.</p>

        <!-- click one -->
        <a href="" class="Click">Click Here</a>
      </div>
    </section>
    <!------------------- About Us -------------------->
    <section class="About"></section>
    <h1>About Us</h1>
    <p>Learn more</p>

    <div class="row">
      <div class="boxs">
        <h2>About us</h2>
        <p>
          Some quick example text content Some quick example text content Some
          quick example text content
        </p>
      </div>
      <div class="boxs">
        <h2>About us</h2>
        <p>
          Some quick example text content Some quick example text content Some
          quick example text content
        </p>
      </div>
      <div class="boxs">
        <h2>About us</h2>
        <p>
          Some quick example text content Some quick example text content Some
          quick example text content
        </p>
      </div>
    </div>

    <!------------------- CONTACT us ------------------>

    <section class="CONTACT"></section>
    <div class="CONTACT-boxs">
      <h1>Contact Us</h1>
      <p>
        Some quick example text content Some quick example text content Some
        quick example text content
      </p>
      <h5>C&C System</h5>
      <p>
        Some quick example text content Some quick example text content Some
        quick example text content
      </p>
    </div>

    <div class="LOCATION-box">
      <iframe
        src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d26051.924996458845!2d-93.1536566604492!3d35.293788800000016!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x87cc5308668a24f7%3A0xadcf40b5dc41909!2sArkansas%20Tech%20University!5e0!3m2!1sen!2sus!4v1664352396628!5m2!1sen!2sus"
        width="600"
        height="450"
        style="border: 0"
        allowfullscreen=""
        loading="lazy"
        referrerpolicy="no-referrer-when-downgrade"
      ></iframe>
    </div>

    <!--- foooter-->

    <section class="footer">
      <h4 class="text-center1">
        <br />
        About Us
      </h4>
      <p>Some quick example text content.</p>
      <div class="footer-row"></div>

      <!-- owner media if any-->
      <dic class="icons">
        <i class="fa fa-facebook"></i>
        <i class="fa fa-twitter"></i>
        <i class="fa fa-instagram"></i>
      </dic>
      <p>COPYRIGHT © 2022 - ALL RIGHTS RESERVED.</p>
    </section>

    <!-- function for open and close menu for phons users-->
  </div>
</template>
  <!-- <div>
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
  </div> -->

<script>
// import HelloWorld from '../components/HelloWorld'
// import shared from "../Shared/shared.js";
import axios from "axios";
// import NavBar from "@/components/NavBar";

export default {
  name: "HomeView",
  // components: {NavBar},
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

* {
  margin: 0;
  padding: 0;
  font-family: "Source Sans Pro", sans-serif;
}

/* text and background */
.header {
  min-height: 100vh;
  width: 100%;
  background-image: linear-gradient(rgba(4, 9, 30, 0.7), rgba(4, 9, 30, 0.7));
  background-position: center;
  background-size: cover;
  position: relative;
}

/* logo size*/
nav img {
  width: 180px;
}

nav {
  display: flex;
  justify-content: space-between;
  align-items: center;
}

/* menu style */
.menu-text {
  flex: 1;
  text-align: right;
}

.menu-text ul li {
  list-style: none;
  display: inline-block;
  padding: 8px 12px;
  position: relative;
}

.menu-text ul li a {
  color: whitesmoke;
  text-decoration: none;
  font-size: 15px;
}

/* some underline for menu texts */
.menu-text ul li::after {
  content: "";
  width: 0%;
  height: 2px;
  background: #002de7;
  display: block;
  margin: auto;
  transition: 0.1s;
}

.menu-text ul li:hover::after {
  width: 100%;
}

/* text style*/
.text-box {
  widows: 80%;
  margin: auto;
  text-align: center;
  padding-top: 100px;
  transform: translate(-50%, -50);
}

/* Welcomee text style*/
.text-box h1 {
  color: #ff0021;
  font-size: 60px;
}

/* under the Welcomee text style*/
.text-box p {
  margin: 5px 0 0px;
  font-size: 15px;
  color: aliceblue;
}

/* click here style */
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
  margin-bottom: 25px;
}

.Click:hover {
  border: 2px solid #5d76dd;
  background: #5d76dd;
  transition: 0.1s;
}

/* block the open/close icons for pc users*/
nav .fa {
  display: none;
}

/* menu for phone users*/
@media (max-width: 700px) {
  .text-box h1 {
    font-size: 30px;
  }

  .menu-text ul li {
    display: block;
  }

  .menu-text {
    position: absolute;
    background: #002de7;
    height: 100vh;
    width: 200px;
    top: 0;
    right: -200px;
    text-align: left;
    z-index: 2;
    transition: 0.1s;
  }

  nav .fa {
    display: block;
    color: red;
    margin: 10px;
    font-size: 25px;
    cursor: pointer;
  }

  .menu-text ul {
    padding: 30px;
  }
}

/* -------About----------*/

/*About text*/
.About {
  widows: 80%;
  margin: auto;
  padding-top: 30px;
}

/* CONTACT */
.CONTACT {
  widows: 80%;
  margin: auto;
  padding-top: 15px;
}

/*About text style */
h1 {
  font-size: 40px;
  text-align: center;
  font-weight: 500;
}

/* small text under the About US text*/
p {
  color: #777;
  font-size: 15px;
  font-weight: 250;
  line-height: 25px;
  padding: 15px;
  text-align: center;
}

/* row style*/
.row {
  margin: 5%;
  display: flex;
  justify-content: space-between;
}

h2 {
  font-size: 25px;
  text-align: center;
  font-weight: 500;
}

/* small text under the About US text*/
p {
  color: #777;
  font-size: 15px;
  font-weight: 250;
  line-height: 25px;
  padding: 15px;
  text-align: center;
}

/* CONTACT, PHONE, work and location style*/
.boxs {
  flex-basis: 30%;
  background: #fff3f3;
  border-radius: 25px;
  margin-bottom: 2%;
  padding: 10px 10px;
  box-sizing: border-box;
  transition: 0.5s;
}

.CONTACT-boxs {
  flex-basis: 30%;
  background: #f8f2f2;
  border-radius: 25px;
  box-sizing: border-box;
  transition: 0.5s;
  overflow: hidden;
  padding-bottom: 10%;
  margin-bottom: 1%;
  position: relative;
  height: 5;
}

h5 {
  font-size: 25px;
  text-align: center;
  font-weight: 500;
}

/* small text under the About US text*/
p {
  color: #777;
  font-size: 15px;
  font-weight: 250;
  line-height: 25px;
  padding: 15px;
  text-align: center;
}

/* for pc and phone useers */
.LOCATION-box {
  flex-basis: 30%;
  background: #a4dcff;
  border-radius: 1px;
  margin-bottom: 1%;
  box-sizing: border-box;
  transition: 0.5s;
  overflow: hidden;
  padding-bottom: 30%;
  position: relative;
  height: 0;
}

.LOCATION-box iframe {
  left: 0;
  top: 0;
  height: 100%;
  width: 100%;
  position: absolute;
}

/* Make effects when the mouse touch the box*/
.boxs:hover {
  box-shadow: 0 0 20px 0px rgba(0, 0, 0, 0.2);
}

.CONTACT-boxs:hover {
  box-shadow: 0 0 20px 0px rgba(0, 0, 0, 0.2);
}

.LOCATION-box:hover {
  box-shadow: 0 0 20px 0px rgba(0, 0, 0, 0.2);
}

/* how it appear on phone users*/
@media (max-width: 700px) {
  .row {
    flex-direction: column;
  }
}

/* footer */
/* title text size and style*/
.footer {
  width: 100%;
  text-align: center;
  padding: 1px 0;
  background: #1a1010;
}

.footer h4 {
  margin-bottom: 5px;
  margin-top: 20px;
  font-weight: 600;
  color: azure;
}

.footer p {
  color: azure;
}

/* icons size and style*/
.icons .fa {
  color: red;
  margin: 0 13px;
  cursor: pointer;
}
</style>

