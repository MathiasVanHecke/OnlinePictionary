<template>
  <div class="landing">
    <LoginForm v-if="loaded"/>
  </div>
</template>

<script>
import LoginForm from '@/components/LoginForm.vue';

export default {
  name: 'Landing',
  components: {
    LoginForm
  },
  data() {
    return {
      loaded : true
    }
  }
}
</script>

<style lang="scss" scoped>
</style>
