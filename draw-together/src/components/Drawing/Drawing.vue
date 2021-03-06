<template>
  <div class="c-drawing">
      <canvas v-show="!isSmall" ref="canvas" id="canvas" 
              width="800" height="600"
              v-on:mousedown="start($event)"
              v-on:mousemove="middle($event)"
              v-on:mouseout="stop"
              v-on:mouseup="stop"
              v-on:touchstart.prevent="start($event)"
              v-on:touchmove.prevent="middle($event)"
              v-on:touchend.prevent="stop">
      </canvas>
      <canvas v-show="isSmall" ref="canxxs" id="canxxs" 
              width="400" height="300"
              v-on:mousedown="start($event)"
              v-on:mousemove="middle($event)"
              v-on:mouseout="stop"
              v-on:mouseup="stop"
              v-on:touchstart.prevent="start($event)"
              v-on:touchmove.prevent="middle($event)"
              v-on:touchend.prevent="stop"
              ></canvas>
  </div>
</template>

<script>
export default {
  name: 'Drawing',
  data: function () {
    return {
        prevX : 0, 
        prevY : 0,
        currX : 0, 
        currY : 0,
        isSmall : false,
        isTouch : false,
        isDrawing : false,
        isDot : false,
    }
  },
  computed: {
    c: function () { return this.$store.getters.getPickedColor; },
    b: function () { return this.$store.getters.getPickedBrush; },
    ctx: function() { return this.$refs.canvas.getContext("2d"); },
    cts: function() { return this.$refs.canxxs.getContext("2d"); },
    isEnabled: function() { return this.$store.getters.getDrawing; },
  },
  methods: {
    //event handelers
    start : function(e) {
      if (this.isEnabled){
        this.getXY(e);
        this.isDrawing = true;
        this.isDot = true;
        if (this.isDot) {
          this.senddrawdot();
          this.isDot = false;
        }
      }
    },
    middle : function(e) {
      if (this.isEnabled){
        if (this.isDrawing) {
            this.getXY(e);
            this.senddraw();
        }
      }
    },
    stop : function(){
      this.isDrawing = false;
    },

    //locatiebepaler
    getXY : function(e){
      this.prevX = this.currX;
      this.prevY = this.currY;
      if (e.changedTouches != undefined) {
        this.currX = e.changedTouches[0].pageX - e.srcElement.offsetLeft;
        this.currY = e.changedTouches[0].pageY - e.srcElement.offsetTop;
      }
      else {
        this.currX = e.clientX - e.srcElement.offsetLeft + e.view.window.scrollX;
        this.currY = e.clientY - e.srcElement.offsetTop + e.view.window.scrollY;
      }
      if (this.isSmall) {
        this.currX *= 2;
        this.currY *= 2;
      }
    },

    //invokers
    senddraw: function() {
      this.$store.getters.getConnection.invoke(
        'Draw', 
        this.$store.getters.getRoomkey, 
        this.$store.getters.getPickedColor, 
        this.$store.getters.getPickedBrush, 
        this.currX, this.currY, this.prevX, this.prevY)
    },
    senddrawdot: function() {
      this.$store.getters.getConnection.invoke(
        'DrawDot', 
        this.$store.getters.getRoomkey, 
        this.$store.getters.getPickedColor, 
        this.$store.getters.getPickedBrush, 
        this.currX, this.currY)
    },

    //drawing code:
    //also call in receivers
    erase : function() {
      this.ctx.clearRect(0, 0, this.$refs.canvas.width, this.$refs.canvas.height);
      this.cts.clearRect(0, 0, this.$refs.canxxs.width, this.$refs.canxxs.height);
    },
    draw: function(c, b, currX, currY, prevX, prevY) {
        this.drawdot(c, b, currX, currY);
        this.drawline(c, b, currX, currY, prevX, prevY);
        this.drawdot(c, b, currX, currY);
    },
    drawdot: function(c, b, currX, currY) {
        this.ctx.beginPath();
        this.ctx.fillStyle = c;
        this.ctx.arc(currX, currY, this.b/2 , 0, 2 * Math.PI);
        this.ctx.fill();
        this.ctx.closePath();

        this.cts.beginPath();
        this.cts.fillStyle = c;
        this.cts.arc(currX/2, currY/2, b/2/2 , 0, 2 * Math.PI);
        this.cts.fill();
        this.cts.closePath();
    },
    drawline: function(c, b, currX, currY, prevX, prevY){
        this.ctx.beginPath();
        this.ctx.moveTo(prevX, prevY);
        this.ctx.lineTo(currX, currY);
        this.ctx.strokeStyle = c;
        this.ctx.lineWidth = b;
        this.ctx.stroke();
        this.ctx.closePath();
        
        this.cts.beginPath();
        this.cts.moveTo(prevX/2, prevY/2);
        this.cts.lineTo(currX/2, currY/2);
        this.cts.strokeStyle = c;
        this.cts.lineWidth = b/2;
        this.cts.stroke();
        this.cts.closePath();
    },
    resizer : function(){ 
      if( window.innerWidth < 1150 ) this.isSmall = true; 
      else this.isSmall = false; 
    },
  },
  mounted: function() {
    if( window.innerWidth < 1150 ) this.isSmall = true; 
    window.addEventListener('resize', this.resizer);
    this.$store.getters.getConnection.on('Erase', () => { this.erase(); });
    this.$store.getters.getConnection.on('Draw', (c, b, currX, currY, prevX, prevY) => { 
      this.draw(c, b, currX, currY, prevX, prevY);
    });
    this.$store.getters.getConnection.on('DrawDot', (c, b, currX, currY) => { 
      this.drawdot(c, b, currX, currY);
    });
    this.$store.getters.getConnection.on('Stop', () => {
      this.isDrawing = false;
      this.erase();
    });
  },
  destroyed: function(){
    window.removeEventListener('resize', this.resizer);
    this.$store.getters.getConnection.off('Erase');
    this.$store.getters.getConnection.off('Draw');
    this.$store.getters.getConnection.off('DrawDot');
    this.$store.getters.getConnection.off('Stop');
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.drawing';
</style>
