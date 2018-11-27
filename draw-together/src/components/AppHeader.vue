<template>
  <div class="c-appheader">
      <div class="c-header">
        <span v-on:click="home">Online Pictionary</span>
        <div class="c-right" v-on:click="logout">
          <span class="c-flag" v-on:click="switchLanguage">
            <img v-if="flag == 'be'" src="/img/flags/be.png"/>
            <img v-if="flag == 'en'" src="/img/flags/en.png"/>
          </span>
          <span class="c-flag">
            <img src="img/icons/logout.png">
          </span>
        </div>
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
        this.setLanguage('be');
      }
      else {
        this.flag = 'be';
        this.setLanguage('en');
      }
    },
    setLanguage : function(lang){
      this.$i18n.locale = lang;
      this.$cookies.config('30d');
      this.$cookies.set('locale', lang);
    },
    logout : function(){
      this.$cookies.set('token', "")
      this.$router.push({ path: '/' });
    },
    home : function(){
      this.$router.push({ path: '/home' });
    }
  },
  mounted() {
    if (this.$cookies.get('locale')){
      this.$i18n.locale = this.$cookies.get('locale');
    }
  }
}
</script>

<style scoped lang="scss">
@import './src/style/components/components.appheader';
@import './src/style/components/components.bar';
@import './src/style/objects/objects.container';
</style>
