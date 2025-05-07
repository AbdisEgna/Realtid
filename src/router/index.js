import { createRouter, createWebHistory } from 'vue-router'
import Chat from '../components/Chat.vue'
import WeatherView from '../views/WeatherView.vue'


const routes = [
  { path: '/', name: 'Chat', component: Chat },
  { path: '/weather', name: 'Weather', component: WeatherView },
]

const router = createRouter({
  history: createWebHistory(),
  routes,
})

export default router
