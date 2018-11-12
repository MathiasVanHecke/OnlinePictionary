<template>
  <div class="c-game-master c-hidden">
    <h3>{{ text }}</h3>
  </div>
</template>

<script>
export default {
  name: 'GameMaster',
  data() {
    return {
      text : "",
      wait : (delay) => new Promise(resolve => setTimeout(resolve, delay)),
    }
  },
  methods: {
    drafted : function() {
      this.$el.classList.remove('c-hidden');
      this.wait(4500)
      .then(() => (this.hide()))
      .then(() => (this.$root.$emit('start', 15)));
    },
    stop : function() {
      this.$el.classList.remove('c-hidden');
      this.wait(4500)
      .then(() => (this.hide()))
      .then(() => (this.$root.$emit('drafted', "Piemel")));
    },
    hide : function() {
      this.$el.classList.add('c-hidden');
    }
  },
  mounted: function() {
    this.$root.$on('drafted', (member) => { 
      this.text = "Next up: " + member + " is drawing...";
      this.drafted(); 
    });
    this.$root.$on('stop', () => { 
      this.text = "The word was: " + this.$store.getters.getTheWord + "!";
      this.stop(); 
    });
  }
}
</script>

<style scoped lang="scss">
@import './src/style/components/components.gamemaster';
</style>
