<template>
  <div v-show="isEnabled" class="c-controls o-grid">
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
    this.$root.$on('drafted', (name) => { if (name == this.$store.getters.getMyName) {this.isEnabled = true; } else this.isEnabled = false });
  }
}
</script>

<style scoped lang="scss">
@import './src/style/components/components.controls';
@import './src/style/objects/objects.grid';
</style>
