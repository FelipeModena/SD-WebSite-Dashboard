<template>
  <div class="w-100 py-5 px-3">
    <h3>Páginas</h3>
    <div id="paginas-lista-paginas" class="px-2 py-1">
      <b-container>
        <b-row class="border-bottom mt-2 mb-3">
          <b-col
            ><h5><strong>Página</strong></h5>
          </b-col>
          <b-col
            ><h5><strong>Url</strong></h5></b-col
          >
          <b-col><strong>Ação</strong></b-col>
        </b-row>
        <div v-for="(pag, index) in paginasC" :key="index">
          <b-row>
            <b-col
              class="mouse-hover-icone-select hover-primario"
              @click="abreColapse('collapse-componentes-' + pag.nomePagina)"
              ><strong
                ><p>{{ pag.nomePagina }}</p></strong
              >
            </b-col>
            <b-col
              ><p>{{ pag.url }}</p></b-col
            >
            <b-col class="d-flex">
              <img
                width="18px"
                height="18px"
                src="~/assets/icones/editar.png"
                alt=""
                class="mouse-hover-icone-select"
                @click="openModalPaginas(pag)"
              />
              <img
                class="float-right ml-4 mouse-hover-icone-select"
                width="20px"
                height="20px"
                src="~/assets/icones/visualisar-loja-preto.png"
                alt=""
                @click="rotaExternaDaPagina(pag.url)"
              />
            </b-col>
          </b-row>
          <b-collapse
            :id="'collapse-componentes-' + pag.nomePagina"
            class="border border-dark mb-4"
          >
            <b-card>
              <b-row class="cinza-claro">
                <b-col>
                  <p>Componente</p>
                </b-col>
                <b-col>
                  <p>Ação</p>
                </b-col>
              </b-row>
              <b-row
                v-for="(componente, compI) in pag.componente"
                :key="compI"
                class="hover-secundario"
              >
                <b-col>
                  <p>{{ componente.tipoComponente }} <span class="text-danger" v-if="componente.ativo==false"> (desativado)</span></p>
                </b-col>
                <b-col>
                  <img
                    width="18px"
                    height="18px"
                    src="~/assets/icones/editar.png"
                    alt="editar.png"
                    class="mouse-hover-icone-select"
                    @click="editarComponente(pag, componente)"
                /></b-col>
              </b-row>
            </b-card>
          </b-collapse>
        </div>
      </b-container>
    </div>
    <b-modal
      id="modal-pagina-altera"
      :title="'Configuração ' + paginaAuxModal.nomePagina"
      hide-footer
    >
      <div class="configuracoes-forms">
        <label for="modal-pagina-altera-nome-pagina"><strong>Nome pagina</strong></label>
        <input v-model="paginaAuxModal.nomePagina" id="modal-pagina-altera-nome-pagina" />
        <br>
        <label for="modal-pagina-altera-url"><strong>Url</strong></label>
        <input v-model="paginaAuxModal.url" id="modal-pagina-altera-url" />
      </div>
      <div class="mt-4">
        <div class="float-right">
          <button class="btn-cancelar mr-2" @click="modalFormUrl(false)">
            Cancelar
          </button>
          <button class="btn-salvar" @click="modalFormUrl(true)">Salvar</button>
        </div>
      </div>
    </b-modal>
    <ModalTemplate1 ref="modalTemplate1" />
    <ModalTemplate2 ref="modalTemplate2" />
    <ModalTemplate3 ref="modalTemplate3" />
  </div>
</template>

<script>
import { mapGetters, mapActions } from "vuex";

export default {
  computed: {
    ...mapGetters({
      paginas: "paginas/paginas",
    }),
  },
  data() {
    return {
      paginasC: "",
      paginaAuxModal: "",
      componenteAConfigurar: "",
    };
  },
  watch: {
    paginas: function (newVal, oldVal) {
      if (newVal != null) {
        this.paginasC = JSON.parse(JSON.stringify(newVal));
      }
    },
  },
  methods: {
    ...mapActions({
      getPaginas: "paginas/getPaginas",
      autenticatorUser: "usuario/AutenticatorUser",
    }),
    abreColapse(collapseSelecionado) {
      this.$root.$emit("bv::toggle::collapse", collapseSelecionado);
    },
    openModalPaginas(pag) {
      console.log(pag);
      this.paginaAuxModal = pag;
      this.$bvModal.show("modal-pagina-altera");
    },
    rotaExternaDaPagina(url) {
      alert("emplementar rota para " + url);
    },
    async modalFormUrl(save) {
      if (save == true) {
        await this.$axios
          .put("api/Paginas/updatePagina", this.paginaAuxModal)
          .then((response) => {
            this.getPaginas();
            alert(response.data);
          })
          .catch((error) => {
            console.log(error);
          });
      }
      this.$bvModal.hide("modal-pagina-altera");
    },
    editarComponente(pagina, componente) {
      if (localStorage.getItem("Modelo") == "1") {
        console.log("entro 1");
        this.$refs.modalTemplate1.getCompoenenteEPaginaNome(
          pagina.nomePagina,
          componente
        );
      }
      if (localStorage.getItem("Modelo") == "2") {
        this.$refs.modalTemplate2.getCompoenenteEPaginaNome(
          pagina.nomePagina,
          componente
        );
      }
      if (localStorage.getItem("Modelo") == "3") {
        console.log("entro 3");
        this.$refs.modalTemplate3.getCompoenenteEPaginaNome(
          pagina.nomePagina,
          componente
        );
      }
    },
  },
  created() {
    this.getPaginas();
    this.autenticatorUser();
  },
};
</script>
<style>
#paginas-lista-paginas {
  background: white;
}
</style>
