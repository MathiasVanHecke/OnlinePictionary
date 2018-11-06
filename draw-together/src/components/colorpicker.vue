<template>
  <div class="c-colorpicker o-grid o-collection">

    <color v-for="color in colors" :key="color" :color="color"></color>

  </div>
</template>

<script>
import color from '@/components/color.vue';

export default {
  name: 'colorpicker',
  data() {
    return { 
      colors : [
        "salmon",
        "red",
        "firebrick",

        "lightpink",
        "hotpink",
        "mediumvioletred",

        "thistle",
        "plum",
        "mediumorchid",

        "lightsteelblue",
        "slateblue",
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

        "yellow",
        "gold",
        "darkorange",

        "white",
        "grey",
        "black",
      ]
    }
  },
  components: {
    color
  }
}
</script>

<style scoped lang="scss">
@import './src/style/components/components.colorpicker';
@import './src/style/objects/objects.grid';
@import './src/style/objects/objects.collection';
</style>
