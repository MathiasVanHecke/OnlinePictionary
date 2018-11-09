<template>
  <div class="c-chat-response o-grid">

    <span class="c-chat-response">
      <div class="c-chat-member" style="background-color: steelblue;"></div>
      <p class="c-chat-message">olifant</p>
    </span>

    <span class="c-chat-responseb">
      <p class="c-chat-memberb">Nico</p>
      <p class="c-chat-message">ezel</p>
    </span>
  </div>
</template>

<script>
export default {
  name: 'ChatResponse',
  props: {
    m: String
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.chat';
</style>