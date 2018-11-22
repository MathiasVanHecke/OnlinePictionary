<template>
  <div class="landing">
    <LoginForm v-if="loaded"/>
    <img v-else class="c-loading-image" src="/loading.png"> 
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

// <style lang="scss" scoped>
//   .c-loading-image{
//     max-width: 256px;
//     margin: 0 auto;
//     animation: pop 800ms ease;
//   }

//   @keyframes pop{
//     0% {transform: scale(0);}
//     50%  {transform: scale(1.1);}
//     100% {transform: scale(1);}
//   }
</style>
