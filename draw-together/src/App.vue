<template>
  <div id="app">
    <appheader/>
    <router-view/>
  </div>
</template>

<script>
import appheader from '@/components/AppHeader.vue'

export default {
  components: {
    appheader
  },
  mounted() {
    this.$store.dispatch("startConnection");
  }
}
</script>

<style lang="scss">
@import './src/style/base';
</style>
