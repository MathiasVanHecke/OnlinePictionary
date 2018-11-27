<template>
  <VuePerfectScrollbar class="c-chat o-grid">
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
      chatitems: [
        {
          id: 1,
          msg: "kip",
          name: "Bauke",
          color: "#123456",
        },
        {
          id: 2,
          msg: "paard",
          name: "Nico",
          color: "#987654",
        },
        {
          id:3,
          msg: "Céline guessed the word!",
          name: "",
          color: "",
        },
        {
          id: 4,
          msg: "geit",
          name: "Mathias",
          color: "#456789",
        },
        {
          id: 5,
          msg: "koe",
          name: "Piemel",
          color: "#654321",
        },
      ]
    }
  },
  mounted: function() {
    this.$store.getters.getConnection.on("Guessed", (name) => {
      this.chatitems.push({
        id : this.chatitems.length + 1,
        msg : name + " guessed the word!",
        name : "",
        });
    })
    this.$store.getters.getConnection.on("ReceiveMessage", (name, color, msg) => { 
      this.chatitems.push({
        id : this.chatitems.length + 1,
        msg : msg,
        name : name,
        color : color,
      });
    });
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.chat';
@import './src/style/objects/objects.grid';
</style>
