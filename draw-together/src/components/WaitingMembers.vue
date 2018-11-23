<template>
  <div class="o-smallpage">
    <h3>{{ $t('ready') }}</h3>
    <div class="c-waiting-member" v-for="member in members" :key="member.id">
      <img class="c-waiting-member__p" src="../assets/p_gnome.png" alt="">
      <p class="c-waiting-member__u">{{ member.name }}</p>
    </div>  
  </div>
</template>

<script>
export default {
  name: 'WaitingMembers',
  data() {
    return {
      members : []
    }
  },
  mounted() {
    this.$store.getters.getConnection.on("NewMember", (member) => { 
      this.members.push(member);
      if (this.$store.getters.getHost) {this.$store.getters.getConnection.invoke("UpdateMembers", this.$store.getters.getRoomkey, this.members)}
      console.log('roomkey get:', this.$store.getters.getRoomkey);
    });
    this.$store.getters.getConnection.on("UpdateMembers", (members) => { 
      console.log(members);
      this.members = members;
    });
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
@import './src/style/objects/objects.smallpage';
@import './src/style/components/components.waitingmembers';

</style>
