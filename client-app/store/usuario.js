import axios from 'axios'
export const state = () => ({
  username: 'null'
})

export const getters = {
  username(state) {
    return state.username;
  }
}

export const actions = {
  async Login({ }, user) {
    await this.$axios
      .get("api/administrador/login", {
        params: {
          user: user.username,
          password: user.password,
        },
      })
      .then((response) => {
        console.log(response);
        if (response.status == 200) {
          localStorage.setItem('Id', response.data.id);
          localStorage.setItem('Modelo', response.data.modeloSite);
          this.$router.push("painel");
          alert("Bem vindo " + response.data.usuario);
          return true;
        }
        else return null;
      })
      .catch((error) => {
        console.log(error);
      });
  },
  async AutenticatorUser({ commit }) {
    if (process.browser) {
      if (localStorage.getItem('Id') == null) {
        //this.$router.push("/");
      }
      if (localStorage.getItem('Id') != null) {
        //this.$router.push("/");
        let id = localStorage.getItem("Id");
        this.$axios.get("api/administrador",
          {
            params: { id: id }
          })
          .then(response => {
            commit("SET_USER", response.data)
          })
          .catch(error => {
            console.log(error);
          })
      }
    }
  }
}
export const mutations = {
  SET_USER(state, user) {
    state.username = {};
    state.username.nome = user.usuario;
    state.username.id = user.id;
  },
}