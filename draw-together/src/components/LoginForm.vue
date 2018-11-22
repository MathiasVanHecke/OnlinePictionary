<template>
  <div v-if="isLogin" class="c-login o-smallpage">
    <h1 class="o-smallpage-header">Log In</h1>
    <input v-model="email" type="email" class="o-input" placeholder="Email">
    <input v-model="password" type="password" class="o-input" placeholder="Password">
    <button class="o-fancybutton" v-on:click="login">Log In</button>
    <a class="c-login-link" v-on:click="switchLogin">{{ $t('notyet') }}</a>
  </div>
  <div v-else class="c-login o-smallpage">
    <h1 class="o-smallpage-header">{{ $t('register') }}</h1>
    <input v-on:focusout="validate" ref="displayname" v-model="displayname" type="text" class="o-input" placeholder="Display Name">
    <input v-on:focusout="validate" ref="email" v-model="email" type="email" class="o-input" placeholder="Email">
    <input v-on:focusout="validate" ref="password" v-model="password" type="password" class="o-input" placeholder="Password">
    <input v-on:focusout="validate" ref="password2" v-model="password2" type="password" class="o-input" placeholder="Confirm password">
    <span class="c-login-tac" v-on:click="check"><FancyCheckbox/><p class="c-login-tac-text">{{ $t('terms') }}</p></span>
    <button class="o-fancybutton" v-on:click="register">{{ $t('register') }}</button>
    <a class="c-login-link" v-on:click="switchLogin">{{ $t('already') }}</a>
  </div>
</template>

<script>
import FancyCheckbox from '@/components/FancyCheckbox.vue'

export default {
  name: 'AppHeader',
  components : {
    FancyCheckbox,
  },
  data() {
    return {
      displayname : '',
      email : '',
      password: '',
      password2: '',
      isLogin : false,
      isValid : false,
      isChecked : false,
    }
  },
  methods : {
    switchLogin : function(){
      this.isLogin = !this.isLogin;
    },
    register: function(){
      if (this.isValid && this.isChecked) {
        var credentials = {'username': this.displayname, 'email': this.email, 'password' : this.password}
        var url = 'https://localhost:44321/api/auth/register';
        fetch(url, {
              method: 'POST',
              body: JSON.stringify(credentials),
              headers:{ 'Content-Type': 'application/json' }
              })
        .then(response => console.log('Success:', console.log(response)))
        .catch(error => console.error('Error:', console.log(error)));
        }
    },
    login: function(){
      if (this.isValid && this.isChecked) {
        var credentials = {'username': this.displayname, 'email': this.email, 'password' : this.password}
        var url = 'https://localhost:44321/api/auth/login';
        fetch(url, {
              method: 'POST',
              body: JSON.stringify(credentials),
              headers:{ 'Content-Type': 'application/json' }
              })
        .then(response => console.log('Success:', response))
        .catch(error => console.error('Error:', console.log(error)));
      }
      this.$router.push({ path: 'home' });
    },
    validate : function(){
      let check = 0;
      if (this.displayname.length < 8 || this.displayname.length > 20) this.$refs.displayname.classList.add('o-input--invalid');
      else { this.$refs.displayname.classList.remove('o-input--invalid'); check += 1; }
      if (this.email != '' && this.validateEmail(this.email)) {this.$refs.email.classList.remove('o-input--invalid'); check +=1;}
      else this.$refs.email.classList.add('o-input--invalid');
      if (this.password.length < 8 || this.password.length > 20) this.$refs.password.classList.add('o-input--invalid');
      else { this.$refs.password.classList.remove('o-input--invalid'); check += 1; }
      if (this.password === this.password2) { this.$refs.password2.classList.remove('o-input--invalid'); }
      else this.$refs.password2.classList.add('o-input--invalid');
      if (check == 4) this.isValid = true;
      else this.isValid = false;
    },
    check : function(e){
      if (e.target == document.querySelector('#cbx')) this.isChecked = !this.isChecked;
    },
    validateEmail : function(email) {
      var re = /\S+@\S+\.\S+/;
      return re.test(email);
    }
  }
}
</script>

<style scoped lang="scss">
@import './src/style/objects/objects.fancybutton';
@import './src/style/objects/objects.input';
@import './src/style/objects/objects.smallpage';
@import './src/style/components/components.login';
</style>
