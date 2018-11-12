<template>
  <div class="c-game-master c-hidden">
    <h3>Next up: {{guesser}} is drawing...</h3>
  </div>
</template>

<script>
export default {
  name: 'GameMaster',
  data() {
    return {
      guesser : "",
    }
  },
  methods: {
    show : function() {
      this.$el.classList.remove('c-hidden');
      setTimeout(this.hide, 3000);
    },
    hide : function() {
      this.$el.classList.add('c-hidden');
      this.$root.$emit('start', 60);
    }
  },
  mounted: function() {
    this.$root.$on('drafted', (member) => { this.guesser = member; this.show(); });
  }
}
</script>

<style scoped lang="scss">
@import './src/style/components/components.gamemaster';
</style>
