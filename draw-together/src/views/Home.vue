<template>
  <div class="home o-smallpage">
    <router-link to="waiting"><button class="o-fancybutton">Start a new game</button></router-link>
    <h3>or</h3>
    <input v-model="roomKey" type="text" class="o-input" placeholder="Room Key">
    <button class="o-fancybutton" v-on:click="join">Join a room</button>
  </div>
</template>

<script>
export default {
  name: 'Home',
  data() {
    return {
      roomKey : '',
      isValid : false,
    }
  },
  methods : {
    join : function() {
      if (this.isValid){
        this.$router.push({ path: 'waiting' });
      }
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