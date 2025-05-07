<template>
    <div class="chat-wrapper">
      <header class="chat-header">
        <h2 >Välkommen till chatten</h2>
      </header>
  
      <main class="chat-main">
        <h2 class="chat-title">Chatt</h2>
  
        <div class="messages">
          <div v-for="(msg, index) in messages" :key="index" class="message-bubble">
            <strong>{{ msg.user }}:</strong> {{ msg.message }}
          </div>
        </div>
  
        <div class="input-area">
          <input v-model="user" placeholder="Namn" class="user-input" />
          <input v-model="message" placeholder="Skriv ett meddelande..." class="message-input" @keyup.enter="sendMessage" />
          <button class="send-button" @click="sendMessage">Skicka</button>
        </div>
  
        <router-link to="/weather">
          <button class="weather-button">Se väderprognos</button>
        </router-link>
      </main>
  
      <footer class="chat-footer">
        Naturliga Växter & Kreativa Trädgårdar
      </footer>
    </div>
  </template>
  
  <script>
  import { HubConnectionBuilder } from '@microsoft/signalr';
  
  export default {
    data() {
      return {
        connection: null,
        user: '',
        message: '',
        messages: [],
      };
    },
    methods: {
      startConnection() {
        this.connection = new HubConnectionBuilder()
          .withUrl('http://localhost:5000/chathub')
          .withAutomaticReconnect()
          .build();
  
        this.connection.start()
          .then(() => console.log('✅ SignalR connected'))
          .catch(err => console.error('❌ SignalR error:', err));
  
        this.connection.on('ReceiveMessage', (user, message) => {
          this.messages.push({ user, message });
        });
      },
      sendMessage() {
        if (this.user.trim() && this.message.trim()) {
          this.connection.invoke('SendMessage', this.user, this.message)
            .catch(err => console.error('❌ Send failed:', err));
          this.message = '';
        }
      },
    },
    mounted() {
      this.startConnection();
    },
  };
  </script>
  
  <style scoped>
  * {
    box-sizing: border-box;
  }
  
  html, body {
    margin: 0;
    height: 100%;
    overflow: hidden;
  }
  
  .chat-wrapper {
    background-color: #f5f7fa;
    height: 100vh;
    display: flex;
    flex-direction: column;
    font-family: "Segoe UI", Roboto, sans-serif;
    overflow: hidden;
  }
  
  .chat-header,
  .chat-footer {
    background-color: #2f855a;
    padding: 1rem;
    color: white;
    font-weight: bold;
    text-align: center;
    flex-shrink: 0;
  }
  
  .tab-button {
    background: white;
    color: #2f855a;
    padding: 0.4rem 1rem;
    border-radius: 6px;
    border: none;
    font-weight: bold;
    cursor: pointer;
    box-shadow: 0 2px 6px rgba(0, 0, 0, 0.2);
  }
  
  .chat-main {
    flex: 1;
    display: flex;
    flex-direction: column;
    align-items: center;
    padding: 2rem 4rem;
    background-color: #edf2f7;
    overflow: hidden;
  }
  
  .chat-title {
    font-size: 2rem;
    margin-bottom: 1rem;
    color: #2d3748;
  }
  
  .messages {
    background: white;
    width: 100%;
    max-width: 1000px;
    height: 400px;
    overflow-y: auto;
    border-radius: 10px;
    padding: 1rem;
    margin-bottom: 1.5rem;
    box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
  }
  
  .message-bubble {
    background: #f0fff4;
    border-left: 4px solid #38a169;
    color: #1a202c;
    padding: 0.6rem;
    margin-bottom: 0.5rem;
    border-radius: 6px;
  }
  
  .input-area {
    display: flex;
    gap: 0.75rem;
    width: 100%;
    max-width: 1000px;
    margin-bottom: 1rem;
  }
  
  .user-input,
  .message-input {
    flex: 1;
    padding: 0.8rem;
    border: 1px solid #cbd5e0;
    border-radius: 6px;
    font-size: 1rem;
  }
  
  .send-button {
    background-color: #38a169;
    color: white;
    padding: 0.8rem 1.2rem;
    border: none;
    border-radius: 9999px;
    font-weight: bold;
    cursor: pointer;
    transition: background 0.2s ease-in-out;
  }
  
  .send-button:hover {
    background-color: #2f855a;
  }
  
  .weather-button {
    background-color: #2b6cb0;
    color: white;
    padding: 0.6rem 1.2rem;
    border: none;
    border-radius: 6px;
    font-weight: bold;
    cursor: pointer;
    transition: background-color 0.2s ease-in-out;
  }
  
  .weather-button:hover {
    background-color: #2c5282;
  }
  </style>
  