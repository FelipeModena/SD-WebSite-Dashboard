<template>
  <div class="w-50 border container center bg-secondary p-5 mt-4">
    <img
      class="ml-4 btn"
      src="~/assets/icones/shark-mascote-positivo.png"
      width="400px"
      alt=""
    />
    <div id="index-container-caixa-login">
      <label for="index-input-user">Usuario</label>
    <span class="text-danger" v-if="erroLogin==true" >Usuario nâo encontrado</span>
      <input v-model="user" type="text" id="index-input-user" @click="erroLogin=false"/>
      <label for="index-input-senha">Senha</label>
      <input v-model="password" type="password" id="index-input-senha" />
      <button class="btn btn-success mt-5" @click="logar">Logar</button>
    </div>
  </div>
</template>

<script>
import { mapActions } from "vuex";
export default {
  layout: "login",
  data() {
    return {
      user: "",
      password: "",
      erroLogin:false,
    };
  },
  methods: {
    ...mapActions({
      login:"usuario/Login"
    }),
    async logar() {
      let retorno = await this.login({username:this.user,password:this.password});
      if(retorno ==null){
        this.erroLogin=true
      }
    },
  },
};
</script>
<style>
#index-container-caixa-login {
  display: grid;
  margin: 0 auto;
}
#index-container-caixa-login label {
  margin-top: 16px;
}
</style>
