<template>
  <input v-on:click="erase" type="button" class="c-trashcan" value="🗑️" id="clr">
</template>

<script>
export default {
  name: 'Trashcan',
  methods : {
    erase : function () {
      this.$store.getters.getConnection.invoke('erase', this.$store.getters.getRoomkey);
    }
  }
}
</script>

<style scoped lang="scss">
@import './src/style/components/components.trashcan';
</style>
