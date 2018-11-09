<template>
  <div class="c-chat o-grid">
    <span class="c-chat-response">
      <div class="c-chat-member"></div>
      <p class="c-chat-message">kip</p>
    </span>
    <p class="c-chat-message">geit</p>
    <span class="c-chat-response">
      <div class="c-chat-member" style="background-color: steelblue;"></div>
      <p class="c-chat-message">olifant</p>
    </span>
    <span class="c-chat-response">
      <div class="c-chat-member" style="background-color: thistle;"></div>
      <p class="c-chat-message">paard</p>
    </span>
    <p class="c-chat-message">giraf</p>
    <span class="c-chat-responseb">
      <p class="c-chat-memberb">Mathias</p>
      <p class="c-chat-message">eenhoorn</p>
    </span>
    <span class="c-chat-responseb">
      <p class="c-chat-memberb">Nico</p>
      <p class="c-chat-message">ezel</p>
    </span>
  </div>
</template>

<script>
export default {
  name: 'Chat'
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.chat';
@import './src/style/objects/objects.grid';
</style>
