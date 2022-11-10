<template>
  <v-app id="inspire">
    <v-app-bar app color="primary" dark ma-0 ma-md-5 class="appBar">
      <v-app-bar-title class="appTitle">C & C Systems</v-app-bar-title>
      
      <v-spacer></v-spacer>
      <v-divider 
        vertical
        class="divider"
        style="border-color=white"
      ></v-divider>

      <NavBar/>
      <v-menu   transition="slide-y-transition" bottom>
        <template v-slot:activator="{ on, attrs }">
          <v-btn  class="pa-8 profileBtn" icon v-bind="attrs" v-on="on">
            <v-icon>mdi-account-circle</v-icon>
          </v-btn >

          <!-- Menu for mobile users -->
          <v-btn  class="menu" icon v-bind="attrs" v-on="on">
            <v-icon>mdi-25px mdi-format-align-justify</v-icon>
          </v-btn >
        </template>

        <div class="mobile">  
          <router-link to="/" class="menu-t"> Home
          <v-icon>mdi-home</v-icon>
          </router-link>
          
          <router-link to="/about" class="menu-t"> About
            <v-icon>mdi-help-box</v-icon>
          </router-link>

          <router-link to="/contact-us" class="menu-t"> Contact Us
            <v-icon>mdi-phone</v-icon>
          </router-link>
        </div>
          

        <div class="not-mobile"> 
             
             <v-list-item v-if="$auth.isAuthenticated">
                <router-link to="/profile" class="menu-t"> profile
                  <v-icon>mdi-account</v-icon>
                </router-link>
                </v-list-item>
    
    
              <v-list-item v-if="$auth.isAuthenticated" >
                <router-link to="/testingauth" class="menu-t"> Test
                  <v-icon>mdi-calendar-clock</v-icon>
                </router-link>
              </v-list-item>
    
            </div>
              <!-- Authentication -->

             
          <!--  second menu
        <v-btn class="primary" width="100%" link to="/">Home
        <v-icon>mdi-home</v-icon>
      </v-btn>

      <v-btn  class="primary" width="100%" link to="/about">About
        <v-icon>mdi-help-box</v-icon>
      </v-btn>

    <v-btn class="primary" width="100%" link to="/contact-us">Contact Us
      <v-icon>mdi-phone</v-icon>
    </v-btn>-->
    
  
        <v-list>
        
          <!--

          <v-list-item v-if="$auth.isAuthenticated">
            <v-btn class="primary" width="100%" to="/profile">Profile
              <v-icon>mdi-account</v-icon>
            </v-btn> 
            </v-list-item>

          <v-list-item v-if="$auth.isAuthenticated" >
            <v-btn class="primary" width="100%" link to="/testingauth">Test
              <v-icon>mdi-calendar-clock</v-icon>
            </v-btn>
          </v-list-item>

           


          <div class="not">
              <v-list-item v-if="$auth.isAuthenticated">
            <router-link to="/profile" class="menu-t"> profile
              <v-icon>mdi-account</v-icon>
            </router-link>
            </v-list-item>
            
          <v-list-item v-if="$auth.isAuthenticated" >
            <router-link to="/testingauth" class="menu-t"> Test
              <v-icon>mdi-calendar-clock</v-icon>
            </router-link>
          </v-list-item>

        </div>
          -->
         <div class="phone"> 
          <v-list-item v-if="$auth.isAuthenticated">
            <v-btn class="menu-t" width="100%" to="/profile">Profile
              <v-icon>mdi-account</v-icon>
            </v-btn> 
            </v-list-item>

          <v-list-item v-if="$auth.isAuthenticated" >
            <v-btn class="menu-t" width="100%" link to="/testingauth">Test
              <v-icon>mdi-calendar-clock</v-icon>
            </v-btn>
          </v-list-item>
        </div>


          <v-list-item v-if="$auth.isAuthenticated">
        <LogoutButton class="menu-t" style="width: 100%"/>
          </v-list-item>

          <v-list-item v-else>
           <login-button class="menu-t" style="width: 100%"/>
          </v-list-item>
        </v-list>
      </v-menu>
    </v-app-bar>
    
    <Loading class="menu-t" style="width: 100%"  v-if="$auth.isLoading" />
    <v-main>
      <router-view></router-view>
    </v-main>
    <footer/>
  </v-app>
</template>

<script>
import Loading from "@/components/Loading";
import LogoutButton from "./components/LogoutButton.vue";
import LoginButton from "./components/LoginButton.vue";
import NavBar from "@/components/NavBar";


export default {

  components: {
    Loading,
    LogoutButton,
    LoginButton,
    NavBar,
  },
  data: () => ({  

    items: [
      { title: "Home", icon: "mdi-home", to: "/" },
      { title: "About", icon: "mdi-help-box", to: "/about" },
      { title: "Contact Us", icon: "mdi-phone", to: "/contact-us" },
      //{ icon: "mdi-account-circle", to: "/contact-us" },
    ],
    profileBtnLinks: [
      // { title: "Login", to: "/login" },
      // { title: "Registration", to: "/registration" },
      { title: "Test", icon: "mdi-paper", to: "/testingauth" },
    ],
   
  }
  
  
  ),
  
 
};
</script>
<style scoped>

.pa-8{
    display: block; 
  }
  .mobile{
    display: none;
  }

  .not-mobile{
    display: none;
  }
  .menu{
    display: none;
  }

  .phone{
    display: block;
  }
@media(max-width: 700px){
  .mobile{
    position: relative;
    display: inline-block;
  }

  .phone{
    display: none;
  }
  .not-mobile{
  display: block;
	background: #3b56bf;
  font-weight: bold;
 
  }

  .pa-8{
    display: none; 
  }

.menu-t{
  display: block;
	background: #3b56bf;
  position: relative;
  color: red;
  font:  20px;
  font-weight: bold;
  text-align: center;
  padding: 16px;
  width: 100%;
  text-decoration: none;

  /*
  display: block;
	background: #3b56bf;
  position: relative;
  color: red;
  font:  20px;
  font-weight: bold;
  text-align: center;
  padding: 16px;
  width: 100%;
  text-decoration: none;
  
  */
}
  .menu{

    display: block;
		top: 0;
    position: right;
		text-align: right;
		z-index: 2;
		transition: 0.10s;
    /*
    display: block;
    position: right;
    font-size: 10px;
    text-align: right;*/

  }


}
#topbar {
  min-height: 64px;
}
.dividerClass {
  border-color: white;
}
.col {
  padding: 5px;
}

#inspire
  > div
  > header
  > div
  > div
  > div.col.col-3.align-self-end
  > tr
  > td:nth-child(4) {
  /* padding-left: 30px; */
  padding-right: 30px;
  margin-right: 30px;
}
 .profileBtn {
  margin-top: -0.6em;
} 

* {
  padding: 0;
  margin: 0;
  box-sizing: border-box;
  font-weight: 400;
}
.trClass {
  border-color: white;
  align-self: stretch;
  border: solid;
  border-width: 0 0 0 thin;
  /* display: inline-flex;
  height: inherit;
  min-height: 100%;
  max-height: 100%;
  max-width: 0px;
  width: 0px;
  vertical-align: text-bottom;
  margin: 0 -1px; */
}
.appBar {
  background-image: linear-gradient(rgba(4, 9, 30, 0.7), rgba(4, 9, 30, 0.7));
}
.divider {
  border-width: 0 2px 0 0;
}
.theme--dark.v-divider {
  border-color: white;
}
</style>
<style>
#inspire
  > div
  > header
  > div
  > div.appTitle.v-toolbar__title.v-app-bar-title
  > div.v-app-bar-title__content,
.v-app-bar-title__content,
.appTitle {
  font-size: 1.5em;
  text-overflow: unset;
  overflow: unset;
  word-wrap: unset;
  padding-bottom: 1em;
}
.v-toolbar__content {
  align-items: center;
}
</style>



