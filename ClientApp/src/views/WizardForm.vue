<template>
  <div class="container my-5 p-5 card b-box-3" style="box-shadow: 5px 5px #4BB543;">
    <h2 class="p-2" style="background-color: white;border-bottom: 1px solid #d3d3d3;">Adım {{ currentStep + 1 }}</h2>
    <div class="d-flex justify-content-around mb-4">
      <div
        v-for="(step, index) in steps"
        :key="index"
        class="step-indicator"
        :class="{ active: index <= currentStep }">
        <span>{{ index + 1 }}</span>
      </div>
    </div>
    <component :is="steps[currentStep].component" v-model="formData" :data="data"/>

    <div class="card-body mt-5">
      <button @click="prevStep" :disabled="currentStep === 0" class="btn btn-secondary">Geri</button>
      <button @click="nextStep" v-if="currentStep < steps.length - 2" class="btn btn-success">İleri</button>
      <button @click="submitForm" v-if="currentStep === steps.length - 2" class="btn btn-success">Gönder</button>

    </div>
  </div>
</template>

<script>
import StepOne from '../components/StepOne.vue';
import StepTwo from '../components/StepTwo.vue';
import StepThree from '../components/StepThree.vue';
import StepLast from '../components/StepLast.vue';
import axios from 'axios';
export default {
  components: { StepOne, StepTwo, StepThree,StepLast },
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
        { component: StepThree },
        { component: StepLast }
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
    submitForm() {
      axios.post('http://localhost:5190/api/sigorta/post-data', this.formData, {
        headers: {
          'Content-Type': 'application/json'
        }
      })
      .then(response => {
        alert('Veri başarıyla gönderildi: ' + JSON.stringify(response.data));
        console.log('Veri başarıyla gönderildi: ' + JSON.stringify(response.data));
        this.data = response.data; // Sonuçları burada saklıyoruz
        if (this.data && this.data.results) {
          this.data.results.sort((a, b) => {
            return a.fiyat - b.fiyat; // Artan sıralama
          });
        }
        // Eğer mevcut adım, adım sayısından küçükse bir sonraki adıma geç
        if (this.currentStep < this.steps.length - 1) {
          this.currentStep++;
        }
      })
      .catch(error => {
        alert('Hata oluştu: ' + (error.response?.data || error.message));
        console.log('Hata oluştu: ' + (error.response?.data || error.message));
      }
  )}
  }
}
</script>

<style scoped>
button {
  margin-right: 10px;
}
.container {
  max-width: 500px; /* Form genişliğini ayarlamak için */
}
.step-indicator {
  width: 30px;
  height: 30px;
  border: 2px solid #4BB543;
  border-radius: 50%;
  display: flex;
  align-items: center;
  justify-content: center;
  font-weight: bold;
  color: #007bff;
}

.step-indicator.active {
  background-color: #4BB543;
  color: white;
}
</style>
