<!-- src/components/StepThree.vue -->
<template>
    <div>
      <label>Email Adresiniz:</label>
      <input type="email" v-model="localData.email" />
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
  