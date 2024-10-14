<!-- src/components/StepOne.vue -->
<template>
    <div>
      <label>Adınız:</label>
      <input type="text" v-model="localData.name" />
    </div>
  </template>
  
  <script>
  import { defineComponent, watch, toRefs } from 'vue';
  
  export default defineComponent({
    props: ['modelValue'], //üst bileşenden alınacak veri.
    setup(props, { emit }) {//emit = bu bileşenin üst bileşene göndereceği veri.
      const localData = toRefs(props.modelValue); // modelValue olarak alınan her veriyi reaktif 
  
      watch(localData, (newVal) => {
        emit('update:modelValue', newVal);
      }, { deep: true });
  
      return { localData };
    }
  });
  </script>
  