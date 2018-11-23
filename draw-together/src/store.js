import Vue from 'vue'
import Vuex from 'vuex'

import * as signalR from '@aspnet/signalr'
import localStoragePlugin from './plugins/localStorage'

Vue.use(Vuex)

export default new Vuex.Store({
  plugins: [localStoragePlugin],
  state: {
    myName: "Nico",
    isHost: false,
    roundsAmount: "",
    roundsLength: "",
    roomkey: "",
    pickedWord: "",
    pickedColor: "black",
    pickedBrush: "2",
    connection: null,
  },
  mutations: {
    setHost(state, h){state.isHost = h},
    setRoundsAmount(state, r){state.roundsAmount = r},
    setRoundsLength(state, l){state.roundsLength = l},
    setRoomkey(state, k){state.roomkey = k},
    setPickedColor(state, c){state.pickedColor = c},
    setPickedBrush(state, b){state.pickedBrush = b},
    setPickedWord(state, w){state.pickedWord = w},
    setConnection(state, c){state.connection = c},
  },
  actions: {
    setHost: ({commit}, h) => {commit("setHost", h)},
    setRoundsAmount: ({commit}, r) => {commit("setRoundsAmount", r)},
    setRoundsLength: ({commit}, l) => {commit("setRoundsLength", l)},
    setColor: ({commit}, c) => {commit("setPickedColor", c)},
    setBrush: ({commit}, b) => {commit("setPickedBrush", b)},
    setRoomkey: ({commit}, k) => {commit("setRoomkey", k)},
    //SingalR
    startConnection: ({commit}) => {
      let connection = new signalR.HubConnectionBuilder({useDefaultpath : false})
        .withUrl("https://localhost:44321/chatHub",  {
          skipNegotiation: true,
          transport: signalR.HttpTransportType.WebSockets
        })
        .build();

        connection.start().catch(function (err) {
          return console.error(err.toString());
        })
        .then(function(){
          console.log("-- Connected to the hub --");
          commit('setConnection', connection);
        })
        .catch((error => { console.log(error); }));

    },

    setWord: ({commit}, c) => {
      fetch('https://localhost:44321/api/words/random',{
        headers:{
          "Authorization" : "bearer " + c
        }
      })
        .then(function(response){
          if(!response.ok) return new Error(response);
          else return response.json();
        })
        .then(function(json){
          console.log(json['wordEng']);
          commit('setPickedWord', json['wordEng'])
        })
        .catch((error => { console.log(error); commit('setPickedWord', 'eenhoorn') }));
    }
  },
  getters: {
    getMyName: state => state.myName,
    getHost: state => state.isHost,
    getRoundsAmount: state => state.roundsAmount,
    getRoundsLength: state => state.roundsLength,
    getRoomkey: state => state.roomkey,
    getPickedWord: state => state.pickedWord,
    getPickedColor: state => state.pickedColor,
    getPickedBrush: state => state.pickedBrush,
    getConnection: state => state.connection,
  }
})
