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
      members : [
          {
            id: 1,
            name: "Céline",
          },
          {
            id: 2,
            name: "Mathias",
          },
          {
            id: 3,
            name: "Jens",
          },
          {
            id: 4,
            name: "Nico",
          }
      ]
    }
  },

}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
@import './src/style/objects/objects.smallpage';
@import './src/style/components/components.waitingmembers';

</style>
