import Vue from 'vue'
import App from './App.vue'
import router from './router'
import vuetify from './plugins/vuetify'
import { firestorePlugin } from 'vuefire'
import firebase from 'firebase/compat/app';
import 'firebase/compat/firestore';

Vue.use(firestorePlugin);

Vue.config.productionTip = false

var firebaseConfig = {
  apiKey: "Your API Key",
  authDomain: "Your Auth Domain",
  projectId: "Your Project ID",
  storageBucket: "Your Storage Bucket",
  messagingSenderId: "Your Messaging Sender ID",
  appId: "Your AppID",
  measurementId: "Your Measurement ID"
};

firebase.initializeApp(firebaseConfig);

new Vue({
  router,
  vuetify,
  render: h => h(App)
}).$mount('#app')
