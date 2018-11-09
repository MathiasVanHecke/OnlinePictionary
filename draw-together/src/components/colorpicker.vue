<template>
  <div class="c-colorpicker o-grid o-collection">

    <Color v-for="color in colors" :key="color" :color="color"/>

  </div>
</template>

<script>
import Color from '@/components/Color.vue';

export default {
  name: 'ColorPicker',
  data() {
    return { 
      colors : [
        "salmon",
        "crimson",
        "darkred",

        "lightpink",
        "hotpink",
        "mediumvioletred",

        "thistle",
        "plum",
        "mediumorchid",

        "lightsteelblue",
        "steelblue",
        "darkslateblue",

        "paleturquoise",
        "darkturquoise",
        "teal",

        "greenyellow",
        "limegreen",
        "forestgreen",

        "khaki",
        "darkkhaki",
        "olive",

        "goldenrod",
        "darkgoldenrod",
        "saddlebrown",

        "gold",
        "darkorange",
        "chocolate",

        "white",
        "silver",
        "black",
      ]
    }
  },
  components: {
    Color
  },
  mounted: function (){
    document.querySelector('#white').classList.add('c-color-white');
  }
}
</script>

<style scoped lang="scss">
@import './src/style/components/components.colorpicker';
@import './src/style/objects/objects.grid';
@import './src/style/objects/objects.collection';
</style>
