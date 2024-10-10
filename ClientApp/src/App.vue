<template>
  <div id="app" class="d-flex flex-column min-vh-100 min-vw-100">
      <Navbar id="nav" class="bg-secondary" />
      <div class="container w-100 d-flex m-0 p-0">
          <router-view class="w-100" /> <!-- Burada yönlendirme bileşeni gösterilecek -->
      </div>
      <Footer id="footer" class="bg-secondary" />
  </div>
</template>

<script>
import Navbar from './components/Navbar.vue';
import Footer from './components/Footer.vue';
export default {
name: 'App',
components: {
  Navbar,
  Footer
}
};
</script>

<style>
body, html {
background-color: black !important; /* Bootstrap ile arka plan rengi değiştirilir */
margin: 0; /* Varsayılan kenar boşluğunu kaldır */
padding: 0;
box-sizing: border-box;
}

#app {
width: 100%;
height: 100%;
display: flex;
flex-direction: column; 
margin: 0; 
padding: 0;
}
</style>
