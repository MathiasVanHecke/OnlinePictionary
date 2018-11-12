<template>
    <div class="c-bar c-bar-progress">
        <div ref="progress" class="c-progress"></div>
    </div>
</template>

<script>
export default {
  name: 'ProgressBar',
  methods: {
      start : function(seconds) {
        let that = this;
        let width = 100;
        let exe = setInterval(frame, 20);
        function frame() {
            if (width <= 0) { clearInterval(exe); } 
            else {
                width = width - (100/seconds/50);
                that.$el.children[0].style.width = width + '%';
            }
        }
      }
    },
  mounted: function() {
      this.$root.$on('start', (seconds) => { this.start(seconds); });
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.bar';
@import './src/style/components/components.chatholder';
</style>
