<template>
  <div>
    <head>
  <!-- npm run serve -->
  <!-- Page title -->
  <title>profile</title>
  
  <!-- icons library-->
<meta name="viewport" content="with=device-width, initial-scale=1.0">
<link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Source+Sans+Pro:wght@300;400;600;700&display=swap" rel="stylesheet">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
</head>



<section class="profile-info">
    <div class="box">
      
      <img :src="$auth.user.picture" alt="User's profile picture" class="user-picture">
      <h2> Basic info</h2>
      <div class="box2">

    <h3>Full Name: {{ $auth.user.name }} </h3>
    <h3>nickname: {{ $auth.user.nickname }} </h3>
    <h3>Name: {{ $auth.user.given_name }} </h3>  
    <h3>Family Name: {{ $auth.user.family_name }} </h3>  
    <h3>Phone: {{ $auth.user.phone }} </h3>  
    <h3>Email: {{ $auth.user.email }} </h3>
    
      </div>
    </div>
  </section>



    <!--- foooter-->
   
    <section class="footer">   
      <h4 class="text-center1">
        Follow us
        <P></P>
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

<style scoped>
.profile-info{
min-height: 100vh;
width: 100%;
background-image: linear-gradient(rgba(4,9,30,0.7),rgba(4,9,30,0.7)),
url("pic0.png");
background-position: center;
background-size: cover;
display: flex;
align-items: center;
justify-content: center;
}

.box{
  background: #0a2953;
  text-align: center;
  background-position: center;
  background-size: cover;
  padding: 15px 40px;
  color: rgb(255, 255, 255);
  position: relative;
  font: 15px "Fira Sans", serif;
  font-weight: 250;
  border-radius: 30px;
}

.box2 {
  text-align: left;
  color: rgb(255, 255, 255);
  font: 15px "Fira Sans", serif;
  font-weight: 250;
  margin-top: 20px;
}

.box2 h3 {
  text-align: left;
  color: rgb(255, 255, 255);
  font: 20px "Fira Sans", serif;
  font-weight: 250;
  margin-top: 10px;
}

.user-picture{
  width: 150px;
  border-radius: 50%;
  background: #fff;
  padding: 5px;
}

p {
  color: #777;
  font: 15px "Fira Sans", serif;
  font-weight: 250;
  line-height: 25px;
  padding: 15px;
  text-align: center;
}



/* follow us*/
h4 {
  font:  15px "Fira Sans", serif;
  text-align: center;
  font-weight: 500;
}

/* footer */
@media (max-width: 700px) {

  .profile-info{
min-height: 100vh;
width: 100%;
background-position: center;
background-size: cover;
display: flex;
align-items: center;
justify-content: center;
}

.box{
  background: #0a2953;
  text-align: center;
  background-position: center;
  background-size: cover;
  padding:30px 50px;
  color: rgb(255, 255, 255);
  position: relative;
  font: 15px "Fira Sans", serif;
  font-weight: 250;
  border-radius: 30px;
}

.box2 {
  text-align: center;
  color: rgb(255, 255, 255);
  font: 15px "Fira Sans", serif;
  font-weight: 250;
  margin-top: 20px;
}

.box2 h3 {
  text-align: left;
  color: rgb(255, 255, 255);
  font: 15px "Fira Sans", serif;
  font-weight: 250;
  margin-top: 5px;
}
.user-picture{
  width: 100px;
  border-radius: 50%;
  background: #fff;
  padding: 5px;
}


  .footer {
  width: 100%;
  text-align: center;
  padding: 1px 0;
  background: #1a1010;
}
p {
  color: #777;
  font: 15px "Fira Sans", serif;
  font-weight: 250;
  line-height: 25px;
  padding: 15px;
  text-align: center;
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