<template>
            <div class="row px-5">
                <div class="col-6 col-md-2 mt-3 p-5">
                    <a href="#"><img src="../assets/img/arabasigortasi.png" class="rounded-circle img-fluid w-75 mx-auto d-block card-img"></a>
                    <h5 class="text-center mt-1 mb-3">Kasko Sigortası</h5>
                    <p class="text-center"><a class="btn btn-success"><router-link to="/kasko-sigortasi" class="text-decoration-none text-white">Teklif Al</router-link></a></p>
                </div>
                <div class="col-6 col-md-2 mt-3 p-5">
                    <a href="#"><img src="../assets/img/konutsigortasi.png" class="rounded-circle img-fluid w-75 mx-auto d-block card-img"></a>
                    <h5 class="text-center mt-1 mb-3">Konut Sigortası</h5>
                    <p class="text-center"><a class="btn btn-success"><router-link to="/konut-sigortasi" class="text-decoration-none text-white">Teklif Al</router-link></a></p>
                </div>
                <div class="col-6 col-md-2 mt-3 p-5">
                    <a href="#"><img src="../assets/img/trafiksigortasi.png" class="rounded-circle img-fluid w-75 mx-auto d-block card-img"></a>
                    <h5 class="text-center mt-1 mb-3">Trafik Sigortası</h5>
                    <p class="text-center"><a class="btn btn-success"><router-link to="/trafik-sigortasi" class="text-decoration-none text-white">Teklif Al</router-link></a></p>
                </div>
                <div class="col-6 col-md-2 mt-3 p-5">
                    <a href="#"><img src="../assets/img/dask.png" class="rounded-circle img-fluid w-75 mx-auto d-block card-img"></a>
                    <h5 class="text-center mt-1 mb-3">Dask Sigortası</h5>
                    <p class="text-center"><a class="btn btn-success"><router-link to="/dask" class="text-decoration-none text-white">Teklif Al</router-link></a></p>
                </div>
                <div class="col-6 col-md-2 mt-3 p-5">
                    <a href="#"><img src="../assets/img/seyehatsagliksigortasi.png" class="rounded-circle img-fluid w-75 mx-auto d-block card-img"></a>
                    <h5 class="text-center mt-1 mb-3">Seyehat Sigortası</h5>
                    <p class="text-center"><a class="btn btn-success"><router-link to="/seyehat-saglik-sigortasi" class="text-decoration-none text-white">Teklif Al</router-link></a></p>
                </div>
                <div class="col-6 col-md-2 mt-3 p-5">
                    <a href="#"><img src="../assets/img/tamamlayicisagliksigortasi.png" class="rounded-circle img-fluid w-75 mx-auto d-block card-img"></a>
                    <h5 class="text-center mt-1 mb-3">Tamamlayıcı Sigortası</h5>
                    <p class="text-center"><a class="btn btn-success"><router-link to="/tamamlayici-saglik-sigortasi" class="text-decoration-none text-white">Teklif Al</router-link></a></p>
                </div>
        </div>

</template>
<script>
import { defineComponent } from 'vue';

export default defineComponent({
    setup() {
        name:'Products'
    },
})
</script>
<style scoped>

</style>
