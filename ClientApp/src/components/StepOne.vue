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
  max-width: 500px; /* Form genişliğini ayarlamak için */
}
</style>

<script>
import { defineComponent, watch } from 'vue';

export default defineComponent({
  props: {
    modelValue: Object // üst bileşenden alınacak veri
  },
  setup(props, { emit }) {
    const formData = props.modelValue; // üst bileşenden gelen modelValue'yu alıyoruz
    watch(formData, (newVal) => {//watch: formData değişkenini izler. Eğer bu değişkenin değeri değişirse, belirtilen callback fonksiyonu çalışır.
      emit('update:modelValue', newVal); // üst bileşene olay gönderiyoruz
    }, 
    { deep: true });//Eğer formData içinde bir nesne varsa, bu nesne içindeki özelliklerin de değişimini izler.
    return { formData };
  }
});
</script>
