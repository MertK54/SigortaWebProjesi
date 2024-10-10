import { createRouter, createWebHistory } from 'vue-router'
import Home from '../views/Home.vue';
import Offer from '../views/Offer.vue';
import Contact from '../views/Contact.vue';

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
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL), // HTML5 History Mode kullanımı
  routes,
});
export default router;
