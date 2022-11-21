<template>
  <div>
    <head>
      <!-- Page title -->
      <title>home</title>

      <!-- icons library-->
      <meta name="viewport" content="width=device-width, initial-scale=1.0" />
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
      <div class="header-box" >

      <!--  Welcomeing text-->
      <div class="text-box">
        
        <h1 class="text-center">
          <br />
        </h1>
        
      </div>
    </div>
    </section>
    <!------------------- About Us -------------------->
    <section class="About"></section>
    <h1>Services We Offer</h1>
    <p></p>
    <div class="row">
      <div class="boxs">
        <h2>Computer Networking</h2>
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
        <h2>8-5 time on scheduler</h2>
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
        <h2>We are LLC</h2>
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

    <section class="CONTACT">
    <div class="CONTACT-boxs">
      <h1>Contact Us</h1>

      <div class="text-box1">
          <!-- click one -->
        
      <a href="mailto:Catessystems@gmail.com" target="_blank" style="color:#azure; text-decoration:none;" 
      class="Click1">General business email</a>
    </div>

    <div class="cc"> 
        <h5>C&C System</h5>
        <p>
          C & C Systems is a business built on a strong 
        foundation. This foundation has many layers. 
        First and foremost, we are a Christian-based 
        company and believe God, and he will always be our strength. 
        God will always provide. The next layer of our foundation is made up of family. 
        Our family is made up of more than flesh and the blood that runs through our veins.
        </p>
        <p> 
        Our family is always constantly growing, and we strive to treat our customers as if they 
        truly were our own flesh and blood. Friends, all I can say is that you can never have too 
        many and we look for friendship wherever we go. With a foundation made up of God, family, 
        and friends, where can you go wrong with anything you try to accomplish as company.</p>
        <p> 
 Our company is based on security, and we know this better than most. One of our owners served his 
 country for more than 24 years of his life fighting for all Americans security and freedoms. </p>
 <p> 
 C&C Systems understand what it takes to take protect what you have and the safety of the loved ones in our lives.
 If you are looking for a company that treats you like family and friends, with more than 33 years of 
 combined experience, then you should look no further. C&C Systems will be there insured you can protect 
 what you have earned and your loved one’s safety.
        </p>
      </div>
      <h4 class="text-center1">      
      <img class="mx-auto w-2/3 sm:w-2/3 md:w-1/2 lg:w-2/3" 
      src="../../public/label.png">
    </h4>
    </div>
  </section>
    
    <!--- foooter-->

    <section class="footer">
      <h4 class="text-center1">
        <br />
        Follow us
      </h4>
      <div class="footer-row"></div>

      <!-- owner media if any-->
      <div class="icons">
        <a href = "https://www.facebook.com/" target="_blank" style="color:#azure; text-decoration:none;">
          <i class="fa fa-facebook"></i> </a>
        
          <a href = "https://www.twitter.com/" target="_blank" style="color:#azure; text-decoration:none;">
            <i class="fa fa-twitter"></i> </a>

          <a href = "https://www.instagram.com/" target="_blank" style="color:#azure; text-decoration:none;">
            <i class="fa fa-instagram"></i> </a>
      </div>
      <p>COPYRIGHT © 2022 - ALL RIGHTS RESERVED.</p>
    </section>
  </div>
</template>
<script>

export default {
  name: "HomeView",
  components: {
    
  },
  data() {
    return {
      items: [
        {
          src: "../../public/pic0.png "
        },
        {
          src: "../../public/pic1.png "
        },
        {
          src: "pic2.png"
        },
        {
          src: "pic3.png"
        },
        {
          src: "label.png"
        },
        {
          src: "../../public/CC_4w.png"
        },
        {
          src: "../../public/picl.png"
        }
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

<style lang="css" scoped>
.carouselClass {
  align-content: center !important;
  justify-content: center !important;
} 

.v-application p,
.v-application h1 {
  text-align: center;
}

* {
  margin: 0;
	padding: 0;
	border: 0;
	vertical-align: baseline;
}

/* text and background */
.header {
min-height: 100vh;
width: 100%;
background-image: linear-gradient(rgba(4,9,30,0.7),rgba(4,9,30,0.7)),
url("../../public/picl.png");
background-position: center;
background-size: cover;
position: relative;
}
.header-box{
min-height: 100vh;
width: 100%;
background-image: linear-gradient(rgba(4,9,30,0.7),rgba(4,9,30,0.7)),
url("../../public/pic0.png");
background-position: center;
background-size: cover;
position: absolute;
opacity: 3; 
transition: 0.5s ease;
}

.header-box:hover{
min-height: 100vh;
width: 100%;
position: absolute;
opacity: 3%;
transition: 1s ease;

}


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
.About p {
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
.boxs h2 {
  font: 30px "Fira Sans", serif;
  text-align: center;
  font-weight: bold;
}

/* small text under the About US text*/
.boxs p {
  color: rgb(0, 0, 0);
  font:  22px "Fira Sans", serif;
  font-weight: 250;
  line-height: 25px;
  padding: 15px;
  text-align: center;
}

p {
  color: #777;
  font:  15px "Fira Sans", serif;
  font-weight: 250;
  line-height: 25px;
  padding: 15px;
  text-align: center;
}

/* CONTACT, PHONE, work and location style*/
.boxs {
  flex-basis: 30%;
  border-radius: 60px;
  margin-bottom: 2%;
  padding: 10px 10px;
  box-sizing: border-box;
  transition: 0.5s;
}


.CONTACT-boxs {
  flex-basis: 30%;
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

.CONTACT-boxs h5 {
  font: 25px "Fira Sans", serif;
  text-align: center;
  font-weight: bold;
}

/* small text under the About US text*/
.CONTACT-boxs p {
  color: rgb(0, 0, 0);
  font: 22px "Fira Sans", serif;
  font-weight: 250;
  line-height: 25px;
  padding: 15px;
  text-align: center;
}


/* Make effects when the mouse touch the box About us boxs*/
.boxs:hover {
  box-shadow: 0 0 20px 0px rgba(184, 182, 182, 0.2);
}

.CONTACT-boxs:hover {
  box-shadow: 0 0 20px 0px rgba(184, 182, 182, 0.2);
}


/* how it appear on phone users*/
@media( max-width: 768px){
  
.header {
min-height: 100vh;
width: 100%;
background-image: linear-gradient(rgba(4,9,30,0.7),rgba(4,9,30,0.7)),

url("../../public/CC_4wq.png");
background-position: center;
background-size: cover;
position: relative;
}


.header-box{
  display: none;
min-height: 100vh;
width: 100%;
background-position: center;
background-size: cover;
position: relative;
}



.header-box:hover{
display: none;
min-height: 100vh;
width: 100%;
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

.label {
  width: 100%;
  text-align: center;
  padding: 1px 0;
}
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