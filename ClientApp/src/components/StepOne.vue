<template>
  <div>
    <label>Adınız:</label>
    <input type="text" v-model="formData.name" />
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

    watch(formData, (newVal) => {
      emit('update:modelValue', newVal); // üst bileşene olay gönderiyoruz
    }, { deep: true });

    return { formData };
  }
});
</script>
