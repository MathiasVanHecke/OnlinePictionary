<template>
  <div class="home o-smallpage">
    <button class="o-fancybutton" v-on:click="create">{{ $t('start') }}</button>
    <h3>{{ $t('or') }}</h3>
    <input v-model="roomkey" type="text" class="o-input" placeholder="Room Key">
    <button class="o-fancybutton" v-on:click="join">{{ $t('join') }}</button>
  </div>
</template>

<script>
export default {
  name: 'Home',
  data() {
    return {
      roomkey : '',
      isValid : true,
    }
  },
  methods : {
    create : function() {
      this.roomkey = Math.random().toString(36).replace(/[^a-z]+/g, '').substr(0, 16);
      this.$router.push({ path: 'waiting', roomkey: this.roomkey, isHost: true });
    },
    join : function() {
      if (this.isValid){
        this.$router.push({ path: 'waiting', roomkey: this.roomkey, isHost: false });
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