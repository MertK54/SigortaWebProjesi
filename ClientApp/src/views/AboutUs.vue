<template>
    <section class="bg-success py-5">
        <div class="container">
            <div class="row align-items-center py-5 px-5">
                <div class="col-md-6 text-white">
                    <h1 class="pb-3"><strong>Sakarya Sigorta: Güvenceniz İçin Yanınızdayız</strong></h1>
                    <p>
                        Hayat, beklenmedik sürprizlerle dolu olabilir. Sakarya Sigorta olarak, sizi ve sevdiklerinizi koruma altına alarak bu belirsizliklere karşı güçlü bir güvence sunuyoruz. Kapsamlı sigorta çözümlerimizle, hem bireysel hem de kurumsal ihtiyaçlarınıza uygun poliçeler geliştiriyoruz. Bizimle birlikte, geleceğinizi güvence altına alırken huzurlu bir yaşam sürmenin tadını çıkarın!
                    </p>
                </div>
                <div class="col-md-6 ">
                    <img class="img-fluid" src="../assets/img/house-insurance-set-items.png" alt="About Hero">
                </div>
            </div>
        </div>
    </section>

    <!-- baslangic product -->
    <section class="container py-5">
        <div class="row text-center pt-5">
            <div class="col-lg-6 m-auto">
                <h1 class="h1">Ürünlerimiz</h1>
                <p>
                    Her Adımda Güvende Olun, Sakarya Sigorta ile Hayatınıza Değer Katın
                </p>
            </div>
        </div>
        <!-- Product component'i-->
        <Products />
    </section>
    <!-- bitis product -->

    <!-- baslangic Partnerlerimiz -->
    <section class="m-5 mb-5" style="box-shadow: 5px 5px 5px rgba(68, 68, 68, 0.6);">
        <div class="container my-4">
            <div class="row text-center py-3">
                <div class="col-lg-6 m-auto">
                    <h2>10'dan fazla sigorta şirketinden teklif al!</h2>
                </div>
                <div class="col-lg-9 m-auto tempaltemo-carousel">
                    <div class="row d-flex flex-row">
                        <div class="col">
                            <div class="carousel slide carousel-multi-item pt-2 pt-md-0" id="templatemo-slide-brand" data-bs-ride="carousel">
                                <div class="carousel-inner product-links-wap" role="listbox">

                                    <div class="carousel-item active">
                                        <div class="row">
                                            <div class="col-3 p-md-5">
                                                <a href="#"><img class="img-fluid brand-img" src="https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/acibadem-sigorta.png" alt="Brand Logo"></a>
                                            </div>
                                            <div class="col-3 p-md-5">
                                                <a href="#"><img class="img-fluid brand-img" src="https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/ak-sigorta.png" alt="Brand Logo"></a>
                                            </div>
                                            <div class="col-3 p-md-5">
                                                <a href="#"><img class="img-fluid brand-img" src="https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/allianz.png" alt="Brand Logo"></a>
                                            </div>
                                            <div class="col-3 p-md-5">
                                                <a href="#"><img class="img-fluid brand-img" src="https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/anadolu-sigorta.png" alt="Brand Logo"></a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </section>
</template>

<script>
import Products from '../components/Products.vue';
export default {
  name: 'About-Us',
  components : {
    Products
  }
};
</script>

<style scoped>

</style>
