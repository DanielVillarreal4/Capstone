<template>
  <div>
    <head>
      <!-- Page title -->
      <title>home</title>

      <!-- icons library-->
      <meta name="viewport" content="with=device-width, initial-scale=1.0" />
      <link rel="preconnect" href="https://fonts.googleapis.com" />
      <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
      <link
        href="https://fonts.googleapis.com/css2?family=Source+Sans+Pro:wght@300;400;600;700&display=swap"
        rel="stylesheet"
      />
      <link
        rel="stylesheet"
        href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"
      />
    </head>


    <!-- first section header -->
    <section class="header">
      <!--<v-img src="pic0.png" alt="LOGO" max-width="120" max-height="120"></v-img>-->

      <!--  Welcomeing text-->
      <div class="text-box">
        <h1 class="text-center">
          <br />
          Welcome to C and C Systems
        </h1>
        <p>Some quick example text content.</p>
      
        <appointment-button/>
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

        <div class="text-box1">
          <!-- click one -->
          <a href="about" class="Click1">Learn more</a>
        </div>
      </div>
      <div class="boxs">
        <h2>About us</h2>
        <p>
          Some quick example text content Some quick example text content Some
          quick example text content
        </p>
        <div class="text-box1">
          <!-- click one -->
          <a href="about" class="Click1">Learn more</a>
        </div>
      </div>
      <div class="boxs">
        <h2>About us</h2>
        <p>
          Some quick example text content Some quick example text content Some
          quick example text content
        </p>
        <div class="text-box1">
          <!-- click one -->
          <a href="about" class="Click1">Learn more</a>
        </div>
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
    <!--
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
    </div> -->

    
    <!--- foooter-->

    <section class="footer">
      <h4 class="text-center1">
        <br />
        About Us
      </h4>
      <p>Some quick example text content.</p>
      <div class="footer-row"></div>

      <!-- owner media if any-->
      <div class="icons">
        <i class="fa fa-facebook"></i>
        <i class="fa fa-twitter"></i>
        <i class="fa fa-instagram"></i>
      </div>
      <p>COPYRIGHT © 2022 - ALL RIGHTS RESERVED.</p>
    </section>
  </div>
</template>
<script>
import AppointmentButton from "../components/AppointmentButton.vue";

export default {
  name: "HomeView",
  components: {
    AppointmentButton,
  },
  data() {
    return {
      items: [
        {
          src: "pic0.png ",
        },
        {
          src: "pic1.png ",
        },
        {
          src: "pic2.png",
        },
        {
          src: "pic3.png",
        },
      ],
      images: [],
      employees: [],
      clients: [],
      services: [],
      appointments: [],
    };
  },
  methods: {},
  mounted: function () {},
};
</script>

<style scoped>
.carouselClass {
  align-content: center !important;
  justify-content: center !important;
}

.v-application p,
.v-application h1 {
  text-align: center;
}

/* text and background */
.header {
min-height: 100vh;
width: 100%;
background-image: linear-gradient(rgba(4,9,30,0.7),rgba(4,9,30,0.7)),
url("pic0.png");
background-position: center;
background-size: cover;
position: relative;
}


/* logo size
nav img {
  width: 180px;
}

nav {
  display: flex;
  justify-content: space-between;
  align-items: center;
}
*/

/* text style*/
.text-box {
  widows: 80%;
  margin: auto;
  text-align: center;
  padding-top: 100px;
  transform: translate(-50%, -50);
}

.text-box1 {
  widows: 10%;
  margin: auto;
  text-align: center;
  padding-top: 1px;
  transform: translate(-50%, -50);
}

/* Welcomee text style*/
.text-box h1 {
  color: #c82020;
  font: italic 60px "Fira Sans", serif;
  margin-top: 30px;
}

/* under the Welcomee text style*/
.text-box p {
  margin: 5px 0 0px;
  font-size: 15px;
  color: aliceblue;
}

/* click inside about box */
.Click1 {
  display: inline-block;
  text-decoration-line: none;
  color: red;
  border: 2px solid #535151;
  padding: 15px 30px;
  font-size: 15px;
  background: repeat;
  position: relative;
  cursor: pointer;
  border-radius: 60px;
  margin-bottom: 25px;
}

.Click1:hover {
  border: 2px solid #4524bc;
  background: #4524bc;
  border-radius: 60px;
  transition: 0.1s;
}
.text-box1 {
  widows: 10%;
  margin: auto;
  text-align: center;
  padding-top: 1px;
  transform: translate(-50%, -50);
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
  font:  40px "Fira Sans", serif;
  text-align: center;
  font-weight: 500;
}

/* small text under the About US text*/
p {
  color: #777;
  font:  15px "Fira Sans", serif;
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

/*about inside the boxes */
h2 {
  font: 30px "Fira Sans", serif;
  text-align: center;
  font-weight: bold;
}

/* small text under the About US text*/
p {
  color: #777;
  font:  25px "Fira Sans", serif;
  font-weight: 250;
  line-height: 25px;
  padding: 15px;
  text-align: center;
}

/* CONTACT, PHONE, work and location style*/
.boxs {
  flex-basis: 30%;
  background: whitesmoke;
  border-radius: 60px;
  margin-bottom: 2%;
  padding: 10px 10px;
  box-sizing: border-box;
  transition: 0.5s;
}

.CONTACT-boxs {
  flex-basis: 30%;
  /*background: #f8f2f2;*/
  border-radius: 25px;
  box-sizing: border-box;
  transition: 0.5s;
  overflow: hidden;
  padding-bottom: 10%;
  margin-bottom: 1%;
  position: relative;
  height: 5;
}

.text-center1 {
  font: 15px "Fira Sans", serif;
  font-weight: bold;
  line-height: 25px;
  padding: 15px;
  text-align: center;
  margin-bottom: 1%;
}

h5 {
  font: 25px "Fira Sans", serif;
  text-align: center;
  font-weight: bold;
}

/* small text under the About US text*/
p {
  color: #777;
  font: 15px "Fira Sans", serif;
  font-weight: 250;
  line-height: 25px;
  padding: 15px;
  text-align: center;
}

/* for pc and phone useers 
.LOCATION-box {
  flex-basis: 30%;
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
} */

/* Make effects when the mouse touch the box About us boxs*/
.boxs:hover {
  box-shadow: 0 0 20px 0px rgba(184, 182, 182, 0.2);
}

.CONTACT-boxs:hover {
  box-shadow: 0 0 20px 0px rgba(184, 182, 182, 0.2);
}

/* 
.LOCATION-box:hover {
  box-shadow: 0 0 20px 0px rgba(184, 182, 182, 0.2);
}*/

/* how it appear on phone users*/
@media(max-width: 700px){
.header {
min-height: 100vh;
width: 100%;
background-image: linear-gradient(rgba(4,9,30,0.7),rgba(4,9,30,0.7)),
url("pic0.png");
background-position: center;
background-size: cover;
position: relative;
}
	.text-box h1{
		font-size: 40px;
	}

	nav .fa{
		display: block;
		color: red;
		margin: 10px;
		font-size: 25px;
		cursor: pointer;
	}
	.row {
    flex-direction: column;
  }

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


