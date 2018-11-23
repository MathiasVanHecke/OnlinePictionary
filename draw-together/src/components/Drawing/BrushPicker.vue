<template>
  <div class="c-brushpicker o-grid o-collection">

    <Brush v-for="brush in brushes" :key="brush" :brush="brush"></Brush>

  </div>
</template>

<script>
import Brush from '@/components/Drawing/Brush.vue';

export default {
  name: 'BrushPicker',
  data() {
    return { 
      brushes : [
        4,
        18,
        32
      ]
    }
  },
  components: {
    Brush
  }
}
</script>

<style scoped lang="scss">
@import './src/style/components/components.brushpicker';
@import './src/style/objects/objects.grid';
@import './src/style/objects/objects.collection';
</style>
