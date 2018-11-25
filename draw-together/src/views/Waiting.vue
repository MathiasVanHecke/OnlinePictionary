<template>
  <div class="c-waiting o-container">
    <GameSettings v-if="isHost" :roomkey="roomkey"/>
    <Members/>
  </div>
</template>

<script>
import GameSettings from '@/components/GameSettings.vue'
import Members from '@/components/Members.vue'

export default {
  name: 'Waiting',
  computed : {
    roomkey : function() { return this.$store.getters.getRoomkey },
    isHost : function() { return this.$store.getters.getHost },
  },
  components: {
    GameSettings,
    Members
  },
  mounted() {
    if (this.$store.getters.getRoomkey == "") {
      let key = Math.random().toString(36).replace(/[^a-z]+/g, '').substr(0, 16);
      this.$store.dispatch("setRoomkey", key);
    }
    var me = "{name : '" + this.$store.getters.getMyName + "'}"
    this.$store.getters.getConnection.invoke("JoinRoom", this.$store.getters.getRoomkey, me);
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