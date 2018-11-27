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
    let img = '#'+Math.floor(Math.random()*16777215).toString(16);
    this.$store.dispatch("setMyColor", img);
    let me = "{name : '" + this.$store.getters.getMyName + "', img : '" + img + "'}";
    this.$store.getters.getConnection.invoke("JoinRoom", this.$store.getters.getRoomkey, me);
    this.$store.getters.getConnection.on("StartGame", () => {
      this.$router.push({ path: 'game' });
    });
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

.c-waiting{
  display: flex;
  justify-content: center;
}

@media only screen and (max-width: 1049px) { 
  .c-waiting {
      flex-direction: column;
  }
}

</style>