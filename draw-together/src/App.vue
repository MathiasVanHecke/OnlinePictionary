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
  }
}
</script>

<style lang="scss">
@import './src/style/base';
</style>
