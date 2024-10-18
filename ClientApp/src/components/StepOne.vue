<template>
  <div class="container mt-4">
    <div class="mb-3">
      <label for="aracMarka" class="form-label">Araç Marka:</label>
      <v-select
        v-model="formData.aracMarka"
        :options="aracMarka"
        placeholder="Araç Markanızı Seçiniz"
      ></v-select>
    </div>
    <div class="mb-3">
      <label for="aracModel" class="form-label">Araç Model:</label>
      <v-select
        v-model="formData.model"
        :options="aracModel"
        placeholder="Araç Modelinizi Seçiniz"
        :reduce="model => model"
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
import vSelect from 'vue-select';
export default {
  components:{
    vSelect,
  },
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
