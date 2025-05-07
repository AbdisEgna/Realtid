<template>
    <div class="weather-box">
      <h2>Väder i Jönköping</h2>
  
      <div v-if="weather" class="weather-content">
        <img :src="iconUrl" :alt="weather.weather[0].description" />
        <div class="weather-info">
          <p class="temp">{{ Math.round(weather.main.temp) }}°C</p>
          <p class="desc">{{ weather.weather[0].description }}</p>
        </div>
      </div>
  
      <div v-else>
        <p>Laddar väderdata...</p>
      </div>
    </div>
  </template>
  
  <script>
  export default {
    data() {
      return {
        weather: null,
        apiKey: "17c52e5976c7f5770888b33827ef027f",
      };
    },
    computed: {
      iconUrl() {
        if (!this.weather) return "";
        return `https://openweathermap.org/img/wn/${this.weather.weather[0].icon}@4x.png`;
      },
    },
    mounted() {
      this.fetchWeather();
    },
    methods: {
      fetchWeather() {
        const url = `https://api.openweathermap.org/data/2.5/weather?q=Jönköping,se&units=metric&lang=sv&appid=${this.apiKey}`;
        fetch(url)
          .then((res) => res.json())
          .then((data) => {
            this.weather = data;
          })
          .catch((err) => {
            console.error("Fel vid hämtning av väderdata:", err);
          });
      },
    },
  };
  </script>
  
  <style scoped>
  .weather-box {
    background: #ffffff;
    border-radius: 12px;
    padding: 2rem;
    max-width: 500px;
    width: 90%;
    margin: auto;
    box-shadow: 0 4px 20px rgba(0, 0, 0, 0.1);
    text-align: center;
  }
  
  .weather-content {
    display: flex;
    flex-direction: column;
    align-items: center;
  }
  
  .weather-info {
    margin-top: 1rem;
  }
  
  .temp {
    font-size: 2.5rem;
    font-weight: bold;
    margin: 0;
    color: #2d3748;
  }
  
  .desc {
    font-size: 1.2rem;
    color: #4a5568;
    text-transform: capitalize;
    margin-top: 0.5rem;
  }
  </style>
  