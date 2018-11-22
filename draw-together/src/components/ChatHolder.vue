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
import Chat from '@/components/Chat.vue';
import GuessBar from '@/components/GuessBar.vue';
import ProgressBar from '@/components/ProgressBar.vue';

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
      isEnabled : true,
    }
  },
  computed : {
    wordholder : function(){ 
      let l = this.$store.getters.getPickedWord.length;
      let wordholder = "";
      for (let i = 0; i < l; i++){ wordholder += "_"; }
      return wordholder;
      }
  },
  methods: {
    submit : function() {
      if(this.guess.trim().length == 0){ return; }
      this.$root.$emit('guess', this.$store.getters.getMyName, this.guess);
      this.guess = "";
    }
  },
  mounted: function() {
    this.$store.getters.getConnection.on('drafted', (member) => {
      if(member == this.$store.getters.getMyName) {this.isEnabled = false; } });
    this.$store.getters.getConnection.on('Stop', () => { 
      this.isEnabled = true; 
    });
    this.$store.getters.getConnection.on('Start', () => {
      this.guessed = false;
    })
    this.$root.$on('guess', (name, msg) => { 
      if (this.isEnabled) {
        if (msg == this.$store.getters.getPickedWord){ 
          if (!this.guessed) {
            //this.$root.$emit('guessed', name); 
            this.$store.getters.getConnection.invoke("Guessed", name);
            this.guessed = true;
          }
        }
        else {
          this.$store.getters.getConnection.invoke("SendMessage", name, msg);
        }
      }
    });
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.chatholder';
</style>
