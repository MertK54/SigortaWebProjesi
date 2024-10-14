<!-- src/components/WizardForm.vue -->
<template>
    <div>
      <h2>Adım {{ currentStep + 1 }}</h2>
      <component :is="steps[currentStep].component" v-model="formData" />
  
      <div class="wizard-controls">
        <button @click="prevStep" :disabled="currentStep === 0">Geri</button>
        <button @click="nextStep" v-if="currentStep < steps.length - 1">İleri</button>
        <button @click="submitForm" v-if="currentStep === steps.length - 1">Gönder</button>
      </div>
    </div>
  </template>
  
  <script>
  import { ref } from 'vue';
  import StepOne from '../components/StepOne.vue';
  import StepTwo from '../components/StepTwo.vue';
  import StepThree from '../components/StepThree.vue';
  
  export default {
    components: { StepOne, StepTwo, StepThree },
    setup() {
      // Form verilerini reactive olarak tanımlıyoruz
      const formData = ref({
        name: '',
        age: '',
        email: ''
      });
  
      // Adımların dizisi
      const steps = ref([
        { component: StepOne },
        { component: StepTwo },
        { component: StepThree }
      ]);
  
      // Hangi adımda olduğumuzu izlemek için bir currentStep ref'i
      const currentStep = ref(0);
  
      // İleri ve geri adım fonksiyonları
      const nextStep = () => {
        if (currentStep.value < steps.value.length - 1) {
          currentStep.value++;
        }
      };
  
      const prevStep = () => {
        if (currentStep.value > 0) {
          currentStep.value--;
        }
      };
  
      const submitForm = () => {
        console.log('Form Submitted:', formData.value);
        // Form gönderimi işlemi
      };
  
      return {
        formData,
        currentStep,
        steps,
        nextStep,
        prevStep,
        submitForm
      };
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
  </style>
  