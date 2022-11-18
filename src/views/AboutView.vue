<template>
  <div>
    <head>
      <!-- Page title -->
      <title>About</title>

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
  <section class="About">
      <!--<v-img src="../../public/pic0.png" alt="LOGO" max-width="120" max-height="120"></v-img>-->

      <!--  Contact text-->
      <div class="text-box">
        <h1 class="text-center">
          <br />
          About us
        </h1>
      </div>
    </section>
    <!------------------- About Us content -------------------->
    <!-- first section header -->

    <section class="container">
      <div class="row">
      <div class="text">
        <h1>Some quick example text content.</h1>
        <p>Some quick example text content.Some quick example text content.Some quick example text content.
            Some quick example text content.Some quick example text content.Some quick example text content.
        </p>
      </div>
      <div class="image">
        <img src="../../public/pic1.png">
      </div>
    </div>
    </section>

        <!-- seconed section header -->

    <section class="container">
      <div class="row">
      <div class="text">
        <h1>Some quick example text content.</h1>
        <p>Some quick example text content.Some quick example text content.Some quick example text content.
            Some quick example text content.Some quick example text content.Some quick example text content.
        </p>
      </div>
      <div class="image">
        <img src="../../public/pic2.png">
      </div>
    </div>
    </section>
    <!-- third section header -->

    <section class="container">
      <div class="row">
      <div class="text">
        <h1>Some quick example text content.</h1>
        <p>Some quick example text content.Some quick example text content.Some quick example text content.
            Some quick example text content.Some quick example text content.Some quick example text content.
        </p>
      </div>
      <div class="image">
        <img src="../../public/pic3.png">
      </div>
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
  name: "AbouttView",
  data() {
    return {
      items: [
        {
          src: "../../public/pic0.png ",
        },
        {
          src: "../../public/pic1.png ",
        },
        {
          src: "../../public/pic2.png",
        },
        {
          src: "../../public/pic3.png",
        },
        {
          src: "CC_4w.png"
        }
      ],
      images: [],
      employees: [],
      clients: [],
      services: [],
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

* {
  margin: 0;
	padding: 0;
	border: 0;
	vertical-align: baseline;
}

/* text and background */
.About {
min-height: 100vh;
width: 100%;
background-image: linear-gradient(rgba(4,9,30,0.7),rgba(4,9,30,0.7)),
url("../../public/pic0.png");
background-position: center;
background-size: cover;
position: relative;
}

.container {
        display: flex;
        align-items: center;
        justify-content: center
      }
      img {
        width: 100%;
        border-radius: 60px;
        max-height:  12cm;
      }
      .image {
        flex-basis: 40%;
        order: 3;
      }

/*
 .text {
        color: #CD5C5C;
        padding-left: 30px;
        font: italic 10px "Fira Sans", serif;
      }

*/
      .text { 
        color: #CD5C5C;
        padding-left: 30px 10px;
        flex-basis: 50%;
        background: rgb(255, 253, 253);
        border-radius: 60px;
        margin-bottom: 2%;
        font: italic 10px "Fira Sans", serif;
        box-sizing: border-box;
        transition: 0.5s;
      }

  .text:hover {
    box-shadow: 0 0 15px 0px rgba(184, 182, 182, 0.2);
}

.text p{
  color: #000000;
  padding: 22px 15px 25px;
  font: 22px "Fira Sans", serif;
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
  color: #c82020;
  font:  60px "Fira Sans", serif;
  margin-top: 30px;
}

/* under the Welcomee text style*/
.text-box p {
  margin: 5px 0 0px;
  font-size: 15px;
  color: aliceblue;
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

/* how it appear on phone users*/
@media(max-width: 768px){
.About {
min-height: 100vh;
width: 100%;
background-image: linear-gradient(rgba(4,9,30,0.7),rgba(4,9,30,0.7)),
url("../../public/pic0.png");
background-position: center;
background-size: cover;
position: relative;
}


.text-box {
  widows: 80%;
  margin: auto;
  text-align: center;
  padding-top: 100px;
  transform: translate(-50%, -50);
}
.container {
        display: flex;
        align-items: center;
        justify-content: center
      }
      img {
        width: 100%;
        border-radius: 60px;
        max-height:  10cm;
      }
      .image {
        flex-basis: 50%;
        order: 2;
      }
      .text {
        color: #CD5C5C;
        padding-left: 30px;
        font: italic 10px "Fira Sans", serif;
      }

	.text-box h1{
		font-size: 40px;
	}

  .text p{
  color: #000000;
  padding: 5px 0 2px;
  font: 22px "Fira Sans", serif;
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


