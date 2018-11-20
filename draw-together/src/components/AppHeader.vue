<template>
  <div class="c-appheader">
      <div class="o-container">
        <span>
          <router-link to="/">Landing</router-link> |
          <router-link to="/home">Home</router-link> |
          <router-link to="/waiting">Waiting</router-link> |
          <router-link to="/game">Game</router-link>
        </span>
        <span class="c-flag" v-on:click="switchLanguage">
          <img v-if="flag == 'be'" src="/img/flags/be.png"/>
          <img v-if="flag == 'en'" src="/img/flags/en.png"/>
        </span>
      </div>
      <div class="c-bar c-bar-header"></div>
  </div>
</template>

<script>
export default {
  name: 'AppHeader',
  data() {
    return {
      flag : 'be',
    }
  },
  methods : {
    switchLanguage : function(){
      if (this.flag == 'be') {
        this.flag = 'en';
        this.$i18n.locale = 'be';
      }
      else {
        this.flag = 'be';
        this.$i18n.locale = 'en';
      }
    }
  }
}
</script>

<style scoped lang="scss">
@import './src/style/components/components.appheader';
@import './src/style/components/components.bar';
@import './src/style/objects/objects.container';

.o-container {
  display: flex;
  flex-flow: row nowrap;
  justify-content: space-between;
}

.c-flag {
  align-self: center;
  cursor: pointer;
  padding-left: 1rem;
  height: 1rem;
  width:  1rem;
}
</style>
