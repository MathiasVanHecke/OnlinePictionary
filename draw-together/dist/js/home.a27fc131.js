(window["webpackJsonp"]=window["webpackJsonp"]||[]).push([["home"],{abd4:function(t,o,e){},bb51:function(t,o,e){"use strict";e.r(o);var s=function(){var t=this,o=t.$createElement,e=t._self._c||o;return e("div",{staticClass:"home o-smallpage"},[e("button",{staticClass:"o-fancybutton",on:{click:t.create}},[t._v(t._s(t.$t("start")))]),e("h3",[t._v(t._s(t.$t("or")))]),e("input",{directives:[{name:"model",rawName:"v-model",value:t.roomkey,expression:"roomkey"}],staticClass:"o-input",attrs:{type:"text",placeholder:"Room Key"},domProps:{value:t.roomkey},on:{input:function(o){o.target.composing||(t.roomkey=o.target.value)}}}),e("button",{staticClass:"o-fancybutton",on:{click:t.join}},[t._v(t._s(t.$t("join")))])])},i=[],n={name:"Home",data:function(){return{roomkey:"",isValid:!0}},methods:{create:function(){this.$store.dispatch("setHost",!0),this.$router.push({name:"waiting"})},join:function(){this.isValid&&(this.$store.dispatch("setRoomkey",this.roomkey),this.$router.push({path:"waiting"}))}},mounted:function(){this.$store.dispatch("setHost",!1),this.$store.dispatch("setRoomkey","")},beforeCreate:function(){this.$cookies.get("token")||this.$router.push({path:"/"})}},a=n,r=(e("bcb1"),e("2877")),c=Object(r["a"])(a,s,i,!1,null,"59fb4034",null);c.options.__file="Home.vue";o["default"]=c.exports},bcb1:function(t,o,e){"use strict";var s=e("abd4"),i=e.n(s);i.a}}]);
//# sourceMappingURL=home.a27fc131.js.map