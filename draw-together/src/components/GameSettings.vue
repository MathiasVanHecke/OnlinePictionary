<template>
  <div class="c-gamesettings o-smallpage">
    <h1 class="o-smallpage-header">{{ $t('newgame') }}</h1>
    <input v-model="rounds" ref="rounds" v-on:focusout="validateRounds" type="number" class="o-input" placeholder="Amount of rounds" min="1" max="10">
    <input v-model="length" ref="length" v-on:focusout="validateLength" type="number" class="o-input" placeholder="Length of one round" min="40" max="120" step="10">
    <h3>{{ $t('joincode') }}</h3>
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
  props: {
    roomkey : String,
  },
  data() {
    return {
      isValid : false,
      rounds : null,
      length : null,
    }
  },
  methods: {
    validateRounds() {
      if (this.rounds < 1) this.rounds = 1;
      if (this.rounds > 10) this.rounds = 10;
      this.validate();
    },
    validateLength() {
      if (this.length < 40) this.length = 40;
      if (this.length > 120) this.length = 120;
      this.validate();
    },
    validate() {
      if (this.rounds >= 1 && this.rounds <= 10 && this.length >= 40 && this.length <= 120) this.isValid = true;
      if (this.rounds < 1 || this.rounds > 10) this.$refs.rounds.classList.add('o-input--invalid');
      else this.$refs.rounds.classList.remove('o-input--invalid');
      if (this.length < 40 || this.length > 120) this.$refs.length.classList.add('o-input--invalid');
      else this.$refs.length.classList.remove('o-input--invalid');
    },
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
      this.validate();
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
