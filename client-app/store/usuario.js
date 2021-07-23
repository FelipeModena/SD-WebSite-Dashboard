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
    this.$axios
      .get("api/administrador/login", {
        params: {
          user: user.username,
          password: user.password,
        },
      })
      .then((response) => {
        console.log(response);
        if (response.status == 200) {
          localStorage.setItem('adminId', response.data.id);
          this.$router.push("painel");
          alert("Bem vindo " + response.data);
        }
      })
      .catch((error) => {
        console.log(error);
      });
  },
  async AutenticatorUser({ commit }) {
    if (process.browser) {
      if (localStorage.getItem('adminId') == null) {
        //this.$router.push("/");
      }
      if (localStorage.getItem('adminId') != null) {
        //this.$router.push("/");
        let id = localStorage.getItem("adminId");
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