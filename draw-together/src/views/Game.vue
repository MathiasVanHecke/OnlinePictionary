<template>
  <div class="c-game o-container o-grid">
    <memberbar/>
    <div class="o-grid c-game-row">
        <controls/>
        <drawing/>
        <chatholder/>
    </div>
  </div>
</template>

<script>
import MemberBar from '@/components/MemberBar.vue'
import Controls from '@/components/DrawingControls.vue';
import Drawing from '@/components/Drawing.vue';
import ChatHolder from '@/components/ChatHolder.vue';

export default {
  name: 'Game',
  components: {
    MemberBar,
    Controls,
    Drawing,
    ChatHolder
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/objects/objects.container';
@import './src/style/objects/objects.grid';
@import './src/style/components/components.bar';
@import './src/style/components/components.game';
</style>
