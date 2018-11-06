<template>
  <div class="c-brushpicker o-grid o-collection">

    <brush v-for="brush in brushes" :key="brush" :brush="brush"></brush>

    <!-- <div class="c-brush" id="S"></div>
    <div class="c-brush" id="M"></div>
    <div class="c-brush" id="L"></div> -->
  </div>
</template>

<script>
import brush from '@/components/brush.vue';

export default {
  name: 'brushpicker',
  data() {
    return { 
      brushes : [
        4,
        18,
        32,
      ]
    }
  },
  components: {
    brush
  }
}
</script>

<style scoped lang="scss">
@import './src/style/components/components.brushpicker';
@import './src/style/objects/objects.grid';
@import './src/style/objects/objects.collection';
</style>
