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
    word: function(){ return this.$store.getters.getPickedWord; }
  },
  methods: {
    drafted : function() {
      let that = this;
      this.$el.classList.remove('c-hidden');
      this.wait(2000)
      .then(() => (this.hide()))
      .then(function()
      {
        console.log("trying to invoke start");
        console.log("am host?", that.$store.getters.getHost)
        if(that.$store.getters.getHost){
          console.log("invoked start");
          that.$store.getters.getConnection.invoke('Start', that.$store.getters.getRoomkey, that.$store.getters.getRoundsLength);
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
        this.$root.$emit('NewDraft');
      }
    },
    hide : function() {
      this.$el.classList.add('c-hidden');
    }
  },
  mounted: function() {
    this.newdraft();
    this.$store.getters.getConnection.on('Drafted', (member, word) => { 
      this.$store.dispatch("setPickedWord", word);
      if(member == this.$store.getters.getMyName){
        this.$store.dispatch("setDrawing", true),
        this.text = "You're up! The word is "+ word + ".";
      }
      else { 
        this.text = "Next up: " + member + " is drawing..."; 
      }
      this.drafted(); 
    });
    this.$store.getters.getConnection.on('Stop', () => { 
      this.$store.dispatch("setDrawing", false),
      this.text = "The word was: " + this.word + "!";
      this.stop(); 
    });
  },
  destroyed: function() {
    this.$store.getters.getConnection.off('Drafted');
    this.$store.getters.getConnection.off('Stop');
  }
}
</script>

<style scoped lang="scss">
@import './src/style/components/components.gamemaster';
</style>
