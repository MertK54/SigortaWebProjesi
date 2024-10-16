<template>
  <div class="container mt-4">
    <div class="mb-3">
      <label for="model" class="form-label">Model Yılı:</label>
      <input type="number" v-model="formData.modelYil" class="form-control" />
    </div>
  </div>
</template>

<script>
import { defineComponent, watch } from 'vue';

export default {
  props: {
    modelValue: {
      type: Object, 
      required: true
    }
  },
  data() {
    return {
      formData: { ...this.modelValue } 
    };
  },
  watch: {
    modelValue: {
      handler(newVal) {
        this.formData = { ...newVal }; 
      },
      deep: true 
    },
    formData: {
      handler(newVal) {
        this.$emit('update:modelValue', newVal); 
      },
      deep: true 
    }
  }
};
</script>
