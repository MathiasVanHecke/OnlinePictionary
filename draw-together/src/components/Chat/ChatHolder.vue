<template>
    <div class="c-chat-holder js-chat-holder">
        <div class="c-word">{{ wordholder }}</div>
        <GuessBar/>
        <Chat/>
        <ProgressBar/>
        <input v-model="guess" v-on:keyup.enter="submit" placeholder="guess" id="guess" class="c-chat-input">
    </div>
</template>

<script>
import Chat from '@/components/Chat/Chat.vue';
import GuessBar from '@/components/Gameplay/GuessBar.vue';
import ProgressBar from '@/components/Gameplay/ProgressBar.vue';

export default {
  name: 'ChatHolder',
  components: {
    Chat,
    GuessBar,
    ProgressBar,
  },
  data() {
    return {
      guess : "",
      guessed : false,
    }
  },
  computed : {
    isEnabled : function() { return !this.$store.getters.getDrawing },
    wordholder : function(){ 
      if (this.isEnabled) return this.$store.getters.getPickedWord.toUpperCase();
      let l = this.$store.getters.getPickedWord.length;
      let wordholder = "";
      for (let i = 0; i < l; i++){ wordholder += "_"; }
      return wordholder;
      }
  },
  methods: {
    submit : function() {
      if(this.guess.trim().length == 0){ return; }
      this.$root.$emit('guess', this.guess);
      if (this.isEnabled) {
        if (this.guess.toLowerCase() == this.$store.getters.getPickedWord.toLowerCase()){ 
          if (!this.guessed) {
            this.$root.$emit('sendguess');
            this.guessed = true;
          }
        }
        else {
          this.$store.getters.getConnection.invoke("SendMessage", this.$store.getters.getRoomkey, this.$store.getters.getMyName, this.$store.getters.getMyColor, (this.guess));
        }
      }
      this.guess = "";
    }
  },
  mounted: function() {
    this.$store.getters.getConnection.on('Start', () => { this.guessed = false; });
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.chatholder';
</style>
