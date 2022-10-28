<template>
  <div class="listGroup">
    <v-list-item class="list" >
      <v-list-item-icon>
        <v-icon>mdi-home</v-icon>
      </v-list-item-icon>
      <router-link to="/" class="nav-link"> Home</router-link>
    </v-list-item>
    <v-list-item class="list">
      <v-list-item-icon>
        <v-icon>mdi-help-box</v-icon>
      </v-list-item-icon>
      <router-link to="/about" class="nav-link"> About us</router-link>
    </v-list-item>
    <v-list-item class="list">
      <v-list-item-icon>
        <v-icon>mdi-phone</v-icon>
      </v-list-item-icon>
      <router-link to="/contact-us" class="nav-link"> Contact us</router-link>
    </v-list-item>
  </div>
</template>

<script>
export default {
  name: "MainNav",
};
</script>

<style scoped>
nav{
  padding: 0% 0% !important;
}
ul, .listGroup {
  list-style-type: none !important; 
  margin: 0 !important;
  padding-top: 1em !important;
  overflow: hidden !important;
}

li, .list {
  float: left;
  align-content: flex-end;
}

.nav-link {
  display: block;
  color: white;
  text-align: center;
  padding: 16px;
  text-decoration: none;
}

.v-application--is-ltr .v-list-item__icon:first-child{
  margin-right: -12px;
}
</style>

