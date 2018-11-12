<template>
    <div class="c-bar c-bar-progress">
        <div ref="progress" class="c-progress"></div>
    </div>
</template>

<script>
export default {
  name: 'ProgressBar',
  data() {
      return {
          exe : null
      }
  },
  methods: {
      start : function(seconds) {
        let that = this;
        let width = 100;
        this.exe = setInterval(frame, 20);
        function frame() {
            if (width <= 0) { this.$root.$emit('stop'); } 
            else {
                width = width - (100/seconds/50);
                that.$el.children[0].style.width = width + '%';
            }
        }
      },
      stop : function () {
        clearInterval(this.exe);
      }
    },
  mounted: function() {
    this.$root.$on('start', (seconds) => { this.start(seconds); });
    this.$root.$on('stop', () => { this.stop(); });
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.bar';
@import './src/style/components/components.chatholder';
</style>
