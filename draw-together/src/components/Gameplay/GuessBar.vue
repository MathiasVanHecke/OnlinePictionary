<template>
    <div class="c-bar c-bar-guess">
        <div class="c-guess">
            <div v-for="item in guesses" :key="item" class="c-guess-done"></div>
        </div>
    </div>
</template>

<script>
export default {
  name: 'GuessBar',
  data() {
    return {
        guesses : 2,
    }
  },
  mounted: function() {
    this.$store.getters.getConnection.on('Guessed', () => {
        this.guesses += 1;
    });
  },
  destroyed: function() {
    this.$store.getters.getConnection.off('Guessed');
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.bar';
@import './src/style/components/components.chatholder';
</style>
