<template>
  <p class="c-chat-item c-chat-announcement">
      {{ msg }}
  </p>
</template>

<script>
export default {
  name: 'ChatAnnouncement',
  props: {
    msg: String
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.chat';
</style>
