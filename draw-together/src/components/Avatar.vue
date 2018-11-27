<template>
    <div v-if="canShrink" class="c-chat-member"></div>
    <div v-else class="c-member-avatar"></div>
</template>

<script>
export default {
  name: 'Avatar',
  props: {
    color: String,
    canShrink : Boolean,
  },
  mounted: function (){
    this.$el.style.backgroundColor = this.color;
  }
}
</script>

<style scoped lang="scss">
  @import './src/style/components/components.chat';
  @import './src/style/components/components.memberbar';
</style>
