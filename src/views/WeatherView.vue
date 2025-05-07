<template>
    <div class="weather-page">
      <Weather />
      <router-link to="/">
        <button class="back-button">⬅ Tillbaka till chatt</button>
      </router-link>
    </div>
  </template>
  
  <script setup>
  import Weather from '../components/Weather.vue'
  </script>
  
  <style scoped>
  .weather-page {
    display: flex;
    flex-direction: column;
    align-items: center;
    padding: 2rem;
  }
  
  .back-button {
    margin-top: 2rem;
    padding: 0.6rem 1.2rem;
    border-radius: 6px;
    background-color: #4a5568;
    color: white;
    font-weight: bold;
    border: none;
    cursor: pointer;
  }
  
  .back-button:hover {
    background-color: #2d3748;
  }
  </style>
  