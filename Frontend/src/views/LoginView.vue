<template>
  <v-container>
    <v-row align="center" justify="center">
      <v-col cols="12" sm="10">
        <v-card class="elevation-6 mt-10" height="100%">
          <v-window v-model="step">
            <v-window-item :value="1">
              <v-row>
                <v-col cols="12" md="6">
                  <v-card-text class="mt-12">
                    <h4 class="text-center">Login in to Your Account</h4>
                    <h6 class="text-center grey--text">
                      Log in to your account so you can continue builiding
                      <br />and editing your onboarding flows
                    </h6>
                    <v-row align="center" justify="center">
                      <v-col cols="12" sm="8">
                        <v-text-field
                          label="Email"
                          outlined
                          dense
                          color="blue"
                          autocomplete="false"
                          class="mt-16"
                          v-model="Email"
                        />
                        <v-text-field
                          label="Password"
                          outlined
                          dense
                          color="blue"
                          autocomplete="false"
                          type="password"
                          v-model="Password"
                        />
                        <v-row>
                          <v-col cols="12" sm="7">
                            <v-checkbox
                              label="Remember Me"
                              class="mt-n1"
                              color="blue"
                            >
                            </v-checkbox>
                          </v-col>
                          <v-col cols="12" sm="5">
                            <span class="caption blue--text"
                              >Forgot password</span
                            >
                          </v-col>
                        </v-row>
                        <v-btn color="blue" dark block tile @click="loginUser"
                          >Log in</v-btn
                        >
                      </v-col>
                    </v-row>
                  </v-card-text>
                </v-col>
                <v-col cols="12" md="6" class="blue rounded-bl-xl">
                  <div style="text-align: center; padding: 180px 0">
                    <v-card-text class="white--text">
                      <h3 class="text-center">Don't Have an Account Yet?</h3>
                      <h6 class="text-center">
                        Let's get you all set up so you can start creating your
                        your first<br />
                        onboarding experience
                      </h6>
                    </v-card-text>
                    <div class="text-center">
                      <v-btn tile outlined dark @click="step++">SIGN UP</v-btn>
                    </div>
                  </div>
                </v-col>
              </v-row>
            </v-window-item>
            <v-window-item :value="2">
              <v-row>
                <v-col cols="12" md="6" class="blue rounded-br-xl">
                  <div style="text-align: center; padding: 180px 0">
                    <v-card-text class="white--text">
                      <h3 class="text-center">Already Signed up?</h3>
                      <h6 class="text-center">
                        Log in to your account so you can continue building
                        and<br />
                        editing your onboarding flows
                      </h6>
                    </v-card-text>
                    <div class="text-center">
                      <v-btn tile outlined dark @click="step--">Log in</v-btn>
                    </div>
                  </div>
                </v-col>

                <v-col cols="12" md="6">
                  <v-card-text class="mt-12">
                    <h4 class="text-center">Sign Up for an Account</h4>
                    <h6 class="text-center grey--text">
                      Let's get you all set up so you can start creatin your
                      <br />
                      first onboarding experiance
                    </h6>
                    <v-row align="center" justify="center">
                      <v-col cols="12" sm="8">
                        <v-row>
                          <v-col cols="12" sm="4">
                            <v-text-field
                              label="First Name"
                              outlined
                              dense
                              color="blue"
                              autocomplete="false"
                              class="mt-4"
                              v-model="FName"
                            />
                          </v-col>
                          <v-col cols="12" sm="4">
                            <v-text-field
                              label="Middle Initial"
                              outlined
                              dense
                              color="blue"
                              autocomplete="false"
                              class="mt-4"
                              v-model="MName"
                            />
                          </v-col>
                          <v-col cols="12" sm="4">
                            <v-text-field
                              label="Last Name"
                              outlined
                              dense
                              color="blue"
                              autocomplete="false"
                              class="mt-4"
                              v-model="LName"
                            />
                          </v-col>
                        </v-row>
                        <v-text-field
                          label="Phone Number"
                          outlined
                          dense
                          color="blue"
                          autocomplete="false"
                          v-model="ClientPhoneNumber"
                        />
                        <v-text-field
                          label="Email"
                          outlined
                          dense
                          color="blue"
                          autocomplete="false"
                          v-model="Email"
                        />
                        <v-text-field
                          label="Password"
                          outlined
                          dense
                          color="blue"
                          autocomplete="false"
                          type="password"
                          v-model="Password"
                        />
                        <v-text-field
                          label="Confirm Password"
                          outlined
                          dense
                          color="blue"
                          autocomplete="false"
                          type="password"
                          v-model="confirmedPassword"
                        />
                        <v-btn color="blue" dark block tile @click="createUser"
                          >Sign up</v-btn
                        >
                      </v-col>
                    </v-row>
                  </v-card-text>
                </v-col>
              </v-row>
            </v-window-item>
          </v-window>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import axios from "axios";

export default {
  data: () => ({
    step: 1,
    FName: "",
    MName: "",
    LName: "",
    ClientPhoneNumber: "",
    Email: "",
    Password: "",
    confirmedPassword: "",
    clients: [],
  }),
  props: {
    source: String,
  },
  methods: {
    resetInput() {
      this.FName = "";
      this.MName = "";
      this.LName = "";
      this.ClientPhoneNumber = "";
      this.Email = "";
      this.Password = "";
      this.confirmedPassword = "";
    },

    async createUser() {
      const response = await axios.post("client", {
        FName: this.FName,
        MName: this.MName,
        LName: this.LName,
        Email: this.Email,
        ClientPhoneNumber: this.ClientPhoneNumber,
        Password: this.Password,
      });
      console.log(response);
      console.log(response.data.StatusCode);
      if (response.data.StatusCode == 200) {
        this.resetInput();
        this.step--;
      }
    },
    //  async loginUser() {
    //   const response = await axios.get("client");

    // //   , {
    // //     params:{
    // //     Email: this.Email,
    // //     Password: this.Password,
    // //     ReturnURL: "http://localhost:8080/"
    // //   }
    // //  }
    //   console.log(response);
    //   console.log(response.data.StatusCode);
    // },
    loginUser() {
      axios.get("client").then((response) => {
        response.data.forEach((element) => {
          if(element.Email === this.Email)
          {
          this.clients.push({   
            Email: element.Email,
          });
          }
        });
      });
      console.log(this.clients)
    },
  },
};
</script>
<style scoped>
.v-application .rounded-bl-xl {
  border-bottom-left-radius: 300px !important;
}
.v-application .rounded-br-xl {
  border-bottom-right-radius: 300px !important;
}
h3 {
  font-size: 2.1em;
  padding-bottom: 5px;
}
h4 {
  font-size: 1.9em;
}
h6 {
  font-size: 1.2em;
}
</style>