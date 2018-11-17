<template>
  <div class="c-gamesettings o-smallpage">
    <h1 class="o-smallpage-header">New Game</h1>
    <input v-model="rounds" type="number" class="o-input" placeholder="Amount of rounds"    min="1" max="10">
    <input v-model="length" type="number" class="o-input" placeholder="Length of one round" min="40" max="120" step="10">
    <h3>Share this roomkey so people can join:</h3>
    <div class="c-gamesettings-key">
      <p>{{ roomkey }}</p>
      <input type="hidden" id="roomkey" :value="roomkey">
      <div ref="clipboard" class="c-gamesettings-key-copy" v-on:click="copyToClipboard">📋</div>
    </div>
    <button class="o-fancybutton" v-on:click="start">Start</button>
  </div>
</template>

<script>
export default {
  name: 'GameSettings',
  data() {
    return {
      isValid : false,
      rounds : null,
      length : null,
      roomkey : "RoomKeyRandomisedJaaa"
    }
  },
  methods: {
    copyToClipboard() {
      let text = document.querySelector('#roomkey');
      text.setAttribute('type', 'text');
      text.select();
      var successful = document.execCommand('copy');
      if (successful) this.$refs.clipboard.classList.add('c-gamesettings-key-copy--done');
      text.setAttribute('type', 'hidden');
      window.getSelection().removeAllRanges();
    },
    start(){
      if (this.isValid){
        this.$store.dispatch('setRoundsAmount', this.rounds);
        this.$store.dispatch('setRoundsLength', this.length);
        this.$router.push({ path: 'game' });
      }
    }
  },
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
@import './src/style/objects/objects.fancybutton';
@import './src/style/objects/objects.input';
@import './src/style/objects/objects.smallpage';
@import './src/style/components/components.gamesettings';
</style>
