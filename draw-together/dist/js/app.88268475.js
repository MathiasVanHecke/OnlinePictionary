(function(e){function n(n){for(var o,r,s=n[0],c=n[1],u=n[2],l=0,d=[];l<s.length;l++)r=s[l],a[r]&&d.push(a[r][0]),a[r]=0;for(o in c)Object.prototype.hasOwnProperty.call(c,o)&&(e[o]=c[o]);g&&g(n);while(d.length)d.shift()();return i.push.apply(i,u||[]),t()}function t(){for(var e,n=0;n<i.length;n++){for(var t=i[n],o=!0,r=1;r<t.length;r++){var s=t[r];0!==a[s]&&(o=!1)}o&&(i.splice(n--,1),e=c(c.s=t[0]))}return e}var o={},r={app:0},a={app:0},i=[];function s(e){return c.p+"js/"+({game:"game",home:"home",landing:"landing",waiting:"waiting"}[e]||e)+"."+{game:"8a25ef42",home:"1ed67ae7",landing:"d17c1dae",waiting:"7be62ed2"}[e]+".js"}function c(n){if(o[n])return o[n].exports;var t=o[n]={i:n,l:!1,exports:{}};return e[n].call(t.exports,t,t.exports,c),t.l=!0,t.exports}c.e=function(e){var n=[],t={game:1,home:1,landing:1,waiting:1};r[e]?n.push(r[e]):0!==r[e]&&t[e]&&n.push(r[e]=new Promise(function(n,t){for(var o="css/"+({game:"game",home:"home",landing:"landing",waiting:"waiting"}[e]||e)+"."+{game:"4727d5ae",home:"9b76a8f6",landing:"2506c934",waiting:"d1bb9b99"}[e]+".css",r=c.p+o,a=document.getElementsByTagName("link"),i=0;i<a.length;i++){var s=a[i],u=s.getAttribute("data-href")||s.getAttribute("href");if("stylesheet"===s.rel&&(u===o||u===r))return n()}var l=document.getElementsByTagName("style");for(i=0;i<l.length;i++){s=l[i],u=s.getAttribute("data-href");if(u===o||u===r)return n()}var d=document.createElement("link");d.rel="stylesheet",d.type="text/css",d.onload=n,d.onerror=function(n){var o=n&&n.target&&n.target.src||r,a=new Error("Loading CSS chunk "+e+" failed.\n("+o+")");a.request=o,t(a)},d.href=r;var g=document.getElementsByTagName("head")[0];g.appendChild(d)}).then(function(){r[e]=0}));var o=a[e];if(0!==o)if(o)n.push(o[2]);else{var i=new Promise(function(n,t){o=a[e]=[n,t]});n.push(o[2]=i);var u,l=document.getElementsByTagName("head")[0],d=document.createElement("script");d.charset="utf-8",d.timeout=120,c.nc&&d.setAttribute("nonce",c.nc),d.src=s(e),u=function(n){d.onerror=d.onload=null,clearTimeout(g);var t=a[e];if(0!==t){if(t){var o=n&&("load"===n.type?"missing":n.type),r=n&&n.target&&n.target.src,i=new Error("Loading chunk "+e+" failed.\n("+o+": "+r+")");i.type=o,i.request=r,t[1](i)}a[e]=void 0}};var g=setTimeout(function(){u({type:"timeout",target:d})},12e4);d.onerror=d.onload=u,l.appendChild(d)}return Promise.all(n)},c.m=e,c.c=o,c.d=function(e,n,t){c.o(e,n)||Object.defineProperty(e,n,{enumerable:!0,get:t})},c.r=function(e){"undefined"!==typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(e,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(e,"__esModule",{value:!0})},c.t=function(e,n){if(1&n&&(e=c(e)),8&n)return e;if(4&n&&"object"===typeof e&&e&&e.__esModule)return e;var t=Object.create(null);if(c.r(t),Object.defineProperty(t,"default",{enumerable:!0,value:e}),2&n&&"string"!=typeof e)for(var o in e)c.d(t,o,function(n){return e[n]}.bind(null,o));return t},c.n=function(e){var n=e&&e.__esModule?function(){return e["default"]}:function(){return e};return c.d(n,"a",n),n},c.o=function(e,n){return Object.prototype.hasOwnProperty.call(e,n)},c.p="/",c.oe=function(e){throw console.error(e),e};var u=window["webpackJsonp"]=window["webpackJsonp"]||[],l=u.push.bind(u);u.push=n,u=u.slice();for(var d=0;d<u.length;d++)n(u[d]);var g=l;i.push([0,"chunk-vendors"]),t()})({0:function(e,n,t){e.exports=t("56d7")},2856:function(e,n,t){},"56d7":function(e,n,t){"use strict";t.r(n);t("cadf"),t("551c"),t("097d");var o=t("2b0e"),r=function(){var e=this,n=e.$createElement,t=e._self._c||n;return t("div",{attrs:{id:"app"}},[t("appheader"),t("router-view")],1)},a=[],i=t("a4ce"),s={components:{appheader:i["a"]},mounted:function(){this.$store.dispatch("startConnection")}},c=s,u=(t("5c0b"),t("2877")),l=Object(u["a"])(c,r,a,!1,null,null,null);l.options.__file="App.vue";var d=l.exports,g=t("8c4f");o["a"].use(g["a"]);var f=new g["a"]({routes:[{path:"/",name:"landing",component:function(){return t.e("landing").then(t.bind(null,"bede"))}},{path:"/home",name:"home",component:function(){return t.e("home").then(t.bind(null,"bb51"))}},{path:"/game",name:"game",props:!0,component:function(){return t.e("game").then(t.bind(null,"7d36"))}},{path:"/waiting",name:"waiting",props:!0,component:function(){return t.e("waiting").then(t.bind(null,"2c92"))}}]}),m=(t("6b54"),t("2f62")),p=t("1a9a"),h=function(e){e.subscribe(function(e,n){console.log(e),localStorage.setItem("state",JSON.stringify(n))})};o["a"].use(m["a"]);var v=new m["a"].Store({plugins:[h],state:{myName:"Nico",isHost:!1,roundsAmount:"",roundsLength:"",roomkey:"",pickedWord:"",pickedColor:"black",pickedBrush:"2",connection:null},mutations:{setHost:function(e,n){e.isHost=n},setRoundsAmount:function(e,n){e.roundsAmount=n},setRoundsLength:function(e,n){e.roundsLength=n},setRoomkey:function(e,n){e.roomkey=n},setPickedColor:function(e,n){e.pickedColor=n},setPickedBrush:function(e,n){e.pickedBrush=n},setPickedWord:function(e,n){e.pickedWord=n},setConnection:function(e,n){e.connection=n}},actions:{setHost:function(e,n){var t=e.commit;t("setHost",n)},setRoundsAmount:function(e,n){var t=e.commit;t("setRoundsAmount",n)},setRoundsLength:function(e,n){var t=e.commit;t("setRoundsLength",n)},setColor:function(e,n){var t=e.commit;t("setPickedColor",n)},setBrush:function(e,n){var t=e.commit;t("setPickedBrush",n)},setRoomkey:function(e,n){var t=e.commit;t("setRoomkey",n)},startConnection:function(e){var n=e.commit,t=new p["b"]({useDefaultpath:!1}).withUrl("https://localhost:44321/chatHub",{skipNegotiation:!0,transport:p["a"].WebSockets}).build();t.start().catch(function(e){return console.error(e.toString())}).then(function(){console.log("-- Connected to the hub --"),n("setConnection",t)}).catch(function(e){console.log(e.statusText)})},setWord:function(e,n){var t=e.commit;console.log("Cookie uit store:"+n),fetch("https://localhost:44321/api/words/random").then(function(e){return e.ok?e.json():new Error(e)}).then(function(e){console.log(e["wordEng"]),t("setPickedWord",e["wordEng"])}).catch(function(e){console.log(e.statusText),t("setPickedWord","eenhoorn")})}},getters:{getMyName:function(e){return e.myName},getHost:function(e){return e.isHost},getRoundsAmount:function(e){return e.roundsAmount},getRoundsLength:function(e){return e.roundsLength},getRoomkey:function(e){return e.roomkey},getPickedWord:function(e){return e.pickedWord},getPickedColor:function(e){return e.pickedColor},getPickedBrush:function(e){return e.pickedBrush},getConnection:function(e){return e.connection}}}),b=t("a925");o["a"].use(b["a"]);var k=new b["a"]({fallbackLocale:"en",messages:{en:{register:"Register",terms:"I agree with the terms and conditions.",already:"Already have an account?",notyet:"Don't have an account yet?",start:"Start a new game",or:"or",join:"Join a room",newgame:"New game",joincode:"People can join with this code:",ready:"Ready to play:",guessed:"guessed the word!"},be:{register:"Registreer",terms:"Ik ga akkoord met de algemene voorwaarden.",already:"Heb je al een account?",notyet:"Heb je nog geen account?",start:"Start een nieuw spel",or:"of",join:"Doe mee met een spel",newgame:"Nieuw spel",joincode:"Mensen kunnen meedoen met deze code:",ready:"Klaar om te spelen:",guessed:"raadde het woord!"}}}),w=t("9483");Object(w["a"])("".concat("/","serviceWorker.js"),{ready:function(){console.log("App is being served from cache by a service worker.\nFor more details, visit https://goo.gl/AFskqB")},cached:function(){console.log("Content has been cached for offline use.")},updated:function(){console.log("New content is available; please refresh.")},offline:function(){console.log("No internet connection found. App is running in offline mode.")},error:function(e){console.error("Error during service worker registration:",e)}});var y=t("2b27"),_=t.n(y);o["a"].use(_.a),o["a"].config.productionTip=!1,new o["a"]({i18n:k,router:f,store:v,render:function(e){return e(d)}}).$mount("#app")},"5c0b":function(e,n,t){"use strict";var o=t("2856"),r=t.n(o);r.a},"66d2":function(e,n,t){"use strict";var o=t("c5e1"),r=t.n(o);r.a},a4ce:function(e,n,t){"use strict";var o=function(){var e=this,n=e.$createElement,t=e._self._c||n;return t("div",{staticClass:"c-appheader"},[t("div",{staticClass:"o-container"},[t("span",[t("router-link",{attrs:{to:"/"}},[e._v("Landing")]),e._v(" |\n        "),t("router-link",{attrs:{to:"/home"}},[e._v("Home")]),e._v(" |\n        "),t("router-link",{attrs:{to:"/waiting"}},[e._v("Waiting")]),e._v(" |\n        "),t("router-link",{attrs:{to:"/game"}},[e._v("Game")])],1),t("span",{staticClass:"c-flag",on:{click:e.switchLanguage}},["be"==e.flag?t("img",{attrs:{src:"/img/flags/be.png"}}):e._e(),"en"==e.flag?t("img",{attrs:{src:"/img/flags/en.png"}}):e._e()])]),t("div",{staticClass:"c-bar c-bar-header"})])},r=[],a={name:"AppHeader",data:function(){return{flag:"be"}},methods:{switchLanguage:function(){"be"==this.flag?(this.flag="en",this.setLanguage("be")):(this.flag="be",this.setLanguage("en"))},setLanguage:function(e){this.$i18n.locale=e,this.$cookies.config("30d"),this.$cookies.set("locale",e)}}},i=a,s=(t("66d2"),t("2877")),c=Object(s["a"])(i,o,r,!1,null,"612e7571",null);c.options.__file="AppHeader.vue";n["a"]=c.exports},c5e1:function(e,n,t){}});
//# sourceMappingURL=app.88268475.js.map