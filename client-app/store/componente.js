export const actions = {
   async createComponente() {
      return   {
            "imgUrl": "",
            "texto": "",
            "compatibilidade": '',
            "ordenacao": 0,
            "id": 0
      };
    },

    async updateComponente({},componente){
      await this.$axios
      .put("api/Componentes/updateComponente", componente)
      .then((response) => {
        return response.data.msg;
      })
      .catch((error) => {
        alert("Ocorreu um erro ao salvar o componente, tente novamente");
        console.log(error);
      });
  }
    }