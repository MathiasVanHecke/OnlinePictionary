<template>
  <div class="home o-smallpage">
    <button class="o-fancybutton">Start a new game</button>
    <h3>or</h3>
    <input v-model="roomKey" type="text" class="o-input" placeholder="Room Key">
    <button class="o-fancybutton">Join a room</button>
  </div>
</template>

<script>
export default {
  name: 'Home',
  data() {
    return {
      roomKey : '',
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