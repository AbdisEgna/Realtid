<script setup>
import Chat from './components/Chat.vue'
import Weather from './components/Weather.vue'
</script>

<template>
  <div style="display: flex; justify-content: space-around; flex-wrap: wrap; gap: 2rem; padding: 2rem;">
    <Chat />
    <Weather />
  </div>
</template>



<style scoped>
.logo {
  height: 6em;
  padding: 1.5em;
  will-change: filter;
  transition: filter 300ms;
}
.logo:hover {
  filter: drop-shadow(0 0 2em #646cffaa);
}
.logo.vue:hover {
  filter: drop-shadow(0 0 2em #42b883aa);
}
</style>
