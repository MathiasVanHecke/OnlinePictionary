<template>
  <div class="landing">
    <LoginForm/>
  </div>
</template>

<script>
import LoginForm from '@/components/LoginForm.vue';

export default {
  name: 'Landing',
  components: {
    LoginForm
  }
}
</script>
