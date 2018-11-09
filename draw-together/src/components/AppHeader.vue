<template>
  <div class="c-appheader">
      <div class="o-container">
        <router-link to="/">Home</router-link> |
        <router-link to="/game">New Game</router-link> |
        <router-link to="/waiting">Waiting Room</router-link>
      </div>
      <div class="c-bar c-bar-header"></div>
  </div>
</template>

<script>
export default {
  name: 'AppHeader'
}
</script>

<style scoped lang="scss">
@import './src/style/components/components.appheader';
@import './src/style/components/components.bar';
@import './src/style/objects/objects.container';
</style>
