<template>
  <div class="container w-100 text-center py-4">
    <b-container fluid>
      <b-row class="text-center">
        <b-col md="1" class="py-3">
          <b-button @click="salvarAlteracoes()" class="btn px-5 py-2" variant="success"
            >Salvar Altereçoes</b-button
          >
        </b-col>
      </b-row>
    </b-container>

    <DropList :items="paginasPainel" @reorder="$event.apply(paginasPainel)">
      <template v-slot:item="{ item }">
        <Drag :key="item.id" :data="item">
          <div
            class="d-flex bg-secondary my-2"
            :class="EstiloPaginaAtiva(item.ativa)"
            :id="'b-paginas-drop-coplase-' + item.id"
          >
            <b-button
              @click="abreColapse('collapse-paginas-' + item.id)"
              variant=" w-100  p-3"
              >{{ item.nomePagina }}</b-button
            >
            <b-form-checkbox
              @change="desativaPag(item, 'b-paginas-drop-coplase-' + item.id)"
              :checked="'' + item.ativa"
              name="check-button"
              switch
            >
            </b-form-checkbox>
          </div>

          <b-collapse :id="'collapse-paginas-' + item.id" class="mt-2 text-left">
            <div class="my-3 bg-primary p-1" v-for="(componente, index) in item.componente" :key="index">
              <p class="card-text">{{ componente.tipoComponente }}</p>
              <div class="d-flex ">
                <b-form-checkbox :checked="'' + componente.ativa" name="check-button" switch>
                </b-form-checkbox>
              </div>
            </div>
            <b-collapse :id="'collapse-componentes-' + item.id" class="mt-2">
              <b-card>Hello!</b-card>
            </b-collapse>
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
      this.paginasPainel = newVal.slice();
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
    }),
    ...mapMutations({
      reorderPaginas: "paginas/REORDER_PAGINAS",
      desativaPagina: "paginas/DESATIVA_PAGINAS",
    }),

    desativaPag(pagina, idHtml) {
      if (pagina.ativa == true) {
        $("#" + idHtml).addClass("bg-danger");
      } else {
        $("#" + idHtml).removeClass("bg-danger");
      }
      this.desativaPagina(pagina);
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
  },
};
</script>

<style>
painel-dropdown-paginas .dropdown-menu {
  width: 100%;
}
</style>
