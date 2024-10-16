<template>
    <div v-if="data && data.results && data.results.length > 0" class="offer-section">
      <h3 class="offer-title">Size Özel Tekliflerimiz</h3>
      <ul class="list-group">
        <li v-for="(item, index) in data.results" :key="index" class="list-group-item">
          <div class="offer-item">
            <h5>{{ item.sirketAdi }}</h5>
            <p><strong>Marka:</strong> {{ item.aracMarka }}</p>
            <p><strong>Paket:</strong> {{ item.aracPaketi }}</p>
            <p><strong>Yakıt Tipi:</strong> {{ item.yakitTipi }}</p>
            <p><strong>Model:</strong> {{ item.modelYil }}</p>
            <p><strong>Fiyat:</strong> {{ item.fiyat }}₺</p>
          </div>
        </li>
      </ul>
    </div>
  </template>
  
  <script>
  import { defineComponent } from 'vue';
  
  export default defineComponent({
    props: {
      data: Object // Üst bileşenden alınacak veri
    },
  });
  </script>
  
  <style scoped>
  .offer-section {
    margin: 20px 0;
    padding: 20px;
    background-color: #f9f9f9;
    border-radius: 8px;
    box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
  }
  
  .offer-title {
    text-align: center;
    color: #4BB543;
    margin-bottom: 20px;
  }
  
  .list-group-item {
    border: none; /* Sadece üst kısmı belirgin tutmak için */
    padding: 15px;
    transition: background-color 0.3s;
  }
  
  .list-group-item:hover {
    background-color: #e8f5e9; /* Hover efekti için */
    cursor: pointer;
  }
  
  .offer-item {
    display: flex;
    flex-direction: column;
    align-items: flex-start; /* Sol tarafa yaslama */
  }
  
  .offer-item h5 {
    margin: 0;
    color: #333;
  }
  
  .offer-item p {
    margin: 5px 0;
    color: #555;
  }
  </style>
  