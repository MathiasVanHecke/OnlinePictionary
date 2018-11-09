<template>
    <div class="c-color" v-on:click="setColor" :id="color">
    </div>
</template>

<script>
export default {
  name: 'Color',
  props: {
    color: String
  },
  methods: {
    setColor: function() {
      this.$store.dispatch('setColor', this.color);
      console.log(this.$store.getters.getPickedColor);
    }
  },
  mounted: function (){
    this.$el.style.backgroundColor = this.color;
  }
}
</script>

<style scoped lang="scss">
  @import './src/style/components/components.colorpicker';
</style>
