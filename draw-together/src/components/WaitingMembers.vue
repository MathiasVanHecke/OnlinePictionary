<template>
  <div class="o-smallpage">
    <h3>Players that are already in the room</h3>
    <div class="c-waiting-member">
        <img class="c-waiting-member__p" src="../assets/p_gnome.png" alt="">
        <p class="c-waiting-member__u">Mathias Van Hecke</p>
    </div>

       <div class="c-waiting-member">
        <img class="c-waiting-member__p" src="../assets/p_gnome.png" alt="">
        <p class="c-waiting-member__u">Mathias Van Hecke</p>
    </div>

       <div class="c-waiting-member">
        <img class="c-waiting-member__p" src="../assets/p_gnome.png" alt="">
        <p class="c-waiting-member__u">Mathias Van Hecke</p>
    </div>    
  </div>
</template>

<script>
export default {
  name: 'WaitingMembers',
  props:{
      playerIcon: null,
      PlayerName: String
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
@import './src/style/objects/objects.smallpage';
@import './src/style/components/components.waitingmembers';

</style>
