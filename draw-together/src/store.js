import Vue from 'vue'
import Vuex from 'vuex'

import * as signalR from '@aspnet/signalr'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    myName: "Nico",
    roundsAmount: "",
    roundsLength: "",
    pickedWord: "",
    pickedColor: "black",
    pickedBrush: "2"
  },
  mutations: {
    setRoundsAmount(state, r){state.roundsAmount = r},
    setRoundsLength(state, l){state.roundsLength = l},
    setPickedColor(state, c){state.pickedColor = c},
    setPickedBrush(state, b){state.pickedBrush = b},
    setPickedWord(state, w){state.pickedWord = w},
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
    },

    setWord: ({commit}) => {
      fetch('https://localhost:44321/api/words/random')
        .then(function(response){
          if(!response.ok) return new Error(response);
          else return response.json();
        })
        .then(function(json){
          console.log(json['wordEng']);
          commit('setPickedWord', json['wordEng'])
        })
        .catch((error => { console.log(error.statusText); commit('setPickedWord', 'eenhoorn') }));
    }
  },
  getters: {
    getMyName: state => state.myName,
    getRoundsAmount: state => state.roundsAmount,
    getRoundsLength: state => state.roundsLength,
    getPickedWord: state => state.pickedWord,
    getPickedColor: state => state.pickedColor,
    getPickedBrush: state => state.pickedBrush,
  }
})
