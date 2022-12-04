<template>
  <v-btn class="Click mr-4" @click="signout"> Signout </v-btn>
</template>

<script>
import firebase from "firebase/compat/app";
import "firebase/compat/auth";
import "firebase/compat/firestore";
export default {
  name: "SignOutButton",
  methods: {
    signout() {
      firebase
        .auth()
        .signOut()
        /* eslint-disable no-unused-vars */
        .then((user) => {
          this.$router.push("/login");
        });
    },
  },
};
</script>
<style scoped>
.Click {
  display: inline-block;
  text-decoration-line: none;
  color: red;
  border: 2px solid #ffffff;
  padding: 15px 30px;
  font-size: 15px;
  background: repeat;
  position: relative;
  cursor: pointer;
  text-transform: unset;
  font-weight: unset;
}

.Click:hover {
  border: 2px solid #4524bc;
  background: #4524bc;
  transition: 0.1s;
}
.space {
  float: right;
}
@media (max-width: 700px) {
  .removePCSS {
    padding: 0px 0px 10px 0px;
    margin: 0px;
    color: white;
    text-align: start;
  }
  .row {
    margin-right: 10%;
    margin-left: 10%;
    flex-direction: column;
  }
  .Click {
    display: inline-block;
    text-decoration-line: none;
    color: red;
    border: 2px solid #ffffff;
    padding: 15px 30px;
    font-size: 15px;
    background: repeat;
    position: relative;
    cursor: pointer;
    text-transform: unset;
    font-weight: unset;
    margin-bottom: 2%;
  }

  .Click:hover {
    border: 2px solid #4524bc;
    background: #4524bc;
    transition: 0.1s;
  }
  .space {
    float: right;
  }
}
</style>