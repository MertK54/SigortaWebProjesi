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
/* add icons to the library */
library.add(faPhone,faEnvelope,faHouse,faBell)
const app = createApp(App)
app.component("font-awesome-icon", FontAwesomeIcon)
app.use(router)

app.mount('#app')
