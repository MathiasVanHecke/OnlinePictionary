<template>
  <div class="c-waiting o-container">
    <MemberBar/>
    <GameSettings/>
  </div>
</template>

<script>
import AppHeader from '@/components/AppHeader.vue'
import MemberBar from '@/components/MemberBar.vue'
import GameSettings from '@/components/GameSettings.vue'

export default {
  name: 'Waiting',
  components: {
    AppHeader,
    MemberBar,
    GameSettings,
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/objects/objects.container';
</style>