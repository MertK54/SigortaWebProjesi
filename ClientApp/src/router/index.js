import { createRouter, createWebHistory } from 'vue-router'
import Home from '../views/Home.vue';
import Offer from '../views/Offer.vue';
import Contact from '../views/Contact.vue';
import AboutUs from '../views/AboutUs.vue';
import KaskoSigortasi from '../views/KaskoSigortasi.vue';
import TrafikSigortasi from '../views/TrafikSigortasi.vue';
import Dask from '../views/Dask.vue';
import KonutSigortasi from '../views/KonutSigortasi.vue';
import SeyehatSaglikSigortasi from '../views/SeyehatSaglikSigortasi.vue';
import TamamlayiciSaglikSigortasi from '../views/TamamlayiciSaglikSigortasi.vue';
import WizardForm from '../views/WizardForm.vue';

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
    path: '/wizard-form', // Hakkımızda sayfası
    name: 'WizardForm',
    component: WizardForm,
  },
  {
    path: '/about-us', // Hakkımızda sayfası
    name: 'AboutUs',
    component: AboutUs,
  },
  {
    path: '/kasko-sigortasi', // Hakkımızda sayfası
    name: 'KaskoSigortasi',
    component: KaskoSigortasi,
  },
  {
    path: '/trafik-sigortasi', // Hakkımızda sayfası
    name: 'TrafikSigortasi',
    component: TrafikSigortasi,
  },
  {
    path: '/dask', // Hakkımızda sayfası
    name: 'Dask',
    component: Dask,
  },
  {
    path: '/konut-sigortasi', // Hakkımızda sayfası
    name: 'KonutSigortasi',
    component: KonutSigortasi,
  },
  {
    path: '/seyehat-saglik-sigortasi', // Hakkımızda sayfası
    name: 'SeyehatSaglikSigortasi',
    component: SeyehatSaglikSigortasi,
  },
  {
    path: '/tamamlayici-saglik-sigortasi', // Hakkımızda sayfası
    name: 'TamamlayiciSaglikSigortasi',
    component: TamamlayiciSaglikSigortasi,
  }
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL), // HTML5 History Mode kullanımı
  routes,
});
export default router;
