<template>
  <div class="c-waiting o-container">
    <memberbar/>
    <HelloWorld msg="Ahhh... the waiting page"/>
  </div>
</template>

<script>
// @ is an alias to /src
import appheader from '@/components/appheader.vue'
import memberbar from '@/components/memberbar.vue'
import HelloWorld from '@/components/HelloWorld.vue'

export default {
  name: 'waiting',
  components: {
    appheader,
    memberbar,
    HelloWorld,
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/objects/objects.container';
</style>