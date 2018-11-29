<template>
  <div v-if="inGame" class="c-memberbar o-grid">
      <div class="c-member" v-for="member in members" :key="member.id">
      <Avatar :color="member.img"/>
          <span>
              <p class="c-member-name">{{member.name}}</p>
              <p class="c-member-score">{{member.score}}</p>
          </span>
      </div>
  </div>
  <div v-else class="o-smallpage">
    <h3>{{ $t('ready') }}</h3>
    <div class="c-waiting-member" v-for="member in members" :key="member.id">
      <Avatar :color="member.img"/>
      <p class="c-member-name">{{ member.name }}</p>
    </div>  
  </div>
</template>

<script>
import Avatar from '@/components/Avatar.vue';

export default {
  name: 'Members',
  props: {
    inGame : Boolean,
  },
  components: {
    Avatar,
  },
  computed : {
    members : function(){
      return this.$store.getters.getMembers;
    }
  },
  mounted() {
    let that = this;
    this.$store.getters.getConnection.on("NewMember", (member) => { 
      if (this.$store.getters.getHost) {
        this.$store.dispatch("addMember", member);
        this.$store.getters.getConnection.invoke("UpdateMembers", this.$store.getters.getRoomkey, this.members)
      }
    });
    this.$store.getters.getConnection.on("UpdateMembers", (members) => { 
      this.$store.dispatch("setMembers", members);
    });
    this.$root.$on('NewDraft', function(){
      console.log("trying to draft");
      console.log("am host?", this.$store.getters.getHost)
      if (this.$store.getters.getHost) {
        console.log("drafted");
        let member = that.members[(Math.floor(Math.random()*that.members.length))];
        this.$store.dispatch('setWord', this.$cookies.get('token'), this.$cookies.get('locale'))
        .then(function(word){that.$store.getters.getConnection.invoke('Drafted', that.$store.getters.getRoomkey, member.name, word)});
      }
    });
    this.$store.getters.getConnection.on("Guessed", (name, seconds) => {
      let member = this.members.find((m)=>(m.name == name));
      member.score += seconds;
    })
  },
  destroyed() {
    this.$store.getters.getConnection.off('NewMember');
    this.$store.getters.getConnection.off('UpdateMembers');
    this.$root.$off('NewDraft');
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
