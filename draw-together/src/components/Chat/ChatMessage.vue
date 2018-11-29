<template>
  <p class="c-chat-item c-chat-message">
      {{ msg }}
  </p>
</template>

<script>
export default {
  name: 'ChatMessage',
  props: {
    msg: String
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.chat';
</style>
