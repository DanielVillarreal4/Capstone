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

    

    <div class="row align-items-center profile-header">
      <div class="col-md-2 mb-3">
        <img
          :src="$auth.user.picture"
          alt="User's profile picture"
          class="rounded-circle img-fluid profile-picture"
        />
      </div>


      <div class="col-md text-center text-md-left">
        <h2>{{ $auth.user.name }}</h2>
        <p class="lead text-muted">{{ $auth.user.email }}</p>
      </div>
    </div>

    <div class="row">
      <pre class="col-12 text-light bg-dark p-4">
{{
        JSON.stringify($auth.user, null, 2)
      }}</pre
      >
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

  </div>
</template>

<style scoped>



/* footer */
@media (max-width: 700px) {
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