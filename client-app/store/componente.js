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
        alert(response.data.msg);
        console.log(response);
      })
      .catch((error) => {
        alert("Ocorreu um erro ao salvar o componente, tente novamente");
        console.log(error);
      });
  }
    }