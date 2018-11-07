<template>
    <div class="c-memberbar o-grid">
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
</template>

<script>
export default {
  name: 'memberbar'
}
</script>

<style lang="scss" scoped>
@import './src/style/objects/objects.grid';

.c-memberbar {
    max-width: 1018px;
    grid-template-columns: repeat(7, 1fr);
    grid-template-rows: auto;
}

.c-member {
    @if 8px > 10px {
        color: seagreen;
    }

    padding-right: 2em;
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
</style>
