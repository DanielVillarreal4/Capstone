import Vue from 'vue'
import App from './App.vue'
import router from './router'
import vuetify from './plugins/vuetify'
import './axios'
import { domain, clientId, audience } from '../auth_config.json';
import { Auth0Plugin } from '@/auth/auth0-plugin';

// Authentication plugin
Vue.use(Auth0Plugin, {
  domain,
  clientId,
  audience,
  onRedirectCallback: appState => {
    router.push(
      appState && appState.targetUrl
        ? appState.targetUrl
        : window.location.pathname
    );
  }
});

Vue.config.productionTip = false
// Vue.prototype.$API_URL = "http://localhost:21293/api/"
new Vue({
  router,
  vuetify,
  render: h => h(App)
}).$mount('#app')


