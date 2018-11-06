<template>
    <div class="c-brush" v-on:click="setBrush" :id="brush">
        <div class="c-brush-size"></div>
    </div>
</template>

<script>
export default {
  name: 'color',
  props: {
    brush: Number,
  },
  methods: {
    setBrush: function (event) {
      this.$store.dispatch('setBrush', event.srcElement.id);
      console.log(this.$store.getters.getPickedBrush);
    }
  },
  mounted: function (){
    console.log(this.$el);
    this.$el.children[0].style.width = this.$el.id + "px";
    this.$el.children[0].style.height = this.$el.id + "px";
  }
}
</script>

<style scoped lang="scss">
  @import './src/style/components/components.brushpicker';
</style>
