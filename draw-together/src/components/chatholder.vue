<template>
    <div class="c-chat-holder js-chat-holder">
        <div class="c-word">______</div>
        <div class="c-bar c-bar-guess">
            <div class="c-guess">
                <div class="c-guess-done"></div>
                <div class="c-guess-done"></div>
            </div>
        </div>
        <Chat/>
        <div class="c-bar c-bar-progress"></div>
        <div class="c-progress"></div>
        <input v-model="guess" placeholder="guess" id="guess" class="c-chat-input">
    </div>
</template>

<script>
// @ is an alias to /src
import Chat from '@/components/Chat.vue';

export default {
  name: 'ChatHolder',
  components: {
    Chat
  },
  data() {
    return {
      guess : "",
    }
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/objects/objects.container';
@import './src/style/components/components.bar';

.c-chat-holder {
    background-color: white;

    display: grid;
    grid-template-rows: auto .25rem 1fr .25rem auto;

    border-radius: .75rem;

    width: 300px;
    height: 600px;
}

.c-word {
    background-color: lightgray;
    
    border: none;
    border-radius: .75rem .75rem 0 0;
    height: 3rem;

    text-align: center;
    line-height: 3rem;
    font-size: 200%;
    text-transform: uppercase;
    letter-spacing: .1em;
}

.c-guess {
    width: 100%;
    height: 100%;
    
    display: grid;
    grid-template-rows: auto;
    grid-template-columns: repeat(7, 1fr);
}

.c-guess-done {
    width: 100%;
    height: 100%;
    background-color: whitesmoke;
}

.c-progress {
    width: 15%;
    height: 100%;
    background: whitesmoke;
    grid-row: 4;
    grid-column: 1;
    justify-self: end;
}

.c-chat-input {
    background-color: lightgray;
    
    border: none;
    border-radius: 0 0 .75rem .75rem;
    height: 3rem;

    text-align: center;
    font-family: inherit;
    font-size: 100%;

    transition: 300ms ease-in-out;
}

.c-chat-input:focus {
    background-color: #ded3de;
}

</style>
