(window["webpackJsonp"]=window["webpackJsonp"]||[]).push([["waiting"],{"0139":function(t,e,n){},"0a49":function(t,e,n){var s=n("9b43"),o=n("626a"),r=n("4bf8"),i=n("9def"),a=n("cd1c");t.exports=function(t,e){var n=1==t,c=2==t,u=3==t,l=4==t,d=6==t,m=5==t||d,f=e||a;return function(e,a,h){for(var g,v,p=r(e),b=o(p),y=s(a,h,3),$=i(b.length),k=0,_=n?f(e,$):c?f(e,0):void 0;$>k;k++)if((m||k in b)&&(g=b[k],v=y(g,k,p),t))if(n)_[k]=v;else if(v)switch(t){case 3:return!0;case 5:return g;case 6:return k;case 2:_.push(g)}else if(l)return!1;return d?-1:u||l?l:_}}},1169:function(t,e,n){var s=n("2d95");t.exports=Array.isArray||function(t){return"Array"==s(t)}},"214f":function(t,e,n){"use strict";var s=n("32e9"),o=n("2aba"),r=n("79e5"),i=n("be13"),a=n("2b4c");t.exports=function(t,e,n){var c=a(t),u=n(i,c,""[t]),l=u[0],d=u[1];r(function(){var e={};return e[c]=function(){return 7},7!=""[t](e)})&&(o(String.prototype,t,l),s(RegExp.prototype,c,2==e?function(t,e){return d.call(t,this,e)}:function(t){return d.call(t,this)}))}},"268b":function(t,e,n){},"2c92":function(t,e,n){"use strict";n.r(e);var s=function(){var t=this,e=t.$createElement,n=t._self._c||e;return n("div",{staticClass:"c-waiting o-container"},[t.isHost?n("GameSettings",{attrs:{roomkey:t.roomkey}}):t._e(),n("Members")],1)},o=[],r=(n("6b54"),n("a481"),n("cadf"),n("551c"),n("097d"),function(){var t=this,e=t.$createElement,n=t._self._c||e;return n("div",{staticClass:"c-gamesettings o-smallpage"},[n("h1",{staticClass:"o-smallpage-header"},[t._v(t._s(t.$t("newgame")))]),n("input",{directives:[{name:"model",rawName:"v-model",value:t.rounds,expression:"rounds"}],ref:"rounds",staticClass:"o-input",attrs:{type:"number",placeholder:"Amount of rounds",min:"1",max:"10"},domProps:{value:t.rounds},on:{focusout:t.validateRounds,input:function(e){e.target.composing||(t.rounds=e.target.value)}}}),n("input",{directives:[{name:"model",rawName:"v-model",value:t.length,expression:"length"}],ref:"length",staticClass:"o-input",attrs:{type:"number",placeholder:"Length of one round",min:"40",max:"120",step:"10"},domProps:{value:t.length},on:{focusout:t.validateLength,input:function(e){e.target.composing||(t.length=e.target.value)}}}),n("h3",[t._v(t._s(t.$t("joincode")))]),n("div",{staticClass:"c-gamesettings-key"},[n("p",[t._v(t._s(t.roomkey))]),n("input",{attrs:{type:"hidden",id:"roomkey"},domProps:{value:t.roomkey}}),n("div",{ref:"clipboard",staticClass:"c-gamesettings-key-copy",on:{click:t.copyToClipboard}},[t._v("📋")])]),n("button",{staticClass:"o-fancybutton",on:{click:t.start}},[t._v("Start")])])}),i=[],a={name:"GameSettings",props:{roomkey:String},data:function(){return{isValid:!1,rounds:null,length:null}},methods:{validateRounds:function(){this.rounds<1&&(this.rounds=1),this.rounds>10&&(this.rounds=10),this.validate()},validateLength:function(){this.length<40&&(this.length=40),this.length>120&&(this.length=120),this.validate()},validate:function(){this.rounds>=1&&this.rounds<=10&&this.length>=40&&this.length<=120&&(this.isValid=!0),this.rounds<1||this.rounds>10?this.$refs.rounds.classList.add("o-input--invalid"):this.$refs.rounds.classList.remove("o-input--invalid"),this.length<40||this.length>120?this.$refs.length.classList.add("o-input--invalid"):this.$refs.length.classList.remove("o-input--invalid")},copyToClipboard:function(){var t=document.querySelector("#roomkey");t.setAttribute("type","text"),t.select();var e=document.execCommand("copy");e&&this.$refs.clipboard.classList.add("c-gamesettings-key-copy--done"),t.setAttribute("type","hidden"),window.getSelection().removeAllRanges()},start:function(){this.validate(),this.isValid&&(this.$store.dispatch("setRoundsAmount",this.rounds),this.$store.dispatch("setRoundsLength",this.length),this.$store.getters.getConnection.invoke("StartGame",this.$store.getters.getRoomkey))}}},c=a,u=(n("821d"),n("2877")),l=Object(u["a"])(c,r,i,!1,null,"f1dee3fe",null);l.options.__file="GameSettings.vue";var d=l.exports,m=n("c418"),f={name:"Waiting",computed:{roomkey:function(){return this.$store.getters.getRoomkey},isHost:function(){return this.$store.getters.getHost}},components:{GameSettings:d,Members:m["a"]},mounted:function(){var t=this;if(""==this.$store.getters.getRoomkey){var e=Math.random().toString(36).replace(/[^a-z]+/g,"").substr(0,16);this.$store.dispatch("setRoomkey",e)}var n="#"+Math.floor(16777215*Math.random()).toString(16);this.$store.dispatch("setMyColor",n);var s="{name : '"+this.$store.getters.getMyName+"', img : '"+n+"'}";this.$store.getters.getConnection.invoke("JoinRoom",this.$store.getters.getRoomkey,s),this.$store.getters.getConnection.on("StartGame",function(){t.$router.push({path:"game"})})},beforeCreate:function(){this.$cookies.get("token")||this.$router.push({path:"/"})}},h=f,g=(n("ea3b"),Object(u["a"])(h,s,o,!1,null,"755a6b36",null));g.options.__file="Waiting.vue";e["default"]=g.exports},"6d99":function(t,e,n){"use strict";var s=n("7e96"),o=n.n(s);o.a},7514:function(t,e,n){"use strict";var s=n("5ca1"),o=n("0a49")(5),r="find",i=!0;r in[]&&Array(1)[r](function(){i=!1}),s(s.P+s.F*i,"Array",{find:function(t){return o(this,t,arguments.length>1?arguments[1]:void 0)}}),n("9c6c")(r)},"7e96":function(t,e,n){},"7f7f":function(t,e,n){var s=n("86cc").f,o=Function.prototype,r=/^\s*function ([^ (]*)/,i="name";i in o||n("9e1e")&&s(o,i,{configurable:!0,get:function(){try{return(""+this).match(r)[1]}catch(t){return""}}})},"821d":function(t,e,n){"use strict";var s=n("e5f7"),o=n.n(s);o.a},"83c3":function(t,e,n){"use strict";var s=n("0139"),o=n.n(s);o.a},a481:function(t,e,n){n("214f")("replace",2,function(t,e,n){return[function(s,o){"use strict";var r=t(this),i=void 0==s?void 0:s[e];return void 0!==i?i.call(s,r,o):n.call(String(r),s,o)},n]})},c418:function(t,e,n){"use strict";var s=function(){var t=this,e=t.$createElement,n=t._self._c||e;return t.inGame?n("div",{staticClass:"c-memberbar o-grid"},t._l(t.members,function(e){return n("div",{key:e.id,staticClass:"c-member"},[n("Avatar",{attrs:{color:e.img}}),n("span",[n("p",{staticClass:"c-member-name"},[t._v(t._s(e.name))]),n("p",{staticClass:"c-member-score"},[t._v(t._s(e.score))])])],1)})):n("div",{staticClass:"o-smallpage"},[n("h3",[t._v(t._s(t.$t("ready")))]),t._l(t.members,function(e){return n("div",{key:e.id,staticClass:"c-waiting-member"},[n("Avatar",{attrs:{color:e.img}}),n("p",{staticClass:"c-member-name"},[t._v(t._s(e.name))])],1)})],2)},o=[],r=(n("7514"),n("7f7f"),n("cadf"),n("551c"),n("097d"),n("df3a")),i={name:"Members",props:{inGame:Boolean},components:{Avatar:r["a"]},computed:{members:function(){return this.$store.getters.getMembers}},mounted:function(){var t=this,e=this;this.$store.getters.getConnection.on("NewMember",function(e){t.$store.getters.getHost&&(t.$store.dispatch("addMember",e),t.$store.getters.getConnection.invoke("UpdateMembers",t.$store.getters.getRoomkey,t.members))}),this.$store.getters.getConnection.on("UpdateMembers",function(e){t.$store.dispatch("setMembers",e)}),this.$root.$on("NewDraft",function(){if(this.$store.getters.getHost){var t=e.members[Math.floor(Math.random()*e.members.length)];this.$store.dispatch("setWord",this.$cookies.get("token"),this.$cookies.get("locale")).then(function(n){e.$store.getters.getConnection.invoke("Drafted",e.$store.getters.getRoomkey,t.name,n)})}}),this.$store.getters.getConnection.on("Guessed",function(e,n){var s=t.members.find(function(t){return t.name==e});s.score+=n})},destroyed:function(){this.$store.getters.getConnection.off("NewMember"),this.$store.getters.getConnection.off("UpdateMembers"),this.$root.$off("NewDraft")}},a=i,c=(n("6d99"),n("2877")),u=Object(c["a"])(a,s,o,!1,null,"2bfbf6ec",null);u.options.__file="Members.vue";e["a"]=u.exports},cd1c:function(t,e,n){var s=n("e853");t.exports=function(t,e){return new(s(t))(e)}},df3a:function(t,e,n){"use strict";var s=function(){var t=this,e=t.$createElement,n=t._self._c||e;return t.canShrink?n("div",{staticClass:"c-chat-member"}):n("div",{staticClass:"c-member-avatar"})},o=[],r={name:"Avatar",props:{color:String,canShrink:Boolean},mounted:function(){this.$el.style.backgroundColor=this.color}},i=r,a=(n("83c3"),n("2877")),c=Object(a["a"])(i,s,o,!1,null,"114d75bc",null);c.options.__file="Avatar.vue";e["a"]=c.exports},e5f7:function(t,e,n){},e853:function(t,e,n){var s=n("d3f4"),o=n("1169"),r=n("2b4c")("species");t.exports=function(t){var e;return o(t)&&(e=t.constructor,"function"!=typeof e||e!==Array&&!o(e.prototype)||(e=void 0),s(e)&&(e=e[r],null===e&&(e=void 0))),void 0===e?Array:e}},ea3b:function(t,e,n){"use strict";var s=n("268b"),o=n.n(s);o.a}}]);
//# sourceMappingURL=waiting.940a4d15.js.map