<template>
    <div class="c-memberbar o-grid">
        <div v-for="member in members" :key=member.id class="c-member">
            <div class="c-member-avatar"></div>
            <span>
                <p class="c-member-name">{{member.name}}</p>
                <p class="c-member-score">{{member.score}}</p>
            </span>
        </div>
    </div>
</template>

<script>
export default {
  name: 'MemberBar',
  data() {
    return {
        members: [
            {
                id: 1,
                name: "Céline",
                score: 12240,
            },
            {
                id: 2,
                name: "Mathias",
                score: 2260,
            },
            {
                id: 3,
                name: "Jens",
                score: 8240,
            },
            {
                id: 4,
                name: "Nico",
                score: 6480,
            },
            {
                id: 5,
                name: "Gaetan",
                score: 1250,
            },
            {
                id: 6,
                name: "Bauke",
                score: 2440,
            },
            {
                id: 7,
                name: "Piemel",
                score: 50,
            },
        ]
    }
  },
}
</script>

<style lang="scss" scoped>
@import './src/style/objects/objects.grid';
@import './src/style/components/components.memberbar';

</style>
