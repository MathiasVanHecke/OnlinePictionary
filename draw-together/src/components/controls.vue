<template>
  <div class="c-controls o-grid">
      <colorpicker/>
      <brushpicker/>
      <trashcan/>
  </div>
</template>

<script>
import brushpicker from '@/components/brushpicker.vue'
import colorpicker from '@/components/colorpicker.vue'
import trashcan from '@/components/trashcan.vue'

export default {
  name: 'controls',
  components: {
    colorpicker,
    brushpicker,
    trashcan
  }
}
</script>

<style scoped lang="scss">
@import './src/style/components/components.controls';
@import './src/style/objects/objects.grid';
</style>
