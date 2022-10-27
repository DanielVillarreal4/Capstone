<template>
  <div>
    <head>
  <!--npm run serve-->
  <!-- Page title -->
  <title>About</title>
  
  <!-- icons library-->
<meta name="viewport" content="with=device-width, initial-scale=1.0">
<link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Source+Sans+Pro:wght@300;400;600;700&display=swap" rel="stylesheet">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
</head>

    <!-- first section header -->
    <section class="About-header">
      <!--  Welcomeing text-->
      <div class="text-box">
        <h1 class="text-center">
          <br />
          About us
        </h1>
        <p>Some quick example text content.</p>
      </div>
    </section>
    <!------------------- About Us content one -------------------->

    <section class="about-us">
      <div class="row">
        <div class="about-usC">
          <h1 id="one"> Some quick example text content. * learn more</h1>
          <p>Some quick example text content.Some quick example text content.Some quick example text content.
            Some quick example text content.Some quick example text content.Some quick example text content.
          </p>
        </div>
        <div class="about-usC">
          <v-img src="https://cdn.vuetifyjs.com/images/carousel/planet.jpg" alt="planet" max-width="500" max-height="400"
          style=" margin-left:10px; margin-bottom:5px" ></v-img>
        </div>
      </div>
    </section>
   
<!------------------- About Us content two-------------------->    
<section class="about-us">
      <div class="row">
        <div class="about-usC">
          <h2> Some quick example text content. * learn more</h2>
          <p>Some quick example text content.Some quick example text content.Some quick example text content.
            Some quick example text content.Some quick example text content.Some quick example text content.
          </p>
        </div>
        <div class="about-usC">
          <v-img src="https://cdn.vuetifyjs.com/images/carousel/bird.jpg" alt="bird" max-width="500" height="400" 
          style=" margin-left:10px; margin-bottom:5px"></v-img>
        </div>
      </div>
    </section>

    <!------------------- About Us content three-------------------->    
<section class="about-us">
      <div class="row">
        <div class="about-usC">
          <h2> Some quick example text content. * learn more</h2>
          <p>Some quick example text content.Some quick example text content.Some quick example text content.
            Some quick example text content.Some quick example text content.Some quick example text content.
          </p>
        </div>
        <div class="about-usC">
          <v-img src="https://cdn.vuetifyjs.com/images/carousel/squirrel.jpg" alt="squirrel" max-width="500" height="400" > </v-img>
        </div>
      </div>
    </section>
    
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
  </div>
</template>
<script>
// import axios from "axios";
export default {
  name: "HomeView",
  data() {
    return {
      items: [
        {src: "https://cdn.vuetifyjs.com/images/carousel/squirrel.jpg",},
        {src: "https://cdn.vuetifyjs.com/images/carousel/sky.jpg",},
        {src: "https://cdn.vuetifyjs.com/images/carousel/bird.jpg",},
        {src: "https://cdn.vuetifyjs.com/images/carousel/planet.jpg",},
      ],
      images:[],
      employees: [],
      clients: [],
      services: [],
      appointments: [],
    };
  },
  methods: {
    // getAllEmployees() {
    //   axios.get("employee").then((response) => {
    //     response.data.forEach((element) => {
    //       this.employees.push({
    //         AccessID: element.AccessID,
    //         Email: element.Email,
    //         EmployeeID: element.EmployeeID,
    //         EmployeePhoneNumber: element.EmployeePhoneNumber,
    //         FName: element.FName,
    //         LName: element.LName,
    //         MName: element.MName,
    //       });
    //     });
    //   });
    // },
    // getAllClients() {
    //   axios.get("client").then((response) => {
    //     response.data.forEach((element) => {
    //       this.clients.push({
    //         AccessID: element.AccessID,
    //         Email: element.Email,
    //         ClientID: element.EmployeeID,
    //         ClientPhoneNumber: element.EmployeePhoneNumber,
    //         FName: element.FName,
    //         LName: element.LName,
    //         MName: element.MName,
    //       });
    //     });
    //   });
    // },
    // getAllServices() {
    //   axios.get("service").then((response) => {
    //     response.data.forEach((element) => {
    //       this.services.push({
    //         ServiceID: element.ServiceID,
    //         ServiceName: element.ServiceName,
    //         ServiceDescription: element.ServiceDescription,
    //       });
    //     });
    //   });
    // },
    // getAppointments() {
    //   axios.get("appointment").then((response) => {
    //     response.data.forEach((element) => {
    //       this.appointments.push({
    //         AppointmentID: element.AppointmentID,
    //         DateCreated: element.DateCreated,
    //         ClientID: element.ClientID,
    //         EmployeeID: element.EmployeeID,
    //         StreetAddress: element.StreetAddress,
    //         City: element.City,
    //         State: element.State,
    //         ZipCode: element.ZipCode,
    //         StartTime: element.StartTime,
    //         EndTime: element.EndTime,
    //         Cancel: element.Cancel,
    //         Description: element.Description,
    //       });
    //     });
    //   });
    // },
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
  align-content: center !important;
  justify-content: center !important;
}

.v-application p,
.v-application h1 {
  text-align: center;
}

/* text and background */
.About-header {
  height: 90vh;
  width: 100%;
  background-image: linear-gradient(rgba(4,9,30,0.7),rgba(4,9,30,0.7));
  background-position: center;
  background-size: cover;
  position: relative;
}

.About-header h1{
  margin-top: 100px;
}

/* about-us content */
.about-us{
  width: 80%;
  margin: auto;
  padding-top: 10px;
  padding-bottom: 20px;
}

/* about-usC */
.about-usC{
  flex-basis: 50%;
  padding: 30px 10px;
}

.about-usC h1{
  padding-top: 0;
}

.about-usC p{
  padding: 15px 0 25px;
  
}

/* about-us content 1 */
.about-us1 {
  width: 80%;
  margin: auto;
  padding-top: 10px;
  padding-bottom: 20px;
  align-content: right;

}

/* about-usC */
.about-usC1 {
  flex-basis: 50%;
  padding: 30px 10px;
}

.about-usC1 h2{
  padding-top: 0;
}

.about-usC1 p{
  padding: 15px 0 25px;
}

.about-usC1 img {
  margin-left:10px; 
  margin-bottom:5px
  
}

/* text style*/
.text-box {
  widows: 80%;
  margin: auto;
  text-align: center;
  padding-top: 100px;
  transform: translate(-50%, -50);
}

/* title About us text style*/
.text-box h1 {
  color: #c82020;
  font-size: 60px;
  margin-top: 30px;
}

/* under the title about us text style*/
.text-box p {
  margin: 5px 0 0px;
  font-size: 15px;
  color: aliceblue;
}

/*About text style */
h1 {
  font-size: 40px;
  text-align: center;
  font-weight: 500;
}

/* the text nex to the pictures */
h2 {
  font-size: 40px;
  text-align: center;
  font-weight: 500;
}

/* small text nex to the pictures*/
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


