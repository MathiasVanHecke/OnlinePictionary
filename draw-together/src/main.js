import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import i18n from './plugins/i18n'
import './registerServiceWorker'
import VueCookies from 'vue-cookies';

Vue.use(VueCookies);

Vue.config.productionTip = false;
//i18n.locale = "nl";

new Vue({
  i18n,
  router,
  store,
  render: h => h(App)
}).$mount('#app')
