import Vue from 'vue'
import Vuex from 'vuex'

import * as signalR from '@aspnet/signalr'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    myName: "Nico",
    roundsAmount: '',
    roundsLength: '',
    pickedWord: "eenhoorn",
    pickedColor: "black",
    pickedBrush: "2"
  },
  mutations: {
    setRoundsAmount(state, r){state.roundsAmount = r},
    setRoundsLength(state, l){state.roundsLength = l},
    setPickedColor(state, c){state.pickedColor = c},
    setPickedBrush(state, b){state.pickedBrush = b},
    setPickedWord(state, w){state.Word = w},
  },
  actions: {
    setRoundsAmount: ({commit}, r) => {commit("setRoundsAmount", r)},
    setRoundsLength: ({commit}, l) => {commit("setRoundsLength", l)},
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
    getRoundsAmount: state => state.roundsAmount,
    getRoundsLength: state => state.roundsLength,
    getPickedColor: state => state.pickedColor,
    getPickedBrush: state => state.pickedBrush,
  }
})
