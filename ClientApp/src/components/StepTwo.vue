<template>
  <div>
    <label>model yılı:</label>
    <input type="number" v-model="formData.modelYil" />
  </div>
</template>

<script>
import { defineComponent, watch } from 'vue';

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
