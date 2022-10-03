<template>
  <v-app id="inspire">
    <v-app-bar app color="primary" dark>
      <v-row>
        <v-col class="pl-10" cols="2" align-self="center">
          <v-app-bar-title class="appTitle">C & C Systems</v-app-bar-title>
        </v-col>
       <v-spacer></v-spacer> <!--  <v-divider vertical></v-divider> -->
        <v-col
          offset=""
          cols="3"
          align-self="end"
          class="d-flex align-end flex-column"
        >
          <tr class="trClass"> 
            <td v-for="item in items" :key="item.title" link :to="item.to">
              <v-list dense nav flat color="primary">
                <v-list-item :key="item.title" link :to="item.to">
                  <v-list-item-icon>
                    <v-icon>{{ item.icon }}</v-icon>
                  </v-list-item-icon>

                  <v-list-item-content>
                    <v-list-item-title>{{ item.title }}</v-list-item-title>
                  </v-list-item-content>
                </v-list-item>
              </v-list>
            </td>
            <td>
              <v-btn icon class="pa-8 profileBtn" x-large link to="/profile">
                <v-icon>mdi-account-circle</v-icon>
              </v-btn>
            </td>
          </tr>
        </v-col>
      </v-row>
    </v-app-bar>

    <v-main>
      <router-view></router-view>
    </v-main>
  </v-app>
</template>

<script>
export default {
  data: () => ({
    drawer: null,
    items: [
      { title: "Home", icon: "mdi-home", to: "/" },
      { title: "About", icon: "mdi-help-box", to: "/about" },
      { title: "Contact Us", icon: "mdi-phone", to: "/contact-us" },
      // { icon: "mdi-account-circle", to: "/contact-us" },
    ],
  }),
};
</script>
<style scoped>
#topbar {
  min-height: 42px;
}
.dividerClass {
  border-color: white;
}
.col {
  padding: 2px;
}
.appTitle {
  font-size: 2em;
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
.trClass{
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
</style>