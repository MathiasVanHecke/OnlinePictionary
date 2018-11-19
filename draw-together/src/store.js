import Vue from 'vue'
import Vuex from 'vuex'

import * as signalR from '@aspnet/signalr'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    myName: "Nico",
    roundsAmount: '',
    roundsLength: '',
    Word: "",
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

    //Login / Register
    registerUser: ({commit}, credentials) =>
    {
      var url = 'https://localhost:44321/api/auth/register';

      fetch(url, {
        method: 'POST',
        body: JSON.stringify(credentials),
        headers:{
          'Content-Type': 'application/json'
        }
      }).then(res => res.json())
      .then(response => console.log('Success:', console.log(response)))
      .catch(error => console.error('Error:', error));
    },


    //SingalR
    startConnection: () => {
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
          connection.invoke("SendMessage", "mathias", "vue project")
        })
        .catch((error => { console.log(error.statusText); }));

    },

    setWord:({commit})=>{
      fetch('https://localhost:44321/api/words/random')
        .then(function(response){
          if(!response.ok) return new Error(response);
          else return response.json();
        })
        .then(function(json){
          console.log(json['wordEng']);
          commit( 'setPickedWord', json['wordEng'])
        })
        .catch((error => { console.log(error.statusText); }));
    }
  },
  getters: {
    getMyName: state => state.myName,
    getRoundsAmount: state => state.roundsAmount,
    getRoundsLength: state => state.roundsLength,
    getTheWord: state => state.Word,
    getPickedColor: state => state.pickedColor,
    getPickedBrush: state => state.pickedBrush,
  }
})
