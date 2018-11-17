<template>
  <div class="c-game-master c-hidden">
    <h3>You're up! The word is {{ word }}.</h3>
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
  computed:{
    word: function(){
      return this.$store.getters.getTheWord
    }
  },
  methods: {
    drafted : function() {
      this.$el.classList.remove('c-hidden');
      this.wait(4500)
      .then(() => (this.hide()))
      .then(() => (this.$root.$emit('start', 40)));
    },
    stop : function() {
      this.$el.classList.remove('c-hidden');
      this.wait(4500)
      .then(() => (this.hide()))
      .then(() => (this.newdraft()));
    },
    newdraft : function() {
      this.$root.$emit('drafted', "Nico");
    },
    hide : function() {
      this.$el.classList.add('c-hidden');
    }
  },
  mounted: function() {
    this.$root.$on('drafted', (member) => { 
      if(member == this.$store.getters.getMyName){
        this.$store.dispatch('setWord')
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
