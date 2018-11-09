<template>
  <div class="c-controls o-grid">
      <ColorPicker/>
      <BrushPicker/>
      <Trashcan/>
  </div>
</template>

<script>
import BrushPicker from '@/components/BrushPicker.vue'
import ColorPicker from '@/components/ColorPicker.vue'
import Trashcan from '@/components/Trashcan.vue'

export default {
  name: 'controls',
  components: {
    ColorPicker,
    BrushPicker,
    Trashcan
  }
}
</script>

<style scoped lang="scss">
@import './src/style/components/components.controls';
@import './src/style/objects/objects.grid';
</style>
