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
import memberbar from '@/components/memberbar.vue'
import controls from '@/components/controls.vue';
import drawing from '@/components/drawing.vue';
import chatholder from '@/components/chatholder.vue';

export default {
  name: 'game',
  components: {
    memberbar,
    controls,
    drawing,
    chatholder
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/objects/objects.container';
@import './src/style/objects/objects.grid';
@import './src/style/components/components.bar';
@import './src/style/components/components.game';
</style>
