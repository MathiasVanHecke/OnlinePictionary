<template>
    <ChatAnnouncement v-if="name == ''" :msg="msg"/>
    <ChatResponse v-else-if="mine==false" :name="name" :msg="msg"/>
    <ChatMessage v-else :msg="msg"/>
</template>

<script>
import ChatAnnouncement from '@/components/ChatAnnouncement.vue';
import ChatMessage from '@/components/ChatMessage.vue';
import ChatResponse from '@/components/ChatResponse.vue';

export default {
  name: 'ChatItem',
  props: {
    msg: String,
    name: String,
  },
  data() {
    return {
        myname : "Nico",
    }
  },
  computed: {
    mine: function () {
      if (this.name == this.myname) return true;
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