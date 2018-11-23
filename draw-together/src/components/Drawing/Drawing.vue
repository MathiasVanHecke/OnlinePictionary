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
        this.currX = e.changedTouches[0].pageX - e.srcElement.offsetLeft + e.srcElement.scrollHeight;
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

    //invokers
    senddraw: function() {
      console.log("Invoke draw");
      this.$store.getters.getConnection.invoke('Draw', this.$store.getters.getRoomkey, this.c, this.b, this.currX, this.currY, this.prevX, this.prevY)
    },
    senddrawdot: function() {
      console.log("Invoke drawdot");
      this.$store.getters.getConnection.invoke('DrawDot', this.$store.getters.getRoomkey, this.c, this.b, this.currX, this.currY)
    },

    //drawing code:
    //also call in receivers
    erase : function() {
      this.ctx.clearRect(0, 0, this.$refs.canvas.clientWidth, this.$refs.canvas.clientHeight);
      this.cts.clearRect(0, 0, this.$refs.canxxs.clientWidth, this.$refs.canxxs.clientHeight);
    },
    draw: function(c, b) {
        this.drawdot(c, b, this.currX, this.currY);
        this.drawline(c, b, this.currX, this.currY, this.prevX, this.prevY);
        this.drawdot(c, b, this.currX, this.currY);
    },
    drawdot: function(c, b, currX, currY) {
        this.ctx.beginPath();
        this.ctx.fillStyle = this.c;
        this.ctx.arc(currX, currY, this.b/2 , 0, 2 * Math.PI);
        this.ctx.fill();
        this.ctx.closePath();
    },
    drawline: function(c, b, currX, currY, prevX, prevY){
        this.ctx.beginPath();
        this.ctx.moveTo(prevX, prevY);
        this.ctx.lineTo(currX, currY);
        this.ctx.strokeStyle = this.c;
        this.ctx.lineWidth = this.b;
        this.ctx.stroke();
        this.ctx.closePath();
    }
  },
  mounted: function() {
    if( window.innerWidth < 1350 ) this.isSmall = true; 
    window.addEventListener('resize', () => { 
      if( window.innerWidth < 1350 ) this.isSmall = true; 
      else this.isSmall = false; 
      });
    this.$store.getters.getConnection.on('erase', () => { this.erase(); });
    this.$store.getters.getConnection.on('draw', (c, b, currX, currY, prevX, prevY) => { 
      this.currX = currX;
      this.currY = currY;
      this.prevX = prevX;
      this.prevY = prevY;
      this.draw(c, b);
    });
    this.$store.getters.getConnection.on('drawdot', (c, b, currX, currY) => { 
      this.currX = currX;
      this.currY = currY;
      this.drawdot(c, b, this.currX, this.currY);
    });
    this.$store.getters.getConnection.on('Drafted', (member) => {
      if(member == this.$store.getters.getMyName) {this.isEnabled = true; } 
    });
    this.$store.getters.getConnection.on('Stop', () => { 
      this.isEnabled = false; 
      this.erase();
    });
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/components/components.drawing';
</style>
