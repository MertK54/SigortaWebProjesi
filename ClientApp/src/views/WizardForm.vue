<template>
  <div class="container mt-4">
    <h2 class="mx-3">Adım {{ currentStep + 1 }}</h2>
    <component :is="steps[currentStep].component" v-model="formData" />

    <div class="wizard-controls mx-3 mt-5">
      <button @click="prevStep" :disabled="currentStep === 0" class="btn btn-secondary">Geri</button>
      <button @click="nextStep" v-if="currentStep < steps.length - 1"class="btn btn-success">İleri</button>
      <button @click="submitForm" v-if="currentStep === steps.length - 1">Gönder</button>
    </div>

    <!-- Sorgu sonuçlarını göstermek için eklenen bölüm -->
    <div v-if="data && data.results && data.results.length > 0">
      <h3>Sorgu Sonuçları:</h3>
      <ul>
        <li v-for="(item, index) in data.results" :key="index">
          {{ item.model }} - {{ item.modelYil }} - {{ item.aracMarka }} - {{ item.aracPaketi }} - {{ item.yakitTipi }} - {{ item.sirketAdi }} - {{ item.fiyat }}
        </li>
      </ul>
    </div>
  </div>
</template>

<script>
import StepOne from '../components/StepOne.vue';
import StepTwo from '../components/StepTwo.vue';
import StepThree from '../components/StepThree.vue';
import axios from 'axios';

export default {
  components: { StepOne, StepTwo, StepThree },
  data() {
    return {
      formData: {
        model: '',
        modelYil:'',
        aracMarka: '',
        aracPaketi: '',
        yakitTipi: '',
        sirketAdi:'',
        fiyat:''
      },
      data: null, // Veritabanından alınan sonuçlar
      steps: [
        { component: StepOne },
        { component: StepTwo },
        { component: StepThree }
      ],
      currentStep: 0
    };
  },
  methods: {
    nextStep() {
      if (this.currentStep < this.steps.length - 1) {
        this.currentStep++;
      }
    },
    prevStep() {
      if (this.currentStep > 0) {
        this.currentStep--;
      }
    },
    async submitForm() {
      try {
        const response = await axios.post('http://localhost:5190/api/sigorta/post-data', this.formData, {
          headers: {
            'Content-Type': 'application/json'
          }
        });
        alert('Veri başarıyla gönderildi: ' + JSON.stringify(response.data));
        console.log('Veri başarıyla gönderildi: ' + JSON.stringify(response.data));
        this.data = response.data; // Sonuçları burada saklıyoruz
      } 
      catch (error) {
        alert('Hata oluştu: ' + (error.response?.data || error.message));
        console.log('Hata oluştu: ' + (error.response?.data || error.message));
      }
    }
  }
};
</script>

<style scoped>
.wizard-controls {
  margin-top: 20px;
}
button {
  margin-right: 10px;
}
.container {
  max-width: 500px; /* Form genişliğini ayarlamak için */
}
</style>
