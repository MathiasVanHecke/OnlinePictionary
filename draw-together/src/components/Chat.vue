<template>
  <div class="c-chat o-grid">
    <span class="c-chat-response">
      <div class="c-chat-member"></div>
      <p class="c-chat-message">kip</p>
    </span>
    <ChatMessage m="Geit"/>
    <span class="c-chat-response">
      <div class="c-chat-member" style="background-color: steelblue;"></div>
      <p class="c-chat-message">olifant</p>
    </span>
    <span class="c-chat-response">
      <div class="c-chat-member" style="background-color: thistle;"></div>
      <p class="c-chat-message">paard</p>
    </span>
    <ChatMessage m="Giraf"/>
    <span class="c-chat-responseb">
      <p class="c-chat-memberb">Mathias</p>
      <p class="c-chat-message">eenhoorn</p>
    </span>
    <span class="c-chat-response">
      <div class="c-chat-member" style="background-color: steelblue;"></div>
      <span class='c-chat-responseb'>
        <p class="c-chat-memberb">Nico</p>
        <p class="c-chat-message">ezel</p>
      </span>
    </span>
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
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.chat';
@import './src/style/objects/objects.grid';
</style>
