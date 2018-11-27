<template>
    <ChatAnnouncement v-if="name == ''" :msg="msg"/>
    <ChatResponse v-else-if="mine==false" :name="name" :color="color" :msg="msg"/>
    <ChatMessage v-else :msg="msg"/>
</template>

<script>
import ChatAnnouncement from '@/components/Chat/ChatAnnouncement.vue';
import ChatMessage from '@/components/Chat/ChatMessage.vue';
import ChatResponse from '@/components/Chat/ChatResponse.vue';

export default {
  name: 'ChatItem',
  props: {
    msg: String,
    name: String,
    color: String,
  },
  computed: {
    mine: function () {
      if (this.name == this.$store.getters.getMyName) return true;
      else return false;
    }
  },
  components : {
    ChatMessage,
    ChatResponse,
    ChatAnnouncement,
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.chat';
</style>