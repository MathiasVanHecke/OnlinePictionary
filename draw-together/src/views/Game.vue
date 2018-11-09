<template>
  <div class="c-game o-container o-grid">
    <MemberBar/>
    <div class="o-grid c-game-row">
        <DrawingControls/>
        <Drawing/>
        <ChatHolder/>
    </div>
  </div>
</template>

<script>
import MemberBar from '@/components/MemberBar.vue'
import DrawingControls from '@/components/DrawingControls.vue';
import Drawing from '@/components/Drawing.vue';
import ChatHolder from '@/components/ChatHolder.vue';

export default {
  name: 'Game',
  components: {
    MemberBar,
    DrawingControls,
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
