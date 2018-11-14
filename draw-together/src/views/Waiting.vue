<template>
  <div class="c-waiting o-container">
    <MemberBar/>
    <HelloWorld msg="Ahhh... the waiting page"/>
  </div>
</template>

<script>
import AppHeader from '@/components/AppHeader.vue'
import MemberBar from '@/components/MemberBar.vue'
import HelloWorld from '@/components/HelloWorld.vue'

export default {
  name: 'Waiting',
  components: {
    AppHeader,
    MemberBar,
    HelloWorld,
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/objects/objects.container';
</style>