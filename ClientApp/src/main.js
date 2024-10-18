import './assets/main.css'

import { createApp } from 'vue'
import App from './App.vue'
import router from './router/index'
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap';
/* import the fontawesome core */
import { library } from "@fortawesome/fontawesome-svg-core";
import { faPhone,faEnvelope,faHouse,faBell } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from "@fortawesome/vue-fontawesome";
import vSelect from 'vue-select';
import 'vue-select/dist/vue-select.css';
library.add(faPhone,faEnvelope,faHouse,faBell)
const app = createApp(App)
app.component("font-awesome-icon", FontAwesomeIcon)
app.component('v-select', vSelect);
app.use(router)

app.mount('#app')
