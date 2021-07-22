import axios from 'axios'
export const state = () => ({
    paginas: null,
})

export const getters = {
    paginas(state) {
        return state.paginas;
    },
}

export const actions = {
    getPaginas({ commit }) {
        let config = {
            params:{
                idAdmin:1
            }
        }
        return this.$axios.get('paginas/GetAllPagesAndComponents', config)
            .then((response) => {
                if(response.data){
                    response.data.sort(function (pag1, pag2) {
                        return pag1.ordem - pag2.ordem;
                    })
            commit('SET_PAGINAS', response.data);
                }
            })
            .catch(err => {
                console.log("paginas.js: " + err);
            });
    },
    salvarAlteracoes({ state }) {
        return this.$axios.put("Paginas/updatePaginas", state.paginas)
            .then(response => {
                console.log(response);
            })
            .catch(error => {
                console.log(error);
            })

    }
}

export const mutations = {
    SET_PAGINAS(state, paginas) {
        state.paginas = paginas;
    },
    async REORDER_PAGINAS(state, paginas) {
        for (let index = 0; index < paginas.length; index++) {
            paginas[index].ordem = index + 1;
        }
        state.paginas = paginas;

    },
    DESATIVA_PAGINAS(state, pagina) {
        let index = state.paginas.findIndex(pag => pag.id == pagina.id);
        state.paginas[index] = pagina;
        state.paginas[index].ativa = !state.paginas[index].ativa;
    }
}
