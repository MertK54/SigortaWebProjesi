<template>
  <div class="container mt-4">
    <div class="mb-3">
      <label for="aracMarka" class="form-label">Araç Marka:</label>
      <select id="aracMarka" v-model="formData.aracMarka" class="form-control selectpicker">
        <option disabled value="">Araç markanızı seçiniz</option>
        <option v-for="marka in aracMarka" :key="marka" :value="marka">{{ marka }}</option>
      </select>
    </div>
    <div class="mb-3">
      <label for="aracModel" class="form-label">Araç Model:</label>
      <select id="aracModel" v-model="formData.model" class="form-control selectpicker">
        <option disabled value="">Araç modelinizi seçiniz</option>
        <option v-for="model in aracModel" :key="model" :value="model">{{ model }}</option>
      </select>
    </div>
  </div>
</template>

<style scoped>
.container {
  max-width: 500px; 
}
</style>

<script>
import axios from 'axios';

export default {
  props: {
    modelValue: {
      type: Object, 
      required: true
    }
  },
  data() {
    return {
      formData: { ...this.modelValue }, 
      aracMarka: [],
      aracModel: [],
      data: []
    };
  },
  watch: {
    modelValue: {
      handler(newVal) {
        if (JSON.stringify(this.formData) !== JSON.stringify(newVal)) {
          this.formData = { ...newVal }; 
        }
      },
      deep: true
    },
    formData: {
      handler(newVal) {
        this.$emit('update:modelValue', newVal);
        if (newVal.aracMarka) {
          this.aracModel = this.data
            .filter(item => item.aracMarka === newVal.aracMarka)
            .map(item => item.aracModel);
        } else {
          this.aracModel = [];
        }
      },
      deep: true 
    }
  },
  created() {
    this.getAracMarkaModel();
  },
  methods: {
    getAracMarkaModel() {
      axios.get('http://localhost:5190/api/sigorta/get-marka-model', {
        headers: {
          'Content-Type': 'application/json'
        }
      })
      .then(response => {
        this.data = response.data;
        this.aracMarka = [...new Set(this.data.map(item => item.aracMarka))];
        console.log(response.data)
      })
      .catch(error => {
        console.error('Hata oluştu:', error);
      });
    }
  }
};
</script>
