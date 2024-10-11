<template>
  <div id="app" class="d-flex flex-column min-vh-100 min-vw-100">
      <Navbar id="nav" class="" />
      <div class="w-100 m-0 p-0">
          <router-view class="w-100" /> <!-- Burada yönlendirme bileşeni gösterilecek -->
      </div>
      <Footer id="footer" class="" />
  </div>
</template>

<script>
import Navbar from './components/Navbar.vue';
import Footer from './components/Footer.vue';

export default {
name: 'App',
components: {
  Navbar,
  Footer,
}
};
</script>

<style>

body, html {
background-color: rgb(255, 255, 255) !important;
margin: 0; 
padding: 0;
box-sizing: border-box;

}

#app {
width: 100%;
height: 100%;
margin: 0; 
padding: 0;
}

*{
  font-family: "Baloo Paaji 2", sans-serif;
font-weight: 400;
font-style: normal;
}
</style>
