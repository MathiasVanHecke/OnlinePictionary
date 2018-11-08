<template>
  <div class="c-drawing">
      <canvas ref="canvas" id="canvas" 
              width="800" height="600"
              v-on:mousedown="start($event)"
              v-on:mousemove="middle($event)"
              v-on:mouseout="stop"
              v-on:mouseup="stop"
              v-on:touchstart.prevent="start($event)"
              v-on:touchmove.prevent="middle($event)"
              v-on:touchend.prevent="stop">
      </canvas>
      <canvas ref="canxxs" id="canxxs" 
              width="400" height="300"
              ></canvas>
  </div>
</template>

<script>
export default {
  name: 'drawing',
  data: function () {
    return {
        ctx : null,
        cts : null,
        prevX : 0, 
        prevY : 0,
        currX : 0, 
        currY : 0,
        c : "black",
        b : 2,
        isTouch : false,
        isDrawing : false,
        isDot : false,
        isEnabled : true,
    }
  },
  methods: {
    //event handelers
    start : function(e, touch) {
      if (this.isEnabled){
        this.c = this.$store.getters.getPickedColor;
        this.b = this.$store.getters.getPickedBrush;
        if (touch){ this.isTouch = true }
        else { this.isTouch = false }
        this.getXY(e);
        this.isDrawing = true;
        this.isDot = true;
        if (this.isDot) {
          this.drawdot();
          this.isDot = false;
        }
      }
    },
    middle : function(e) {
      if (this.isEnabled){
        if (this.isDrawing) {
            this.getXY(e);
            this.draw();
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
      if (this.isTouch) {
        this.currX = e.changedTouches[0].pageX;
        this.currY = e.changedTouches[0].pageY;
      }
      else {
        this.currX = e.clientX - e.srcElement.offsetLeft;
        this.currY = e.clientY - e.srcElement.offsetTop;
      }
    },

    //drawing code:
    //also call in receivers
    erase : function() {
      this.ctx.clearRect(0, 0, this.$refs.canvas.clientWidth, this.$refs.canvas.clientHeight);
      this.cts.clearRect(0, 0, this.$refs.canxxs.clientWidth, this.$refs.canxxs.clientHeight);
    },
    draw: function() {
        this.drawdot();
        this.drawline();
        this.drawdot();
    },
    drawdot: function() {
        this.ctx.beginPath();
        this.ctx.fillStyle = this.c;
        this.ctx.arc(this.currX, this.currY, this.b/2 , 0, 2 * Math.PI);
        this.ctx.fill();
        this.ctx.closePath();
    },
    drawline: function(){
        this.ctx.beginPath();
        this.ctx.moveTo(this.prevX, this.prevY);
        this.ctx.lineTo(this.currX, this.currY);
        this.ctx.strokeStyle = this.c;
        this.ctx.lineWidth = this.b;
        this.ctx.stroke();
        this.ctx.closePath();
    }
  },
  mounted: function() {
    this.ctx = this.$refs.canvas.getContext("2d");
    this.cts = this.$refs.canxxs.getContext("2d");
    this.$root.$on('erasecanvas', () => { this.erase(); });
    this.$root.$on('draw', (c, b, currX, currY, prevX, prevY) => { 
      this.c = c;
      this.b = b;
      this.currX = currX;
      this.currY = currY;
      this.prevX = prevX;
      this.prevY = prevY;
      this.draw();
    });
    this.$root.$on('drawdot', (c, b, currX, currY) => { 
      this.c = c;
      this.b = b;
      this.currX = currX;
      this.currY = currY;
      this.drawdot(); 
    });
    this.$root.$on('enable',  () => { this.isEnabled = true  });
    this.$root.$on('disable', () => { this.isEnabled = false });
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.drawing';
</style>
