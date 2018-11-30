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
        guesses : 0,
        members : 0,
    }
  },
  mounted: function() {
    this.$root.$on("members", function(m){ this.members = m });
    this.$store.getters.getConnection.on('Guessed', () => {
        this.guesses += 1;
        if (this.guesses == this.members) {
            if (this.$store.getters.getHost) {
                this.$store.getters.getConnection.invoke("Stop", this.$store.getters.getRoomkey);
            }
        }
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
