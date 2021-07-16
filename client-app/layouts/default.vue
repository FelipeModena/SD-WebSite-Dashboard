<template>
  <div id="layout-default-app">
    <header>
      <b-navbar toggleable="lg" variant="faded" type="light" id="layout-default-nav-bar">
        <b-navbar-brand href="#"
          ><img height="50px" src="~/assets/icones/shark-mascote-positivo.png" alt=""
        /></b-navbar-brand>
        <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>
        <b-collapse id="nav-collapse" is-nav>
          <b-navbar-nav class="ml-auto">
            <b-nav-item-dropdown :text="usuario" right>
              <b-dropdown-item @click="deslogar">Sair</b-dropdown-item>
            </b-nav-item-dropdown>
          </b-navbar-nav>
        </b-collapse>
      </b-navbar>
    </header>
    <main class="d-flex">
      <div id="layout-default-side-bar">
        <div
          v-for="(opcao, index) in opcoes"
          :key="index"
          class="px-1 py-5 text-center"
          @click="rotaMenu(opcao.rota, index)"
          :id="'side-menu-opcao-default-' + index"
        >
          <img v-if="index == 0" src="~/assets/icones/icone-menu.svg" alt="" />
          <img v-if="index == 1" src="~/assets/icones/icone-paginas.svg" alt="" />
          <img v-if="index == 2" src="~/assets/icones/configuracoes.png" alt="" />
          <p><strong>{{ opcao.titulo }}</strong></p>
        </div>
      </div>
      <Nuxt />
    </main>
    <footer class="w-100 text-center bg-success py-4">
      <img width="100px" src="~/assets/icones/shark-mascote-positivo.png" alt="" />
      <h5>DashBoard-SharkData</h5>
    </footer>
  </div>
</template>

<script>
import { mapGetters, mapActions } from "vuex";
export default {
  computed: {
    ...mapGetters({
      paginas: "paginas/paginas",
      usuario: "usuario/username",
    }),
  },
  data() {
    return {
      opcoes: [
        { titulo: "Menu", rota: "painel" },
        { titulo: "Paginas", rota: "paginas" },
        { titulo: "Configurações", rota: "configuracoes" },
      ],
    };
  },
  methods: {
    ...mapActions({
      getPaginas: "paginas/getPaginas",
    }),
    verifica() {
      console.log("default: ", this.paginas);
    },
    deslogar() {
      localStorage.removeItem("adminId");
      this.$router.push("/");
    },
    rotaMenu(rota, index) {
      console.log(index);
      for (let i = 0; i < this.opcoes.length; i++) {
        $("#side-menu-opcao-default-" + i).css({ background: "#c3c3c3" });
        }
          $("#side-menu-opcao-default-" + index).css({ background: "#a9a9b5" });
          this.$router.push(rota);
          return;
    },
  },
  created() {
    this.getPaginas();
  },
};
</script>
<style scoped>
#layout-default-nav-bar {
  background: #0f1450;
  color: white !important;
  transition: 0.4s;
}

#layout-default-app {
  background: rgb(217, 217, 238);
}
#layout-default-side-bar {
  height: 1000px;
  width: 200px;
  background: #c3c3c3;
}
#layout-default-side-bar div {
  border: 1px rgb(156, 156, 155) solid;
  transition: 0.4s;
}

#layout-default-side-bar div:hover {
  transition: 0.2s;
  border: 3px rgb(156, 156, 155) solid;
}
</style>
