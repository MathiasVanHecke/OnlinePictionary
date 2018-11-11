<template>
  <div class="c-chat o-grid">
    <div v-for="guess in guesses" :key="guess.id" >
      <!-- Eigen -->
      <ChatMessage class="fade-in" v-if="guess.own == true" :m="guess.message"/>
      <ChatResponse class="fade-in" v-else :name="guess.mebmer" :msg="guess.message"/>
    </div>
  </div>
</template>

<script>
import ChatMessage from '@/components/ChatMessage.vue';
import ChatResponse from '@/components/ChatResponse.vue';

export default {
  name: 'Chat',
  components: {
    ChatMessage,
    ChatResponse,
  },
  data() {
  return {
      idForGuess: 3,
      guesses:[]
  }
  },
  mounted: function() {
    this.$root.$on('addchat', (newGuess) => { 
      if(newGuess.trim().length == 0){return}
      this.guesses.push({
        id: this.idForGuess,
        message: newGuess,
        own: false,
      })

      this.newGuess = ' '
      this.idForGuess++
    });
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.chat';
@import './src/style/objects/objects.grid';
</style>
