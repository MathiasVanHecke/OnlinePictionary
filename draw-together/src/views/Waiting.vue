<template>
  <div class="c-waiting o-container">
    <GameSettings :roomkey="roomkey"/>
    <WaitingMembers/>
  </div>
</template>

<script>
import AppHeader from '@/components/AppHeader.vue'
import GameSettings from '@/components/GameSettings.vue'
import WaitingMembers from '@/components/WaitingMembers.vue'

export default {
  name: 'Waiting',
  data() {
    return {
      members : [

      ]
    }
  },
  computed : {
    roomkey : function() { return this.$store.getters.getRoomkey },
  },
  components: {
    AppHeader,
    GameSettings,
    WaitingMembers
  },
  mounted() {
    if (this.$store.getters.getRoomkey == "") {
      let key = Math.random().toString(36).replace(/[^a-z]+/g, '').substr(0, 16);
      this.$store.dispatch("setRoomkey", key);
    }
    console.log("inwaiting", this.$store.getters.getRoomkey, this.$store.getters.getHost);
    var me = "{name : '" + this.$store.getters.getMyName + "'}"
    this.$store.getters.getConnection.invoke("JoinRoom", this.roomkey, me);
    this.$store.getters.getConnection.on("NewMember", (member) => { 
      console.log(member);
      if (this.$store.getters.getHost) {this.$store.getters.getConnection.invoke("UpdateMembers", this.roomkey, this.members)}
    });
    this.$store.getters.getConnection.on("UpdateMembers", (members) => { 
      console.log(members);
    });
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/objects/objects.container';

.c-waiting{
  display: flex;
  justify-content: center;
}
</style>