<template>
  <div class="c-game o-container o-grid">
    <div class="c-members o-grid">
        <div class="c-member">
            <div class="c-member-avatar"></div>
            <span>
                <p class="c-member-name">Céline</p>
                <p class="c-member-score">12440</p>
            </span>
        </div>
        <div class="c-member">
            <div class="c-member-avatar"></div>
            <span>
                <p class="c-member-name">Mathias</p>
                <p class="c-member-score">1250</p>
            </span>
        </div>
        <div class="c-member">
            <div class="c-member-avatar"></div>
            <span>
                <p class="c-member-name">Nico</p>
                <p class="c-member-score">2360</p>
            </span>
        </div>
        <div class="c-member">
            <div class="c-member-avatar"></div>
            <span>
                <p class="c-member-name">Gaëtan</p>
                <p class="c-member-score">3610</p>
            </span>
        </div>
        <div class="c-member">
            <div class="c-member-avatar"></div>
            <span>
                <p class="c-member-name">Jens</p>
                <p class="c-member-score">4250</p>
            </span>
        </div>
        <div class="c-member">
            <div class="c-member-avatar"></div>
            <span>
                <p class="c-member-name">Bauke</p>
                <p class="c-member-score">1480</p>
            </span>
        </div>
        <div class="c-member">
            <div class="c-member-avatar"></div>
            <span>
                <p class="c-member-name">Piemel</p>
                <p class="c-member-score">20</p>
            </span>
        </div>
    </div>
    <div class="o-grid c-game-row">
        <drawing/>
        <controls/>
        <chatholder/>
    </div>
  </div>
</template>

<script>
// @ is an alias to /src
import controls from '@/components/controls.vue';
import drawing from '@/components/drawing.vue';
import chatholder from '@/components/chatholder.vue';

export default {
  name: 'game',
  components: {
    controls,
    drawing,
    chatholder
  }
}
</script>

<style lang="scss" scoped>
@import './src/style/objects/objects.container';
@import './src/style/objects/objects.grid';
@import './src/style/components/components.bar';

.c-game {
    max-width: 1268px;
    grid-template-rows: repeat(2, auto);
    grid-template-columns: auto;
    grid-gap: 1.5em;
}

.c-members {
    max-width: 1018px;
    grid-template-columns: repeat(7, 1fr);
    grid-template-rows: auto;
}

.c-member {
    display: flex;
    flex-flow: row nowrap;
    align-items: center;
}

.c-member-avatar {
    width: 2.5em;
    height: 2.5em;
    margin-right: .75rem;
    border-radius: 50%;
    background-color: thistle;
}

.c-member-score {
    margin-top: .2rem;
    text-align: left;
    color: steelblue;
}

.c-game-row {
    grid-template-columns: 800px 1fr 300px;
    grid-template-rows: auto;
    max-width: 1268px;
}

</style>
