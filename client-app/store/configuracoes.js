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
        return this.$axios.get("Administrador/getConfiguracoes")
            .then((response) => {
                commit('SET_CONFIGURACOES', response.data);
            })
            .catch(err => {
                console.log(err);
            });
    },
    async putRodape({ commit }, config) {
        if (config.file != null) {
            
            await this.$axios.post("Imagem/PostImage",config.file)
            .then(reponse=>{
                console.log(response);
                alert("Configurações do rodapé atuailizadas com sucesso");
            })
            .catch(error=>{
                console.log(error);
            })

        }
        this.$axios.put("Administrador/configureRodape", config.rodape)
            .then(response => {
                console.log(response.data);
            })
            .catch(error => {
                console.log(error);
            });
    },
    putContato({ commit }, config) {
        this.$axios.put("Administrador/configureContato", config.contato)
            .then(response => {
                console.log(response.data);
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
