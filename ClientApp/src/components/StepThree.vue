<template>
  <div>
    <label>Araç Paketi:</label>
    <input type="email" v-model="formData.aracPaketi" />
    <label>Yakıt Tipi:</label>
    <input type="email" v-model="formData.yakitTipi" />
  </div>
</template>

<script>
import { defineComponent,watch } from 'vue';

export default defineComponent({
  props: {
    modelValue: Object // üst bileşenden alınacak veri
  },
  setup(props, { emit }) {
    const formData = props.modelValue;

    // formData'daki değişiklikleri izliyoruz
    watch(formData, (newVal) => {
      emit('update:modelValue', newVal); // üst bileşene güncelleme gönderiyoruz
    }, { deep: true });
    return { formData };
  }
});
</script>
