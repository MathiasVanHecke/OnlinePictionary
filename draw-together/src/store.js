import Vue from 'vue'
import Vuex from 'vuex'

import * as signalR from '@aspnet/signalr'
import localStoragePlugin from './plugins/localStorage'

Vue.use(Vuex)

export default new Vuex.Store({
  plugins: [localStoragePlugin],
  state: {
    myName: "",
    myColor: "",
    isHost: false,
    isDrawing: false,
    roundsAmount: "",
    roundsLength: "",
    pickedWord: "",
    pickedColor: "black",
    pickedBrush: "2",
    roomkey: "",
    members: [],
    connection: null,
  },
  mutations: {
    setMyName(state, n){state.myName = n},
    setMyColor(state, c){state.myColor = c},
    setHost(state, h){state.isHost = h},
    setDrawing(state, d){state.isDrawing = d},
    setRoundsAmount(state, r){state.roundsAmount = r},
    setRoundsLength(state, l){state.roundsLength = l},
    setPickedColor(state, c){state.pickedColor = c},
    setPickedBrush(state, b){state.pickedBrush = b},
    setPickedWord(state, w){state.pickedWord = w},
    setRoomkey(state, k){state.roomkey = k},
    setMembers(state, m){state.members = m},
    addMember(state, m){state.members.push(m)},
    setConnection(state, c){state.connection = c},
  },
  actions: {
    setMyName: ({commit}, n) => {commit("setMyName", n)},
    setMyColor: ({commit}, c) => {commit("setMyColor", c)},
    setHost: ({commit}, h) => {commit("setHost", h)},
    setDrawing: ({commit}, d) => {commit("setDrawing", d)},
    setRoundsAmount: ({commit}, r) => {commit("setRoundsAmount", r)},
    setRoundsLength: ({commit}, l) => {commit("setRoundsLength", l)},
    setColor: ({commit}, c) => {commit("setPickedColor", c)},
    setBrush: ({commit}, b) => {commit("setPickedBrush", b)},
    setRoomkey: ({commit}, k) => {commit("setRoomkey", k)},
    setMembers: ({commit}, m) => {commit("setMembers", m)},
    addMember: ({commit}, m) => {commit("addMember", m)},
    setPickedWord: ({commit}, w) => {commit("setPickedWord", w)},

    //SingalR
    startConnection: ({commit}) => {
      let connection = new signalR.HubConnectionBuilder({useDefaultpath : false})
        .withUrl("https://drawitapi.azurewebsites.net/chatHub",  {
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

    // API
    setWord: ({commit}, c, lang) => {
      return new Promise((resolve) =>
        fetch('https://drawitapi.azurewebsites.net/api/words/random',{
          headers:{
            "Authorization" : "bearer " + c
          }
        })
        .then(function(response){
          if(!response.ok) return new Error(response);
          else return response.json();
        })
        .then(function(json){
          let param = '';
          if (lang=='be') param = 'wordNl';
          else param = 'wordEng'
          commit('setPickedWord', json[param]);
          resolve(json[param]);
        })
        .catch((error => { 
          console.log(error); commit('setPickedWord', 'eenhoorn') 
        }))
      )
    }
  },
  getters: {
    getMyName: state => state.myName,
    getMyColor: state => state.myColor,
    getHost: state => state.isHost,
    getDrawing: state => state.isDrawing,
    getRoundsAmount: state => state.roundsAmount,
    getRoundsLength: state => state.roundsLength,
    getPickedWord: state => state.pickedWord,
    getPickedColor: state => state.pickedColor,
    getPickedBrush: state => state.pickedBrush,
    getRoomkey: state => state.roomkey,
    getMembers: state => state.members,
    getConnection: state => state.connection,
  }
})
