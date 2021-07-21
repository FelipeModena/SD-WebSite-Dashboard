import axios from 'axios'
export const state = () => ({
    username: "Usuario"
})

export const getters = {
    username(state){
        return state.username;
    }
}

export const actions = {
    async Login({},user){
        this.$axios
        .get("administrador/login", {
          params: {
            user:user.username,
            password: user.password,
          },
        })
        .then((response) => {
          console.log(response);
          if (response.status == 200) {
            localStorage.setItem('adminId',response.data.id);
            this.$router.push("painel");
            alert("Bem vindo "+ response.data);
          }
        })
        .catch((error) => {
          console.log(error);
        });
    }
}