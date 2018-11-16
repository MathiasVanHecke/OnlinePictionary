<template>
  <div class="c-appheader">
      <div class="o-container">
        <span>
          <router-link to="/">Landing</router-link> |
          <router-link to="/home">Home</router-link> |
          <router-link to="/waiting">Waiting</router-link> |
          <router-link to="/game">Game</router-link>
        </span>
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
