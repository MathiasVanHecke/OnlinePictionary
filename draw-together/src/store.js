import Vue from 'vue'
import Vuex from 'vuex'

import * as signalR from '@aspnet/signalr'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    myName: "Nico",
    pickedWord: "eenhoorn",
    pickedColor: "black",
    pickedBrush: "2"
  },
  mutations: {
    setPickedColor(state, c){state.pickedColor = c},
    setPickedBrush(state, b){state.pickedBrush = b},
    setPickedWord(state, w){state.Word = w},
  },
  actions: {
    setColor: ({commit}, c) => {commit("setPickedColor", c)},
    setBrush: ({commit}, b) => {commit("setPickedBrush", b)},

    startConnection: () => {
      let connection = new signalR.HubConnectionBuilder({useDefaultpath : false})
        .withUrl("https://localhost:44321/chatHub")
        .build();

      console.log(connection);

      connection.start();
    }
  },
  getters: {
    getMyName: state => state.myName,
    getTheWord: state => state.pickedWord,
    getPickedColor: state => state.pickedColor,
    getPickedBrush: state => state.pickedBrush,
  }
})
