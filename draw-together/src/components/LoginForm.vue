<template>
  <div v-if="isLogin" class="c-login o-smallpage">
    <h1 class="o-smallpage-header">Log In</h1>
    <input v-model="username" type="text" class="c-login-input" placeholder="Username">
    <input v-model="password" type="password" class="c-login-input" placeholder="Password">
    <button class="c-login-button">Log In</button>
    <a class="c-login-link" v-on:click="switchLogin">Don't have an account yet?</a>
  </div>
  <div v-else class="c-login o-smallpage">
    <h1 class="o-smallpage-header">Register</h1>
    <input v-model="username" type="text" class="c-login-input" placeholder="Username">
    <input v-model="email" type="email" class="c-login-input" placeholder="Email">
    <input v-model="password" type="password" class="c-login-input" placeholder="Password">
    <input v-model="password2" type="password" class="c-login-input" placeholder="Confirm password">
    <span class="c-login-tac"><FancyCheckbox/><p class="c-login-tac-text">I agree with the terms and conditions.</p></span>
    <button class="c-login-button">Register</button>
    <a class="c-login-link" v-on:click="switchLogin">Already have an account?</a>
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
      username : '',
      email : '',
      password: '',
      password2: '',
      isLogin : false,
    }
  },
  methods : {
    switchLogin : function () {
      this.isLogin = !this.isLogin;
    }
  }
}
</script>

<style scoped lang="scss">
@import './src/style/objects/objects.smallpage';
@import './src/style/components/components.login';
</style>
