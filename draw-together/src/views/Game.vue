<template>
  <div class="c-game o-container o-grid">
    <Members :inGame="inGame"/>
    <div class="o-grid c-game-row">
        <DrawingControls/>
        <Drawing/>
        <ChatHolder/>
    </div>
    <GameMaster/>
  </div>
</template>

<script>
import Members from '@/components/Members.vue';
import GameMaster from '@/components/Gameplay/GameMaster.vue';
import DrawingControls from '@/components/Drawing/DrawingControls.vue';
import Drawing from '@/components/Drawing/Drawing.vue';
import ChatHolder from '@/components/Chat/ChatHolder.vue';

export default {
  name: 'Game',
  components: {
    Members,
    GameMaster,
    DrawingControls,
    Drawing,
    ChatHolder
  },
  data() {
    return {
      inGame : true,
    }
  },
  beforeDestroy : function() {
    this.$store.getters.getConnection.invoke('LeaveRoom', this.$store.getters.getRoomKey);
    this.$store.dispatch('setRoomkey', "");
    this.$store.dispatch('setMembers', []);
  },
  beforeCreate(){
    //Als er geen cookie aanwezig is redirect naar de login
    if(!this.$cookies.get('token')){
      this.$router.push({ path: '/' });
    }
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/objects/objects.container';
@import './src/style/objects/objects.grid';
@import './src/style/components/components.bar';
@import './src/style/components/components.game';
</style>
