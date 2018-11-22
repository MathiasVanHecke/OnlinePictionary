<template>
  <div class="c-game-master c-hidden">
    <h3>{{text}}</h3>
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
      return this.$store.getters.getPickedWord;
    }
  },
  methods: {
    drafted : function() {
      this.$el.classList.remove('c-hidden');
      this.wait(450)
      .then(() => (this.hide()))
      .then(() => (this.$store.getters.getConnection.invoke('Start', 5)));
    },
    stop : function() {
      this.$el.classList.remove('c-hidden');
      this.wait(450)
      .then(() => (this.hide()))
      .then(() => (this.newdraft()));
    },
    newdraft : function() {
      this.$store.getters.getConnection.invoke('drafted', "Nico");
    },
    hide : function() {
      this.$el.classList.add('c-hidden');
    }
  },
  mounted: function() {
    this.$store.getters.getConnection.on('drafted', (member) => { 
      this.$store.dispatch('setWord', this.$cookies.get('token'));
      if(member == this.$store.getters.getMyName){
        this.text = "You're up! The word is "+ this.word + ".";
      }
      else { this.text = "Next up: " + member + " is drawing..."; }
      this.drafted(); 
    });
    this.$store.getters.getConnection.on('stop', () => { 
      this.text = "The word was: " + this.word + "!";
      this.stop(); 
    });
  }
}
</script>

<style scoped lang="scss">
@import './src/style/components/components.gamemaster';
</style>
