<template>
  <div class="waiting">
    <HelloWorld msg="Ahhh... the waiting page"/>
  </div>
</template>

<script>
// @ is an alias to /src
import appheader from '@/components/appheader.vue'
import HelloWorld from '@/components/HelloWorld.vue'

export default {
  name: 'waiting',
  components: {
    HelloWorld,
    appheader
  }
}
</script>
