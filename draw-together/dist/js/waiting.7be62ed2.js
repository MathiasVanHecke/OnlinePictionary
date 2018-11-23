(window["webpackJsonp"]=window["webpackJsonp"]||[]).push([["waiting"],{"214f":function(t,e,n){"use strict";var s=n("32e9"),i=n("2aba"),o=n("79e5"),r=n("be13"),a=n("2b4c");t.exports=function(t,e,n){var u=a(t),c=n(r,u,""[t]),l=c[0],d=c[1];o(function(){var e={};return e[u]=function(){return 7},7!=""[t](e)})&&(i(String.prototype,t,l),s(RegExp.prototype,u,2==e?function(t,e){return d.call(t,this,e)}:function(t){return d.call(t,this)}))}},"2b31":function(t,e,n){t.exports=n.p+"img/p_gnome.fd281f5b.png"},"2c92":function(t,e,n){"use strict";n.r(e);var s=function(){var t=this,e=t.$createElement,n=t._self._c||e;return n("div",{staticClass:"c-waiting o-container"},[t.isHost?n("GameSettings",{attrs:{roomkey:t.roomkey}}):t._e(),n("WaitingMembers")],1)},i=[],o=(n("6b54"),n("a481"),n("a4ce")),r=function(){var t=this,e=t.$createElement,n=t._self._c||e;return n("div",{staticClass:"c-gamesettings o-smallpage"},[n("h1",{staticClass:"o-smallpage-header"},[t._v(t._s(t.$t("newgame")))]),n("input",{directives:[{name:"model",rawName:"v-model",value:t.rounds,expression:"rounds"}],ref:"rounds",staticClass:"o-input",attrs:{type:"number",placeholder:"Amount of rounds",min:"1",max:"10"},domProps:{value:t.rounds},on:{focusout:t.validateRounds,input:function(e){e.target.composing||(t.rounds=e.target.value)}}}),n("input",{directives:[{name:"model",rawName:"v-model",value:t.length,expression:"length"}],ref:"length",staticClass:"o-input",attrs:{type:"number",placeholder:"Length of one round",min:"40",max:"120",step:"10"},domProps:{value:t.length},on:{focusout:t.validateLength,input:function(e){e.target.composing||(t.length=e.target.value)}}}),n("h3",[t._v(t._s(t.$t("joincode")))]),n("div",{staticClass:"c-gamesettings-key"},[n("p",[t._v(t._s(t.roomkey))]),n("input",{attrs:{type:"hidden",id:"roomkey"},domProps:{value:t.roomkey}}),n("div",{ref:"clipboard",staticClass:"c-gamesettings-key-copy",on:{click:t.copyToClipboard}},[t._v("📋")])]),n("button",{staticClass:"o-fancybutton",on:{click:t.start}},[t._v("Start")])])},a=[],u={name:"GameSettings",props:{roomkey:String},data:function(){return{isValid:!1,rounds:null,length:null}},methods:{validateRounds:function(){this.rounds<1&&(this.rounds=1),this.rounds>10&&(this.rounds=10),this.validate()},validateLength:function(){this.length<40&&(this.length=40),this.length>120&&(this.length=120),this.validate()},validate:function(){this.rounds>=1&&this.rounds<=10&&this.length>=40&&this.length<=120&&(this.isValid=!0),this.rounds<1||this.rounds>10?this.$refs.rounds.classList.add("o-input--invalid"):this.$refs.rounds.classList.remove("o-input--invalid"),this.length<40||this.length>120?this.$refs.length.classList.add("o-input--invalid"):this.$refs.length.classList.remove("o-input--invalid")},copyToClipboard:function(){var t=document.querySelector("#roomkey");t.setAttribute("type","text"),t.select();var e=document.execCommand("copy");e&&this.$refs.clipboard.classList.add("c-gamesettings-key-copy--done"),t.setAttribute("type","hidden"),window.getSelection().removeAllRanges()},start:function(){this.validate(),this.isValid&&(this.$store.dispatch("setRoundsAmount",this.rounds),this.$store.dispatch("setRoundsLength",this.length),this.$store.getters.getConnection.invoke("StartGame"))}}},c=u,l=(n("a09f"),n("2877")),d=Object(l["a"])(c,r,a,!1,null,"317d5690",null);d.options.__file="GameSettings.vue";var m=d.exports,g=function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"o-smallpage"},[s("h3",[t._v(t._s(t.$t("ready")))]),t._l(t.members,function(e){return s("div",{key:e.id,staticClass:"c-waiting-member"},[s("img",{staticClass:"c-waiting-member__p",attrs:{src:n("2b31"),alt:""}}),s("p",{staticClass:"c-waiting-member__u"},[t._v(t._s(e.name))])])})],2)},h=[],p={name:"WaitingMembers",data:function(){return{members:[]}},mounted:function(){var t=this;this.$store.getters.getConnection.on("NewMember",function(e){t.members.push(e),t.$store.getters.getHost&&t.$store.getters.getConnection.invoke("UpdateMembers",t.$store.getters.getRoomKey,t.members),console.log(t.$store.getters.getRoomKey)}),this.$store.getters.getConnection.on("UpdateMembers",function(e){console.log(e),t.members=e})}},f=p,v=(n("6f81"),Object(l["a"])(f,g,h,!1,null,"84e0d02e",null));v.options.__file="WaitingMembers.vue";var b=v.exports,y={name:"Waiting",computed:{roomkey:function(){return this.$store.getters.getRoomkey},isHost:function(){return this.$store.getters.getHost}},components:{AppHeader:o["a"],GameSettings:m,WaitingMembers:b},mounted:function(){var t=this;if(""==this.$store.getters.getRoomkey){var e=Math.random().toString(36).replace(/[^a-z]+/g,"").substr(0,16);this.$store.dispatch("setRoomkey",e)}var n="{name : '"+this.$store.getters.getMyName+"'}";this.$store.getters.getConnection.invoke("JoinRoom",this.roomkey,n),this.$store.getters.getConnection.on("StartGame",function(){t.$router.push({path:"game"})})}},_=y,$=(n("b21f"),Object(l["a"])(_,s,i,!1,null,"6684778f",null));$.options.__file="Waiting.vue";e["default"]=$.exports},"6f81":function(t,e,n){"use strict";var s=n("e1e3"),i=n.n(s);i.a},a09f:function(t,e,n){"use strict";var s=n("adb7"),i=n.n(s);i.a},a481:function(t,e,n){n("214f")("replace",2,function(t,e,n){return[function(s,i){"use strict";var o=t(this),r=void 0==s?void 0:s[e];return void 0!==r?r.call(s,o,i):n.call(String(o),s,i)},n]})},adb7:function(t,e,n){},b21f:function(t,e,n){"use strict";var s=n("f2c6"),i=n.n(s);i.a},e1e3:function(t,e,n){},f2c6:function(t,e,n){}}]);
//# sourceMappingURL=waiting.7be62ed2.js.map