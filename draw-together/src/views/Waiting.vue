<template>
  <div class="c-waiting o-container">
    <GameSettings/>
    <WaitingMembers/>
  </div>
</template>

<script>
import AppHeader from '@/components/AppHeader.vue'
import GameSettings from '@/components/GameSettings.vue'
import WaitingMembers from '@/components/WaitingMembers.vue'

export default {
  name: 'Waiting',
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