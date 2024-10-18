<template>
  <div class="container mt-4">
    <div class="mb-3">
      <label for="aracPaketi" class="form-label">Araç Paketi:</label>
      <v-select
        v-model="formData.aracPaketi"
        :options="aracPaketi"
        placeholder="Araç Paketinizi Seçiniz"
        :reduce="arac => arac"
      ></v-select>
      <label for="yakitTipi" class="form-label">Yakıt Tipi:</label>
      <select id="yakitTipi" v-model="formData.yakitTipi" class="form-control selectpicker">
        <option disabled value="">Yakıt tipini seçiniz</option>
        <option v-for="yakit in yakitTipi" :key="yakit" :value="yakit">{{ yakit }}</option>
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
      data: [],
      aracModelYil: [],
      aracMarka: [],
      aracModel: [],
      aracPaketi: [],
      yakitTipi: []
    };
  },
  watch: {
    modelValue: {
      handler(newVal) {
        if (JSON.stringify(this.formData) !== JSON.stringify(newVal)) {
          this.formData = { ...newVal }; 
          this.updatePaketYakit();
        }
      },
      deep: true 
    },
    formData: {
      handler(newVal) {
        this.$emit('update:modelValue', newVal);
        this.updatePaketYakit(); 
      },
      deep: true 
    }
  },
  created() {
    this.getAracPaketiYakitTipi();
  },
  methods: {
    getAracPaketiYakitTipi() {
      axios.get('http://localhost:5190/api/sigorta/get-aracpaketi-yakittipi', {
        headers: {
          'Content-Type': 'application/json'
        }
      })
      .then(response => {
        this.data = response.data;
        this.aracMarka = [...new Set(this.data.map(item => item.aracMarka))];
        this.aracModel = [...new Set(this.data.map(item => item.aracModel))];
        this.aracModelYil = [...new Set(this.data.map(item => item.modelYil))];
        this.updatePaketYakit();
      })
      .catch(error => {
        alert('Hata oluştu: ' + (error.response?.data || error.message));
        console.log('Hata oluştu: ' + (error.response?.data || error.message));
      });
    },
    
    updatePaketYakit() {
      if (this.formData.aracMarka && this.formData.model && this.formData.modelYil) {
        this.aracPaketi = this.data
          .filter(item => item.aracMarka === this.formData.aracMarka && 
                         item.aracModel === this.formData.model && 
                         item.modelYil === this.formData.modelYil)
          .map(item => item.aracPaketi);

        this.yakitTipi = this.data
          .filter(item => item.aracMarka === this.formData.aracMarka && 
                         item.aracModel === this.formData.model && 
                         item.modelYil === this.formData.modelYil)
          .map(item => item.yakitTipi);
      } else {
        this.aracPaketi = [];
        this.yakitTipi = [];
      }
    }
  }
};
</script>
