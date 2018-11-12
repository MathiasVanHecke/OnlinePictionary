<template>
    <div class="c-chat-holder js-chat-holder">
        <div class="c-word">______</div>
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
    this.$root.$on('start', () => {
      this.guessed = false;
    })
    this.$root.$on('guess', (name, msg) => { 
      if (msg == this.$store.getters.getTheWord){ 
        if (!this.guessed) {
          this.$root.$emit('guessed', name); 
          this.guessed = true;
        }
      }
      else {this.$root.$emit('message', name, msg); }
    });
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.chatholder';
</style>
