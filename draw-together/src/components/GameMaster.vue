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
      let that = this;
      this.$el.classList.remove('c-hidden');
      this.wait(2000)
      .then(() => (this.hide()))
      .then(function()
      {
        if(that.$store.getters.getHost){
          that.$store.getters.getConnection.invoke('Start', that.$store.getters.getRoomkey, 20);
          console.log("invoked start");
        }
      })
    },
    stop : function() {
      this.$el.classList.remove('c-hidden');
      this.wait(2000)
      .then(() => (this.hide()))
      .then(() => (this.newdraft()));
    },
    newdraft : function() {
      if(this.$store.getters.getHost){
        this.$store.getters.getConnection.invoke('Drafted', this.$store.getters.getRoomkey, "Nico");
      }
    },
    hide : function() {
      this.$el.classList.add('c-hidden');
    }
  },
  mounted: function() {
    this.$store.getters.getConnection.on('Drafted', (member) => { 
      this.$store.dispatch('setWord', this.$cookies.get('token'));
      if(member == this.$store.getters.getMyName){
        this.text = "You're up! The word is "+ this.word + ".";
      }
      else { this.text = "Next up: " + member + " is drawing..."; }
      this.drafted(); 
    });
    this.$store.getters.getConnection.on('Stop', () => { 
      this.text = "The word was: " + this.word + "!";
      this.stop(); 
    });
  }
}
</script>

<style scoped lang="scss">
@import './src/style/components/components.gamemaster';
</style>
