<template>
  <VuePerfectScrollbar class="c-chat">
    <ChatItem v-for="item in chatitems" :key="item.id" :msg="item.msg" :name="item.name" :color="item.color" class="fade-in"/>
  </VuePerfectScrollbar>
</template>

<script>
import VuePerfectScrollbar from 'vue-perfect-scrollbar';
import ChatItem from '@/components/Chat/ChatItem.vue';

export default {
  name: 'Chat',
  components: {
    ChatItem,
    VuePerfectScrollbar,
  },
  data() {
    return {
      chatitems: [{id : 1, name : "bauke", msg : "first", color : "79aaee"}, {id : 2, name : "", msg : "here", color : "79aaee"}, {id : 3, name : "bauke", msg : "here", color : "79aaee"}]
    }
  },
  methods : {
    scrollDown : function() {
      this.scrollTop = this.scrollHeight;
    }
  },
  mounted: function() {
    this.$store.getters.getConnection.on("Guessed", (name) => {
      this.chatitems.unshift({
        id : this.chatitems.length + 1,
        msg : name + " guessed the word!",
        name : "",
        });
      this.scrollDown;
    })
    this.$store.getters.getConnection.on("ReceiveMessage", (name, color, msg) => { 
      this.chatitems.unshift({
        id : this.chatitems.length + 1,
        msg : msg,
        name : name,
        color : color,
      });
      this.scrollDown;
    });
  },
  destroyed: function() {
    this.$store.getters.getConnection.off('Guessed');
    this.$store.getters.getConnection.off('ReceiceMessage');
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.chat';
@import './src/style/objects/objects.grid';
</style>
