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
      .then(() => (this.$root.$emit('start', 60)));
    },
    stop : function() {
      this.$el.classList.remove('c-hidden');
      this.wait(4500)
      .then(() => (this.hide()))
      .then(() => (this.$root.$emit('drafted', "Nico")));
    },
    hide : function() {
      this.$el.classList.add('c-hidden');
    }
  },
  mounted: function() {
    this.$root.$on('drafted', (member) => { 
      if(member == this.$store.getters.getMyName){
        let word = "zebrapaardje";
        this.text = "You're up! The word is \"" + word + "\".";
      }
      else { this.text = "Next up: " + member + " is drawing..."; }
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
