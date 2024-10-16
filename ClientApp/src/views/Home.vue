<template>
    <div class="modal fade bg-white" id="templatemo_search" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-lg" role="document">
            <div class="w-100 pt-1 mb-5 text-right">
                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
            </div>
            <form action="" method="get" class="modal-content modal-body border-0 p-0">
                <div class="input-group mb-2">
                    <input type="text" class="form-control" id="inputModalSearch" name="q" placeholder="Search ...">
                    <button type="submit" class="input-group-text bg-success text-light">
                        <i class="fa fa-fw fa-search text-white"></i>
                    </button>
                </div>
            </form>
        </div>
    </div>



    <!-- Slider Kısmı-->
    <div id="template-mo-zay-hero-carousel" class="carousel slide" data-bs-ride="carousel">
        <ol class="carousel-indicators">
            <li data-bs-target="#template-mo-zay-hero-carousel" data-bs-slide-to="0" class="active"></li>
            <li data-bs-target="#template-mo-zay-hero-carousel" data-bs-slide-to="1"></li>
            <li data-bs-target="#template-mo-zay-hero-carousel" data-bs-slide-to="2"></li>
        </ol>
        <div class="carousel-inner">
            <div class="carousel-item active">
                <div class="container">
                    <div class="row p-5">
                        <div class="mx-auto col-md-8 col-lg-6 order-lg-last">
                            <img class="img-fluid" src="../assets/img/banner_img_01.png" alt="">
                        </div>
                        <div class="col-lg-6 mb-0 d-flex align-items-center">
                            <div class="text-align-left align-self-center">
                                <h1 class="h1 text-success"><b>Güvende</b> Olun, Geleceğinizi Korumaya Alın</h1>
                                <h3 class="h4">Tüm ihtiyaçlarınıza uygun sigorta paketleri</h3>
                                <p>
                                    Aracınızdan evinize, sağlığınızdan iş yerinize kadar her şeyi güvence altına alın. Size özel sigorta çözümlerimizle huzurlu bir yaşam sürün.
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="carousel-item">
                <div class="container">
                    <div class="row p-5">
                        <div class="mx-auto col-md-8 col-lg-6 order-lg-last">
                            <img class="img-fluid" src="../assets/img/banner_img_02.png" alt="">
                        </div>
                        <div class="col-lg-6 mb-0 d-flex align-items-center">
                            <div class="text-align-left">
                                <h1 class="h1 text-success"> Sevdiklerinizi Yarınlara Taşıyın</h1>
                                <h3 class="h2">Hayat sigortası ile aileniz her zaman güvende</h3>
                                <p>
                                    Beklenmedik durumlara karşı hazırlıklı olun. Hayat sigortası ile geleceğinizin kontrolü sizde olsun. Size ve sevdiklerinize özel planlarla rahat edin.
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="carousel-item">
                <div class="container">
                    <div class="row p-5">
                        <div class="mx-auto col-md-8 col-lg-6 order-lg-last">
                            <img class="img-fluid" src="../assets/img/banner_img_06.png" alt="">
                        </div>
                        <div class="col-lg-6 mb-0 d-flex align-items-center">
                            <div class="text-align-left">
                                <h1 class="h1 text-success">Aracınız için En Uygun Sigorta Fırsatları</h1>
                                <h3 class="h2">Kaza, hırsızlık ve daha fazlasına karşı tam koruma</h3>
                                <p>
                                    Aracınızı koruma altına alın. İhtiyacınıza özel kasko ve trafik sigortası seçenekleriyle yolda güvende kalın. Uygun fiyat ve kapsamlı teminatlar sizleri bekliyor.
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <a class="carousel-control-prev text-decoration-none w-auto ps-3" href="#template-mo-zay-hero-carousel" role="button" data-bs-slide="prev">
            <i class="fas fa-chevron-left"></i>
        </a>
        <a class="carousel-control-next text-decoration-none w-auto pe-3" href="#template-mo-zay-hero-carousel" role="button" data-bs-slide="next">
            <i class="fas fa-chevron-right"></i>
        </a>
    </div>
    <!-- Slider btiiş -->


    <!-- teklif al -->
    <section class="container-fluid" style="margin-top: 10rem;">
        <div class="row text-center pt-3">
            <div class="col-lg-6 m-auto">
                <h1 class="text-success"><strong>Teklif Al, Karşılaştır, Hemen Sigortala</strong></h1>
                <p class="text-justify" style=" text-align: justify;">
                    İhtiyacınıza en uygun sigorta seçeneklerini anında keşfedin. Kolay ve hızlı karşılaştırma ile en iyi fiyatları bulun, zaman kaybetmeden güvence altına alın. Güvendiğiniz sigortaya bir adım daha yaklaşın!
                </p>
            </div>
        </div>
    </section>
    <Products />
    <!--  bitiş teklif al -->

    <section class="why-sakarya-sigorta" style="margin-top: 7rem;margin-bottom: 7rem;padding-top: 7rem;padding-bottom: 7rem;">
        <h2 class="text-success"><strong>Neden Sakarya Sigorta'dan Almalıyım?</strong></h2>
        <div class="container">
            <div class="row" style="display: grid;grid-template-columns: repeat(2,1fr);gap: 2rem;">
                <div class="col benefit-item ">
                    <h3>Güvenilir Hizmet</h3>
                    <p>Sakarya Sigorta, yılların verdiği deneyimle güvenilir bir hizmet sunar.</p>
                </div>
                <div class="col benefit-item">
                    <h3>Hızlı Destek</h3>
                    <p>7/24 destek hattımız ile her an yanınızdayız. Sorunlarınızı en hızlı şekilde çözüyoruz.</p>
                </div>
                <div class="col benefit-item">
                    <h3>Kapsamlı Poliçeler</h3>
                    <p>Geniş kapsamlı poliçelerimiz ile ihtiyacınıza uygun sigorta çözümleri sunuyoruz.</p>
                </div>
                <div class="col benefit-item">
                    <h3>Avantajlı Fiyatlar</h3>
                    <p>Rekabetçi fiyatlarla bütçenizi zorlamadan en iyi sigorta hizmetini alın.</p>
                </div>
            </div>
        </div>
    </section>
<!--adım adım baslangic-->
<section class="row p-5">
  <div class="container">
    <div class="row ">
      <div class="p-3 col-lg-4">
        <h3><strong>Adım1 : Bilgilerinizi Girin</strong></h3>
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Qui, deleniti, ad repellendus quis iste nisi eius molestiae animi aspernatur.</p>
        <img src="../assets/img/form.png" alt="" class="img-fluid" style="width: 100%;">
      </div>
      <div class="p-3 col-lg-4">
        <h3><strong>Adım 2: Teklifleri Alın</strong></h3>
        <p>Possimus culpa corrupti exercitationem dolorem cumque quos? Sequi architecto dolor optio?</p>
        <img src="../assets/img/form.png" alt="" class="img-fluid" style="width: 100%;">
      </div>
      <div class="p-3 col-lg-4">
        <h3><strong>Adım 3: Başvurunuzu Tamamlayın</strong></h3>
        <p>Başvurunuzu başarıyla tamamladıktan sonra, sizinle en kısa sürede iletişime geçeceğiz.</p>
        <img src="../assets/img/form.png" alt="" class="img-fluid" style="width: 100%;">
      </div>
    </div>
  </div>
</section>

  </template>
  
  <script>
  import Products from '../components/Products.vue';
  export default {
    name: 'Home',
    components : {
        Products
    }
};

  </script>

  <style scoped>
.why-sakarya-sigorta {
  padding-top: 5rem;
  padding-bottom: 5rem;
  background-color: hsl(86, 33%, 96%);
  border-radius: 10px;
  text-align: center;
}

.why-sakarya-sigorta h2 {
  padding-bottom: 2rem;
  font-size: 2rem;
  margin-bottom: 1.5rem;
  color: hsl(0, 0%, 15%);
}

.benefit-item {
  background-color: hsl(0, 0%, 100%);
  padding: 1.5rem;
  border-radius: 8px;
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
  transition: transform 0.3s ease;
}

.benefit-item h3 {
  font-size: 1.25rem;
  margin-bottom: 1rem;
  color: hsl(210, 22%, 25%);
}

.benefit-item p {
  color: hsl(210, 16%, 45%);
}

.benefit-item:hover {
  transform: scale(1.05);
}
.card-img:hover {
    transform: scale(1.1); /* Büyütme oranı */
    transition: transform 0.3s ease; /* Geçiş efekti */
}

.btn-success:hover {
    background-color: #28a745; /* Yeşil arka plan rengi */
    color: white; /* Buton metin rengi */
    transition: background-color 0.3s ease; /* Geçiş efekti */
}
  </style>
  