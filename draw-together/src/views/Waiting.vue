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
  props: {
    isHost : Boolean,
    roomkey : String
  },
  data() {
    return {
      members : [

      ]
    }
  },
  components: {
    AppHeader,
    GameSettings,
    WaitingMembers
  },
  mounted() {
    this.$store.getters.getConnection.on("NewMember", (member) => { 
      console.log(member);
      if (this.isHost) {this.$store.getters.getConnection.invoke("UpdateMembers", this.roomkey, this.members)}
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