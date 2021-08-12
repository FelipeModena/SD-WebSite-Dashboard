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
        let idAdmin;
        if(process.browser){
            idAdmin=localStorage.getItem("Id")
        }
        return this.$axios.get("api/Administrador/getConfiguracoes",{
            params: {
              id: idAdmin,
            },
          })
            .then((response) => {
                commit('SET_CONFIGURACOES', response.data);
            })
            .catch(err => {
                console.log(err);
            });
    },
    async putRodape({ commit }, config) {
        this.$axios.put("api/Administrador/configureRodape", config.rodape)
            .then(response => {
                alert("Configurações do Contato atuailizadas com sucesso");
            })
            .catch(error => {
                console.log(error);
            });
    },
    putContato({ commit }, config) {
        this.$axios.put("api/Administrador/configureContato", config.contato)
            .then(response => {
                alert("Configurações do Contato atuailizadas com sucesso");
            })
            .catch(error => {
                console.log(error);
            });
    }

}

export const mutations = {
    SET_CONFIGURACOES(state, configuracoes) {
        state.configuracoes = {};
        state.configuracoes.contato = configuracoes.contato;
        state.configuracoes.rodape = configuracoes.rodape;
    },
}
