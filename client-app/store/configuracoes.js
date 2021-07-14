import axios from 'axios'
export const state = () => ({
    configuracoes: null,
})

export const getters = {
    configuracoes(state) {
        return state.configuracoes;
    },
}
export const actions = {
    async getConfiguracoes({ commit }) {
        return this.$axios.get("api/Administrador/getConfiguracoes")
            .then((response) => {
                commit('SET_CONFIGURACOES', response.data[0]);
            })
            .catch(err => {
                console.log(err);
            });
    },
}

export const mutations = {
    SET_CONFIGURACOES(state, configuracoes) {
        state.configuracoes = configuracoes;
    },
}
