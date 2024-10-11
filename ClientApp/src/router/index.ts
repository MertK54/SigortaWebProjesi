import { createRouter, createWebHistory } from 'vue-router'
import Home from '../views/Home.vue';
import Offer from '../views/Offer.vue';
import Contact from '../views/Contact.vue';
import AboutUs from '../views/AboutUs.vue';

const routes = [
  {
    path: '/', // Ana sayfa
    name: 'Home',
    component: Home,
  },
  {
    path: '/offer', // Teklif sayfası
    name: 'Offer',
    component: Offer,
  },
  {
    path: '/contact', // İletişim sayfası
    name: 'Contact',
    component: Contact,
  },
  {
    path: '/about-us', // Hakkımızda sayfası
    name: 'AboutUs',
    component: AboutUs,
  }
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL), // HTML5 History Mode kullanımı
  routes,
});
export default router;
