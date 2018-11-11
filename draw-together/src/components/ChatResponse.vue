<template>
  <div class="c-chat-response">
    <div class="c-chat-member"></div>
    <span class='c-chat-responseb'>
    <p class="c-chat-memberb">{{ name }}</p>
    <p class="c-chat-message">{{ msg }}</p>
    </span>
  </div>
</template>

<script>
export default {
  name: 'ChatResponse',
  props: {
    msg: String,
    name: String,
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.chat';
</style>