<template>
  <div v-show="isEnabled" class="c-controls o-grid">
      <ColorPicker/>
      <BrushPicker/>
      <Trashcan/>
  </div>
</template>

<script>
import BrushPicker from '@/components/Drawing/BrushPicker.vue'
import ColorPicker from '@/components/Drawing/ColorPicker.vue'
import Trashcan from '@/components/Drawing/Trashcan.vue'

export default {
  name: 'controls',
  data() {
    return {
      isEnabled : false,
    }
  },
  components: {
    ColorPicker,
    BrushPicker,
    Trashcan
  },
  mounted () {
    this.$store.getters.getConnection.on('Drafted', (name) => { if (name == this.$store.getters.getMyName) {this.isEnabled = true; } else this.isEnabled = false });
  }
}
</script>

<style scoped lang="scss">
@import './src/style/components/components.controls';
@import './src/style/objects/objects.grid';
</style>
