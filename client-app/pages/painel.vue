<template>
  <div class="container w-100 text-center py-4">
    <b-container fluid>
      <b-row class="text-center">
        <b-col md="1" class="py-3">
          <b-button
            @click="salvarAlteracoes()"
            class="btn px-5 py-2"
            variant="success"
            >Salvar Altereçoes</b-button
          >
        </b-col>
      </b-row>
    </b-container>

    <DropList :items="paginasPainel" @reorder="$event.apply(paginasPainel)">
      <template v-slot:item="{ item }">
        <Drag :key="item.id" :data="item">
          <div
            class="d-flex bg-secondary mt-4"
            :class="EstiloPaginaAtiva(item.ativa)"
            :id="'b-paginas-drop-coplase-' + item.id"
          >
            <b-button
              @click="abreColapse('b-componente-drop-coplase-' + item.id)"
              variant=" w-100  p-3"
              >{{ item.nomePagina }}</b-button
            >
            <b-form-checkbox
              @change="desativaPag(item, 'b-paginas-drop-coplase-' + item.id)"
              :checked="item.ativa"
              switch
            >
            </b-form-checkbox>
          </div>

          <b-collapse :id="'b-componente-drop-coplase-' + item.id">
            <div
              class="mt-2 mx-5 p-2 d-flex"
              :class="
                EstiloComponenteAtivo(
                  'b-componente-drop-coplase-class' + item.id + componente.id,
                  componente.ativo
                )
              "
              v-for="(componente, index) in item.componente"
              :key="index"
            >
              <b-form-checkbox
                @change="
                  desativaComponente(
                    item.id,
                    componente,
                    'b-componente-drop-coplase-' + item.id + componente.id
                  )
                "
                :checked="componente.ativo"
                switch
              >
              </b-form-checkbox>
              <img
                @click="sobeComponente(item, index)"
                width="30px"
                height="30px"
                class="px-1 ml-3 float-right"
                src="~/assets/icones/btn-arrow.png"
                alt=""
              />
              <img
                width="30px"
                height="30px"
                @click="desceComponente(item, index)"
                class="px-1 mr-3 text-right rotate-180"
                src="~/assets/icones/btn-arrow.png"
                alt=""
              />
              <p class="card-text mr-4 text-left">
                {{ componente.tipoComponente }} 
              </p>
            </div>
          </b-collapse>
        </Drag>
      </template>
    </DropList>
  </div>
</template>

<script>
import { mapGetters, mapActions, mapMutations } from "vuex";
import { Drag, Drop, DropList } from "vue-easy-dnd";

export default {
  components: {
    Drag,
    DropList,
    Drop,
  },
  computed: {
    ...mapGetters({
      paginas: "paginas/paginas",
    }),
  },
  data() {
    return {
      paginasPainel: null,
    };
  },
  watch: {
    paginas: function (newVal, oldVal) {
      if (newVal != null) {
        this.paginasPainel = JSON.parse(JSON.stringify(newVal));
      }
    },
    paginasPainel: function (newVal, oldVal) {
      if (newVal != oldVal) {
        return;
      }
      this.reorderPaginas(newVal);
    },
  },
  methods: {
    ...mapActions({
      getPaginas: "paginas/getPaginas",
      salvarAlteracoes: "paginas/salvarAlteracoes",
      autenticatorUser: "usuario/AutenticatorUser",
    }),
    ...mapMutations({
      reorderPaginas: "paginas/REORDER_PAGINAS",
      desativaPaginaVuex: "paginas/DESATIVA_PAGINAS",
      desativaComponenteVuex: "paginas/DESATIVA_COMPONENTE",
      ordenaComponente: "paginas/ORDDENA_COMPONENTE",
    }),
    sobeComponente(pagina, index) {
      let pagIndex = this.paginasPainel.findIndex((p) => p == pagina);
      if (index > 0) {
        this.paginasPainel[pagIndex].componente[index].ordem = index - 1;
        this.paginasPainel[pagIndex].componente[index-1].ordem = index + 1;
        this.paginasPainel[pagIndex].componente.forEach((element) => {
        });
      } else {
        this.paginasPainel[pagIndex].componente.forEach((element,posicao) => {
          if (posicao!=0) {
            this.paginasPainel[pagIndex].componente[posicao].ordem = index;
          }
        });
      }
      this.paginasPainel[pagIndex].componente = this.paginasPainel[
        pagIndex
      ].componente.sort((c1, c2) => {
        return c1.ordem - c2.ordem;
      });
        this.ordenaComponente(this.paginasPainel);
    },
    desceComponente(pagina, index) {
      let pagIndex = this.paginasPainel.findIndex((p) => p == pagina);
      if (index < this.paginasPainel[pagIndex].componente.length) {
        this.paginasPainel[pagIndex].componente[index].ordem = index + 1;
        this.paginasPainel[pagIndex].componente[index+1].ordem = index - 1;
      } else {
        this.paginasPainel[pagIndex].componente.forEach((element,posicao) => {
          if (posicao!=0) {
            this.paginasPainel[pagIndex].componente[posicao].ordem = index;
          }
        });
      }
      this.paginasPainel[pagIndex].componente = this.paginasPainel[
        pagIndex
      ].componente.sort((c1, c2) => {
        return c1.ordem - c2.ordem;
      });

        this.ordenaComponente(this.paginasPainel);

    },
    desativaComponente(paginaId, comp, idHtml) {
      if (comp.ativo == false) {
        $("." + idHtml).addClass("bg-danger");
      } else {
        $("." + idHtml).removeClass("bg-danger");
      }
      this.desativaComponenteVuex({ paginaId, comp });
    },
    EstiloComponenteAtivo(idClasseComponente, compAtivado) {
      if (compAtivado == false) {
        return [idClasseComponente, "bg-danger"];
      } else {
        return [idClasseComponente, "bg-secondary", "bg-gradient"];
      }
    },
    desativaPag(pagina, idHtml) {
      if (pagina.ativa == true) {
        $("#" + idHtml).addClass("bg-danger");
      } else {
        $("#" + idHtml).removeClass("bg-danger");
      }
      this.desativaPaginaVuex(pagina);
    },
    EstiloPaginaAtiva(ativa) {
      if (ativa == false) {
        return "bg-danger";
      }
    },
    abreColapse(collapseSelecionado) {
      this.$root.$emit("bv::toggle::collapse", collapseSelecionado);
    },
  },
  created() {
    this.getPaginas();
    this.autenticatorUser();
  },
};
</script>

<style>
painel-dropdown-paginas .dropdown-menu {
  width: 100%;
}
</style>
