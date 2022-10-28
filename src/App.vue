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

      <NavBar v-if="!mobileView"/>

      <v-menu transition="slide-y-transition" bottom>
        <template v-slot:activator="{ on, attrs }">
          <v-btn class="pa-8 profileBtn" icon v-bind="attrs" v-on="on">
            <v-icon>mdi-account-circle</v-icon>
          </v-btn>
        </template>
        <v-list>
          <v-list-item v-if="$auth.isAuthenticated"
            ><v-btn width="100%" to="/profile">Profile</v-btn></v-list-item >
          <v-list-item v-for="(item, i) in profileBtnLinks" :key="i">
            <v-btn width="100%" link :to="item.to">{{ item.title }}</v-btn>
          </v-list-item>

          <v-list-item v-if="$auth.isAuthenticated">
            <LogoutButton style="width: 100%" />
          </v-list-item>
          <v-list-item v-else>
            <login-button style="width: 100%" />
          </v-list-item>
        </v-list>
      </v-menu>
    </v-app-bar>
    <Loading v-if="$auth.isLoading" />
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

    mobileView: false,
    showNav: false,

    return: {
      mobileView: null,
      showNav: false
    },
    
    drawer: null,
    items: [
      { title: "Home", icon: "mdi-home", to: "/" },
      { title: "About", icon: "mdi-help-box", to: "/about" },
      { title: "Contact Us", icon: "mdi-phone", to: "/contact-us" },
      //{ icon: "mdi-account-circle", to: "/contact-us" },
    ],
    profileBtnLinks: [
      { title: "Login", to: "/login" },
      { title: "Registration", to: "/registration" },
      { title: "Test", icon: "mdi-paper", to: "/testingauth" },
    ],
   
  }
  
  
  ),
  
 
};
</script>
<style lang ="scss">
#topbar {
  min-height: 64px;
}
.dividerClass {
  border-color: white;
}
.col {
  padding: 2px;
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

