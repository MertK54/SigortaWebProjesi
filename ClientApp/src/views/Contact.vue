<template>
  <div class="container p-5 text-center shadow-lg bg-light my-5" style="max-width: 60%;">
    <h1 class="pb-2" style="font-size: 4rem;" ><strong>İletişim Bilgilerimiz</strong></h1>
    <p class="fs-5 text-start d-flex flex-column">
      <strong>Bize Ulaşın</strong>
      <span class="pb-2">Sorularınız, önerileriniz veya herhangi bir geri bildirim için bizimle iletişime geçmekten çekinmeyin! Müşteri memnuniyeti bizim önceliğimizdir ve size en iyi şekilde yardımcı olabilmek için buradayız.</span>
      <span><font-awesome-icon :icon="['fas', 'phone']" id="icon" />Telefon: +90 (264) 123 45 67</span>
      <span><font-awesome-icon :icon="['fas', 'envelope']" id="icon" />E-posta: info@sakaryasigorta.com</span>
      <span><font-awesome-icon :icon="['fas', 'house']" id="icon" />
      Adres:
      1234 Örnek Sokak,
      Sakarya, Türkiye</span>
      <span><font-awesome-icon :icon="['fas', 'bell']" id="icon" />Çalışma saatlerimiz:
      Pazartesi - Cuma: 09:00 - 18:00
      Cumartesi: 10:00 - 14:00</span>
    </p>
  </div>
</template>
  
  <script>
  export default {
    name: 'Contact',
  };
  </script>
  <style scoped>
  #icon{
    margin-right: 1rem;
  }
  </style>
  