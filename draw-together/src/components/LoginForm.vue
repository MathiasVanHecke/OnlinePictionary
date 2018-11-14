<template>
  <div v-if="isLogin" class="c-login o-smallpage">
    <h1 class="o-smallpage-header">Log In</h1>
    <input type="text" class="c-login-input" placeholder="Username">
    <input type="password" class="c-login-input" placeholder="Password">
    <button class="c-login-button">Log In</button>
    <a class="c-login-link" v-on:click="switchLogin">Don't have an account yet?</a>
  </div>
  <div v-else class="c-login o-smallpage">
    <h1 class="o-smallpage-header">Register</h1>
    <input type="text" class="c-login-input" placeholder="Username">
    <input type="email" class="c-login-input" placeholder="Email">
    <input type="password" class="c-login-input" placeholder="Password">
    <input type="password" class="c-login-input" placeholder="Confirm password">
    <button class="c-login-button">Register</button>
    <a class="c-login-link" v-on:click="switchLogin">Already have an account?</a>
  </div>
</template>

<script>
export default {
  name: 'AppHeader',
  data() {
    return {
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
