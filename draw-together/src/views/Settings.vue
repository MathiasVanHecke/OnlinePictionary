<template>
  <div class="home">
    <HelloWorld msg="This is your settings page"/>
  </div>
</template>

<script>
// @ is an alias to /src
import appheader from '@/components/appheader.vue'
import HelloWorld from '@/components/HelloWorld.vue'

export default {
  name: 'settings',
  components: {
    HelloWorld,
    appheader
  }
}
</script>
