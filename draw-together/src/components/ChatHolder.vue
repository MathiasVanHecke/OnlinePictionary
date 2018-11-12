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
    }
  },
  methods: {
    submit : function() {
      if(this.guess.trim().length == 0){ return; }
      console.log(this.guess)
      this.$root.$emit('message', 'Nico', this.guess);
      this.guess = "";
    }
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.chatholder';
</style>
