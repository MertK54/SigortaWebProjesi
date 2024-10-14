<!-- src/components/StepTwo.vue -->
<template>
    <div>
      <label>Yaşınız:</label>
      <input type="number" v-model="localData.age" />
    </div>
  </template>
  
  <script>
  export default {
    props: ['modelValue'],
    data() {
      return {
        localData: this.modelValue
      };
    },
    watch: {
      localData: {
        handler(newValue) {
          this.$emit('update:modelValue', newValue);
        },
        deep: true
      }
    }
  };
  </script>
  