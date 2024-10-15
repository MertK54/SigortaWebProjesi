<template>
    <nav class="navbar navbar-expand-lg navbar-light shadow">
        <div class="container d-flex justify-content-center align-items-center">
            <a class="navbar-brand text-success h1 mx" href="/">
                Sakarya Sigorta
            </a>

            <button class="navbar-toggler border-0" type="button" data-bs-toggle="collapse" data-bs-target="#templatemo_main_nav" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="align-self-center collapse navbar-collapse flex-fill d-lg-flex justify-content-lg-between fullscreen-menu" id="templatemo_main_nav">
                <div class="flex-fill">
                    <ul class="nav navbar-nav d-flex justify-content-center mx-lg-auto">
                        <li class="nav-item pe-4">
                            <router-link class="nav-link" to="/">Ana Sayfa</router-link>
                        </li>
                        <li class="nav-item dropdown pe-4">
                            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                Ürünlerimiz
                            </a>
                            <ul class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
                                <li><router-link to="/kasko-sigortasi" class="dropdown-item">Kasko Sigortası</router-link></li>
                                <li><router-link to="/trafik-sigortasi" class="dropdown-item">Trafik Sigortası</router-link></li>
                                <li><router-link to="/dask" class="dropdown-item">Dask</router-link></li>
                                <li><router-link to="/konut-sigortasi" class="dropdown-item">Konut Sigortası</router-link></li>
                                <li><router-link to="/seyehat-saglik-sigortasi" class="dropdown-item">Seyehat Sağlık Sigortası</router-link></li>
                                <li><router-link to="/tamamlayici-saglik-sigortasi" class="dropdown-item">Tamamlayıcı Sağlık Sigortası</router-link></li>
                            </ul>
                        </li>
                        <li class="nav-item pe-4">
                            <router-link class="nav-link" to="/About-Us">Hakkımızda</router-link>
                        </li>
                        <li class="nav-item pe-4">
                            <router-link class="nav-link" to="/Contact">İletişim</router-link>
                        </li>
                    </ul>
                </div>
                <button class="btn-close position-absolute top-0 end-0 m-3 d-lg-none" data-bs-toggle="collapse" data-bs-target="#templatemo_main_nav" aria-label="Close"></button>
            </div>
        </div>
    </nav>
</template>

<script>
export default {
  name: 'Navbar',
};
</script>

<style scoped>
* {
  font-family: "Baloo Paaji 2", sans-serif !important;
  font-weight: 600;
  font-style: normal;
}

/* Hamburger menü açıkken tüm ekranı kaplaması için stil */
.navbar-collapse.show {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background-color: rgba(255, 255, 255, 0.95);
  z-index: 9999;
  display: flex;
  justify-content: center;
  align-items: center;
}

.navbar-collapse.show ul {
  flex-direction: column; /* Menü elemanlarını dikey hizalayın */
  text-align: center;
}

.navbar-collapse.show .nav-link {
  font-size: 1.5rem; /* Menü linklerinin boyutunu arttırın */
  padding: 1rem; /* Linklerin aralarındaki boşluğu arttırın */
}

.btn-close {
  background-color: transparent; /* Arka planı şeffaf yap */
  border: none; /* Kenarlığı kaldır */
}
</style>
