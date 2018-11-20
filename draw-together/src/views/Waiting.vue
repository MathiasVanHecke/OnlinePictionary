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
  data() {
    return {
      roomkey : Math.random().toString(36).replace(/[^a-z]+/g, '').substr(0, 16)
    }
  },
  components: {
    AppHeader,
    GameSettings,
    WaitingMembers
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