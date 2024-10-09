<template>
  <div>
    <h1>{{ message }}</h1>
  </div>
</template>

<script>
import axios from 'axios';

export default {
  data() {
    return {
      message: ''
    };
  },
  created() {
    axios.get('http://localhost:5190/api/home') 
      .then(response => {
        this.message = response.data.message;
      })
      .catch(error => {
        console.error(error);
      });
  }
};
</script>

<style>
body{
  background-color: black;
}
</style>
