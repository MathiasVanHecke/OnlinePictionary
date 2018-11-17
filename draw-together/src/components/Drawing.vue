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
        isEnabled : false,
    }
  },
  computed: {
    c: function () { return this.$store.getters.getPickedColor; },
    b: function () { return this.$store.getters.getPickedBrush; },
    ctx: function() { return this.$refs.canvas.getContext("2d"); },
    cts: function() { return this.$refs.canxxs.getContext("2d"); },
  },
  methods: {
    //event handelers
    start : function(e) {
      if (this.isEnabled){
        this.getXY(e);
        this.isDrawing = true;
        this.isDot = true;
        if (this.isDot) {
          this.drawdot(this.ctx, this.currX, this.currY);
          this.drawdot(this.cts, this.currX/2, this.currY/2);
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
      if (e.changedTouches != undefined) {
        this.currX = e.changedTouches[0].pageX - e.srcElement.offsetLeft;
        this.currY = e.changedTouches[0].pageY - e.srcElement.offsetTop;
      }
      else {
        this.currX = e.clientX - e.srcElement.offsetLeft;
        this.currY = e.clientY - e.srcElement.offsetTop;
      }
      if (this.isSmall) {
        this.currX *= 2;
        this.currY *= 2;
      }
    },

    //drawing code:
    //also call in receivers
    erase : function() {
      this.ctx.clearRect(0, 0, this.$refs.canvas.clientWidth, this.$refs.canvas.clientHeight);
      this.cts.clearRect(0, 0, this.$refs.canxxs.clientWidth, this.$refs.canxxs.clientHeight);
    },
    draw: function() {
        this.drawdot(this.ctx, this.currX, this.currY);
        this.drawline(this.ctx, this.currX, this.currY, this.prevX, this.prevY);
        this.drawdot(this.ctx, this.currX, this.currY);
        this.drawdot(this.cts, this.currX/2, this.currY/2);
        this.drawline(this.cts, this.currX/2, this.currY/2, this.prevX/2, this.prevY/2);
        this.drawdot(this.cts, this.currX/2, this.currY/2);
    },
    drawdot: function(mycanvas, currX, currY) {
        mycanvas.beginPath();
        mycanvas.fillStyle = this.c;
        mycanvas.arc(currX, currY, this.b/2 , 0, 2 * Math.PI);
        mycanvas.fill();
        mycanvas.closePath();
    },
    drawline: function(mycanvas, currX, currY, prevX, prevY){
        mycanvas.beginPath();
        mycanvas.moveTo(prevX, prevY);
        mycanvas.lineTo(currX, currY);
        mycanvas.strokeStyle = this.c;
        mycanvas.lineWidth = this.b;
        mycanvas.stroke();
        mycanvas.closePath();
    }
  },
  mounted: function() {
    if( window.innerWidth < 1350 ) this.isSmall = true; 
    window.addEventListener('resize', () => { 
      if( window.innerWidth < 1350 ) this.isSmall = true; 
      else this.isSmall = false; 
      });
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
    this.$root.$on('drafted', (member) => {
      if(member == this.$store.getters.getMyName) {this.isEnabled = true; } });
    this.$root.$on('stop', () => { 
      this.isEnabled = false; 
      this.erase();
      });
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.drawing';
</style>
