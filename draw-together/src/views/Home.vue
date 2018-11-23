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
      this.$store.dispatch("setHost", true);
      this.$router.push({ name: 'waiting'});
    },
    join : function() {
      if (this.isValid){
        this.$store.dispatch("setRoomkey", this.roomkey);
        this.$router.push({ path: 'waiting'});
      }
    }
  },
  mounted() {
    this.$store.dispatch("setHost", false);
    this.$store.dispatch("setRoomkey", "");
  }
}
</script>

<style scoped lang="scss">
@import './src/style/objects/objects.fancybutton';
@import './src/style/objects/objects.input';
@import './src/style/objects/objects.smallpage';
@import './src/style/components/components.login';
</style>