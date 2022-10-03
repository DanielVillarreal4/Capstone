import Vue from 'vue'
import App from './App.vue'
import router from './router'
import vuetify from './plugins/vuetify'
import './axios'

Vue.config.productionTip = false
// Vue.prototype.$API_URL = "http://localhost:21293/api/"
new Vue({
  router,
  vuetify,
  render: h => h(App)
}).$mount('#app')


