<template>
    <div class="c-color" v-on:click="setColor" :id="color"></div>
</template>

<script>
export default {
  name: 'color',
  props: {
    color: String
  },
  methods: {
    setColor: function (event) {
      this.$store.dispatch('setColor', event.srcElement.id);
      console.log(this.$store.getters.getPickedColor);
    }
  },
  mounted: function (){
    this.$el.style.backgroundColor = this.$el.id;
  }
}
</script>

<style scoped lang="scss">
  @import './src/style/components/components.colorpicker';
</style>
