<template>
  <div class="c-waiting o-container">
    <GameSettings v-if="isHost" :roomkey="roomkey"/>
    <WaitingMembers/>
  </div>
</template>

<script>
import AppHeader from '@/components/AppHeader.vue'
import GameSettings from '@/components/GameSettings.vue'
import WaitingMembers from '@/components/WaitingMembers.vue'

export default {
  name: 'Waiting',
  computed : {
    roomkey : function() { return this.$store.getters.getRoomkey },
    isHost : function() { return this.$store.getters.getHost },
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
    var me = "{name : '" + this.$store.getters.getMyName + "'}"
    this.$store.getters.getConnection.invoke("JoinRoom", this.roomkey, me);
  
    this.$store.getters.getConnection.on("StartGame", () => {
      this.$router.push({ path: 'game' });
    });
  },
}
</script>

<style lang="scss" scoped>
@import './src/style/objects/objects.container';

.c-waiting{
  display: flex;
  justify-content: center;
}
</style>