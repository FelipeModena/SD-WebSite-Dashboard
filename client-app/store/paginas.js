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
        let idAdmin;
        if (process.browser) {
            idAdmin = localStorage.getItem("Id")
        }
        let config = {
            params: {
                idAdmin: idAdmin
            }
        }
        return this.$axios.get('api/paginas/GetAllPagesAndComponents', config)
            .then((response) => {
                if (response.data) {
                    response.data.sort(function (pag1, pag2) {
                        return pag1.ordem - pag2.ordem;
                    })
                    console.log("paginas com sucesso");
                    commit('SET_PAGINAS', response.data);
                }
            })
            .catch(err => {
                console.log("paginas.js: " + err);
            });
    },
    salvarAlteracoes({ state }) {
        return this.$axios.put("api/Paginas/updatePaginas", state.paginas)
            .then(response => {
                alert("Páginas atualizadas com sucesso")
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
    },
    DESATIVA_COMPONENTE(state,componente) {
        let indexPagina = state.paginas.findIndex(pag => pag.id == componente.paginaId);
        let indexComponente =state.paginas[indexPagina].componente.findIndex(comp => comp.id == componente.comp.id);
        state.paginas[indexPagina].componente[indexComponente] = componente.comp
        state.paginas[indexPagina].componente[indexComponente].ativo = !state.paginas[indexPagina].componente[indexComponente].ativo;

    }
}
