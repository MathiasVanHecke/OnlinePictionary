<template>
  <div class="o-container">
      <div class="c-login">
        <h1 class="c-login-header">LOGIN</h1>

        <input type="text" class="c-login-input" placeholder="Gebruikersnaam">
        <input type="text" class="c-login-input" placeholder="Wachtwoord">

        <button class="c-login-button">LOGIN</button>

      </div>
  </div>
</template>

<script>
export default {
  name: 'LoginForm'
}
</script>

<style scoped lang="scss">
@import './src/style/objects/objects.container';
@import './src/style/components/components.login';
</style>
