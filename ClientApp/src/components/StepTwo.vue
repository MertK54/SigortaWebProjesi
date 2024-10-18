<template>
  <div class="container mt-4">
    <div class="mb-3">
      <label for="modelYil" class="form-label">Model Yılı:</label>
      <v-select
        v-model="formData.modelYil"
        :options="aracModelYil"
        placeholder="Araç Model Yılınızı Seçiniz"
        :reduce="yil => yil"
      ></v-select>
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
      data: [],
      aracModelYil: [],
      aracMarka: [],
      aracModel: [],
    };
  },
  watch: {
    modelValue: {
      handler(newVal) {
        if (JSON.stringify(this.formData) !== JSON.stringify(newVal)) {
          this.formData = { ...newVal }; 
          this.updateModelYil();
        }
      },
      deep: true
    },
    formData: {
      handler(newVal) {
        this.$emit('update:modelValue', newVal);
        this.updateModelYil();
      },
      deep: true 
    },
  },
  created() {
    this.getModelYil();
  },
  methods: {
    getModelYil() {
      axios.get('http://localhost:5190/api/sigorta/get-model-yil', {
        headers: {
          'Content-Type': 'application/json'
        }
      })
      .then(response => {
        this.data = response.data;
        this.aracMarka = [...new Set(this.data.map(item => item.aracMarka))];
        this.aracModel = [...new Set(this.data.map(item => item.aracModel))];
        this.updateModelYil();
      })
      .catch(error => {
        alert('Hata oluştu: ' + (error.response?.data || error.message));
        console.log('Hata oluştu: ' + (error.response?.data || error.message));
      });
    },
    updateModelYil() {
    if (this.formData.aracMarka && this.formData.model) {
      this.aracModelYil = this.data
        .filter(item => item.aracMarka === this.formData.aracMarka && item.aracModel === this.formData.model)
        .map(item => item.aracModelYil);
    } else {
      this.aracModelYil = [];
    }
  }
  }
};
</script>
