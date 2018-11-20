import Vue from 'vue';
import VueI18n from 'vue-i18n';

Vue.use(VueI18n);

export default new VueI18n({
    locale: 'en',
    messages: {
        en: {
            register: 'Register',
            terms: 'I agree with the terms and conditions.',
            already: 'Already have an account?',
            notyet: 'Don\'t have an account yet?',
            start: 'Start a new game',
            or: 'or',
            join: "Join a room",
            newgame : "New game",
            joincode: "People can join with this code:",
            ready : "Ready to play:",
            guessed : "guessed the word!",
        },
        nl: {
            register: 'Registreer',
            terms: 'Ik ga akkoord met de algemene voorwaarden.',
            already: 'Heb je al een account?',
            notyet: 'Heb je nog geen account?',
            start: 'Start een nieuw spel',
            or: 'of',
            join: "Doe mee met een spel",
            newgame : "Nieuw spel",
            joincode: "Mensen kunnen meedoen met deze code:",
            ready : "Klaar om te spelen:",
            guessed : "raadde het woord!",
        },
    }
});