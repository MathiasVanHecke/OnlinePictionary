<template>
  <div v-if="inGame" class="c-memberbar o-grid">
      <div class="c-member" v-for="member in members" :key="member.id">
          <div class="c-member-avatar"></div>
          <span>
              <p class="c-member-name">{{member.name}}</p>
              <p class="c-member-score">{{member.score}}</p>
          </span>
      </div>
  </div>
  <div v-else class="o-smallpage">
    <h3>{{ $t('ready') }}</h3>
    <div class="c-waiting-member" v-for="member in members" :key="member.id">
      <img class="c-waiting-member__p" src="../assets/p_gnome.png" alt="">
      <p class="c-waiting-member__u">{{ member.name }}</p>
    </div>  
  </div>
</template>

<script>
export default {
  name: 'Members',
  props: {
    inGame : Boolean,
  },
  computed : {
    members : function(){
      return this.$store.getters.getMembers;
    }
  },
  mounted() {
    this.$store.getters.getConnection.on("NewMember", (member) => { 
      this.$store.dispatch("addMember", member);
      if (this.$store.getters.getHost) {
        member.color = '#'+Math.floor(Math.random()*16777215).toString(16);
        console.log(member);
        this.$store.getters.getConnection.invoke("UpdateMembers", this.$store.getters.getRoomkey, this.members)
      }
    });
    this.$store.getters.getConnection.on("UpdateMembers", (members) => { 
      this.$store.dispatch("setMembers", members);
    });
    this.$store.getters.getConnection.on("Guessed", (name, seconds) => {
      let member = this.members.find((m)=>(m.name == name));
      console.log("member", member);
      member.score += seconds;
    })
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
@import './src/style/objects/objects.smallpage';
@import './src/style/objects/objects.grid';
@import './src/style/components/components.memberbar';
@import './src/style/components/components.waitingmembers';

</style>
