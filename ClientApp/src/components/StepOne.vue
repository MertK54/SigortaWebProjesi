<template>
  <div class="container mt-4">
      <div class="mb-3">
        <label for="aracMarka" class="form-label">Araç Marka:</label>
        <input
          type="text"
          id="aracMarka"
          v-model="formData.aracMarka"
          class="form-control"
          placeholder="Araç markasını girin"
        />
      </div>
      <div class="mb-3">
        <label for="model" class="form-label">Araç Model:</label>
        <input
          type="text"
          id="model"
          v-model="formData.model"
          class="form-control"
          placeholder="Araç modelini girin"
        />
      </div>
  </div>
</template>

<style scoped>
.container {
  max-width: 500px; 
}
</style>

<script>
export default {
  props: {
    modelValue: {
      type: Object, // modelValue'nun tipi
      required: true
    }
  },
  data() {
    return {
      formData: { ...this.modelValue } // props'dan gelen modelValue'yu veri olarak tanımlıyoruz
    };
  },
  watch: {
    modelValue: {
      handler(newVal) {
        this.formData = { ...newVal }; // modelValue değiştiğinde formData'yı güncelliyoruz
      },
      deep: true // derin izleme
    },
    formData: {
      handler(newVal) {
        this.$emit('update:modelValue', newVal); // formData değiştiğinde üst bileşene güncelleme gönderiyoruz
      },
      deep: true // formData'nın içindeki nesne değişikliklerini de izliyoruz
    }
  }
};

</script>
