<template>
  <input v-on:click="emiterase" type="button" class="c-trashcan" value="🗑️" id="clr">
</template>

<script>
export default {
  name: 'trashcan',
  methods : {
    emiterase : function () {
      this.$root.$emit('erasecanvas');
    }
  }
}
</script>

<style scoped lang="scss">
@import './src/style/components/components.trashcan';
</style>
