<template>
  <p class="c-chat-message">
      {{ m }}
  </p>
</template>

<script>
export default {
  name: 'ChatMessage',
  props: {
    m: String
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.chat';
</style>
