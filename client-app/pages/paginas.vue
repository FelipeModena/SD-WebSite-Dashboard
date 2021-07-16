<template>
  <div class="w-100 py-5 px-3">
    <h3>Páginas</h3>
    <div id="paginas-lista-paginas" class="px-2 py-1">
      <b-container>
        <b-row>
          <b-col><h5><strong>Página</strong></h5> </b-col>
          <b-col><h5><strong>Url</strong></h5></b-col>
          <b-col></b-col>
        </b-row>
        <b-row v-for="(pag, index) in paginasC" :key="index">
          <b-col>{{ pag.nomePagina }}</b-col>
          <b-col>Url</b-col>
          <b-col >
              <p class="float-right">{{pag.componente.length}}</p>
              
          </b-col>
        </b-row>
      </b-container>
    </div>
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
    };
  },
  watch: {
    paginas: function (newVal, oldVal) {
      console.log(newVal);
      if (newVal != null) {
        this.paginasC = Object.assign({}, newVal);
      }
    },
  },
  methods: {
    ...mapActions({
      getPaginas: "paginas/getPaginas",
    }),
  },
  created() {
    this.getPaginas();
  },
};
</script>
<style>
#paginas-lista-paginas {
  background: white;
}
</style>
