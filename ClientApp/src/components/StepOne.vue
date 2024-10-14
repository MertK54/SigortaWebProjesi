<template>
  <div>
    <label>Araç Marka:</label>
    <input type="text" v-model="formData.aracMarka" />
    <label>Araç Model:</label>
    <input type="text" v-model="formData.model" />
  </div>
</template>

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
