<template>
  <div class="container mt-4">
    <div class="mb-3">
      <label for="aracPaketi" class="form-label">Araç Paketi:</label>
      <input type="text" v-model="formData.aracPaketi" class="form-control mb-4" />
      <label for="yakitTipi" class="form-label">Yakıt Tipi:</label>
      <input type="text" v-model="formData.yakitTipi" class="form-control" />
  </div>
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
