<template>
  <div class="c-chat-response">
    <Avatar :color="color" :canShrink="true" />
    <span class='c-chat-responseb'>
    <p class="c-chat-memberb">{{ name }}</p>
    <p class="c-chat-message c-chat-messageb">{{ msg }}</p>
    </span>
  </div>
</template>

<script>
import Avatar from '@/components/Avatar.vue';

export default {
  name: 'ChatResponse',
  props: {
    msg: String,
    name: String,
    color: String,
  },
  data() {
    return {
      true : true,
    }
  },
  components: {
    Avatar
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.chat';
</style>