<template>
  <div class="o-container">
    <HelloWorld msg="The login page"/>
  </div>
</template>

<script>
// @ is an alias to /src
import HelloWorld from '@/components/HelloWorld.vue'

export default {
  name: 'login',
  components: {
    HelloWorld,
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/objects/objects.container';
</style>