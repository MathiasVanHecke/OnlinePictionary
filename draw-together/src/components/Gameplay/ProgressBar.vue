<template>
    <div class="c-bar c-bar-progress">
        <div id="progress" class="c-progress"></div>
    </div>
</template>

<script>
export default {
  name: 'ProgressBar',
  data() {
      return {
          exe : null,
          stopped : false,
      }
  },
  methods: {
      start : function(seconds) {
        let that = this;
        let width = 100;
        this.exe = setInterval(frame, 20);
        function frame() {
            if (width <= 0) {
                if(!that.stopped){
                    if (that.$store.getters.getHost) {
                        that.$store.getters.getConnection.invoke("Stop", that.$store.getters.getRoomkey);
                    }
                    that.stopped = true;
                }
            }
            else {
                width = width - (100/seconds/50);
                that.$el.children[0].style.width = width + '%';
            }
        }
      },
      stop : function () {
        console.log("truestop");
        clearInterval(this.exe);
        this.stopped = false;
      }
    },
  mounted: function() {
    this.$store.getters.getConnection.on('Start', (seconds) => { 
        this.start(seconds); 
    });
    this.$store.getters.getConnection.on('Stop', () => { this.stop(); });
    this.$root.$on('sendguess', function(){
        let seconds = document.querySelector('#progress');
        let score = parseFloat(seconds.style.width);
        this.$store.getters.getConnection.invoke("Guessed", this.$store.getters.getRoomkey, this.$store.getters.getMyName, score);
    });
  },
  destroyed: function() {
    this.$store.getters.getConnection.off('Start');
    this.$store.getters.getConnection.off('Stop');
    this.$root.$off('sendguess');
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.bar';
@import './src/style/components/components.chatholder';
</style>
