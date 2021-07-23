<template>
  <div>
    <b-modal id="modal-componentes" size="lg" hide-footer hide-header>
      <span class="float-right mouse-hover-icone-select"
        ><strong>X</strong></span
      >
      <div class="p-3">
        <h5>Editar {{ pagina }} >> {{ componente.tipoComponente }}</h5>

        <!-- completo  BANNER PRINCIPAL-->
        <b-container
          v-if="componente.tipoComponente == 'BANNER PRINCIPAL'"
          class="configuracoes-forms-modal-componentes configuracoes-forms"
        >
          <b-row>
            <b-col>
              <label for="modal-pagina-modal-comp-banner-principal-titulo"
                >Titulo</label
              >
              <input
                v-model="componente.titulo"
                id="modal-pagina-modal-comp-banner-principal-titulo"
              />
              <label for="modal-pagina-modal-comp-banner-principal-btn1"
                >Botão de ação</label
              >
              <input
                v-model="componente.txtBotao1"
                id="modal-pagina-modal-comp-banner-principal-btn1"
              />

              <label for="modal-pagina-modal-comp-banner-principal-btn1-cor"
                >Cor do botão</label
              >
              <ColorPicker
                v-model="componente.corBotao1"
                id="modal-pagina-modal-comp-banner-principal-btn1-cor"
              />
              <label for="modal-pagina-modal-comp-banner-principal-urlBotao1"
                >Direcionamento de botão de ação</label
              >
              <input
                v-model="componente.urlBotao1"
                id="modal-pagina-modal-comp-banner-principal-urlBotao1"
              />

              <label
                for="modal-pagina-modal-comp-banner-principal-banner-cor-fundo"
                >Cor de fundo</label
              >
              <ColorPicker
                v-model="componente.corFundo"
                id="modal-pagina-modal-comp-banner-principal-banner-cor-fundo"
              />
            </b-col>
            <b-col>
              <label for="modal-pagina-modal-comp-banner-principal-texto"
                >Conteudo</label
              >
              <textarea
                id="modal-pagina-modal-comp-banner-principal-texto"
                cols="20"
                rows="6"
                v-model="componente.texto"
              ></textarea>
              <label for="modal-pagina-modal-comp-banner-principal-urlImagemWeb"
                >Imagem Mobile</label
              >
              <input
                type="file"
                @change="saveImages($event, componente, 'mobile', 1)"
                id="modal-pagina-modal-comp-banner-principal-urlImagemWeb"
              />
              <!-- <span v-if="componente.imagens.length != 0"
                ><strong>Com imagem</strong>
              </span>
              <span v-else><strong>Sem imagem </strong></span> -->

              <label
                for="modal-pagina-modal-comp-banner-principal-urlImagemMobile"
                >Imagem Desktop</label
              >
              <input
                type="file"
                @change="saveImages($event, componente, 'desktop', 0)"
                id="modal-pagina-modal-comp-banner-principal-urlImagemMobile"
              />
              <!-- <span v-if="componente.imagens.length != 0"
                ><strong>Com imagem</strong>
              </span>
              <span v-else><strong>Sem imagem </strong></span> -->
            </b-col>
          </b-row>
        </b-container>

        <!-- Incompleto PREVIA GALERIA-->
        <b-container
          v-if="componente.tipoComponente == 'PREVIA GALERIA'"
          class="
            configuracoes-forms-modal-componentes configuracoes-forms
            modal-grid-2-inline
          "
        >
          <div v-for="(i, index) in 8" :key="index">
            <b-row>
              <b-col>
                <label :for="'modal-pagina-modal-comp-' + index"
                  >Imagem 0{{ i }}</label
                >
                <input
                  class="mt-3"
                  type="file"
                  @change="saveImages($event, componente, 'desktop', index)"
                  :id="'modal-pagina-modal-comp-' + index"
                />
                <!-- <span v-if="componente.imagens[index] != undefined"
                  ><strong>Com imagem</strong>
                </span>
                <span v-else><strong>Sem imagem </strong></span> -->

                <span></span>
              </b-col>
            </b-row>
          </div>
        </b-container>

        <!-- completo  FORMULARIO-->
        <b-container
          v-if="componente.tipoComponente == 'FORMULARIO'"
          class="configuracoes-forms-modal-componentes configuracoes-forms"
        >
          <label for="modal-pagina-modal-comp-">FORMULARIO</label>
          <input v-model="componente.url" id="modal-pagina-modal-comp-" />

          <b-row>
            <b-col>
              <label for="modal-pagina-modal-comp-banner-principal-titulo"
                >Titulo</label
              >
              <input
                v-model="componente.titulo"
                id="modal-pagina-modal-comp-banner-principal-titulo"
              />
              <label for="modal-pagina-modal-comp-banner-principal-btn1"
                >Botão de ação</label
              >
              <input
                v-model="componente.txtBotao1"
                id="modal-pagina-modal-comp-banner-principal-btn1"
              />

              <label for="modal-pagina-modal-comp-banner-principal-btn1-cor"
                >Cor do botão</label
              >
              <ColorPicker
                v-model="componente.corBotao1"
                id="modal-pagina-modal-comp-banner-principal-btn1-cor"
              />

              <label
                for="modal-pagina-modal-comp-banner-principal-banner-cor-fundo"
                >Cor de fundo</label
              >
              <ColorPicker
                v-model="componente.corFundo"
                id="modal-pagina-modal-comp-banner-principal-banner-cor-fundo"
              />
            </b-col>
          </b-row>
        </b-container>

        <!-- completo IMAGEM PRINCIPAL-->
        <b-container
          v-if="componente.tipoComponente == 'IMAGEM PRINCIPAL'"
          class="configuracoes-forms-modal-componentes configuracoes-forms"
        >
          <label for="modal-pagina-modal-comp-banner-principal-urlImagemWeb"
            >Imagem Desktop</label
          >
          <input
            type="file"
            @change="saveImages($event, componente, 'desktop', 0)"
            id="modal-pagina-modal-comp-banner-principal-urlImagemWeb"
          />
          <!-- <span v-if="componente.imagens.length != 0"
            ><strong>Com imagem</strong>
          </span>
          <span v-else><strong>Sem imagem </strong></span> -->

          <label for="modal-pagina-modal-comp-banner-principal-urlImagemMobile"
            >Imagem mobile</label
          >
          <input
            type="file"
            @change="saveImages($event, componente, 'mobile')"
            id="modal-pagina-modal-comp-banner-principal-urlImagemMobile"
          />
          <!-- <span v-if="componente.imagens.length != 0"
            ><strong>Com imagem</strong>
          </span>
          <span v-else><strong>Sem imagem </strong></span> -->
          <b-row>
            <b-col> </b-col>
          </b-row>
        </b-container>

        <!-- completo  MINI GALERIA-->
        <b-container
          v-if="componente.tipoComponente == 'MINI GALERIA'"
          class="
            configuracoes-forms-modal-componentes configuracoes-forms
            modal-grid-2-inline
          "
        >
          <div v-for="(i, index) in 4" :key="index + 'col1'">
            <label
              :for="'modal-pagina-modal-comp-mini-galeria-linha-1-file-' + i"
              >Imagem 0{{ i }}</label
            >
            <input
              type="file"
              @change="saveImages($event, componente, 'desktop', index)"
              :id="'modal-pagina-modal-comp-mini-galeria-linha-1-file-' + i"
            />
            <!-- <span v-if="componente.imagens.length != 0"
              ><strong>Com imagem</strong>
            </span>
            <span v-else><strong>Sem imagem </strong></span> -->

            <label
              :for="'modal-pagina-modal-comp-mini-galeria-linha-1-texto-' + i"
              >Texto imagem 0{{ index + 1 }}</label
            >
            <input
              v-model="componente.imagens[index].texto"
              :id="'modal-pagina-modal-comp-mini-galeria-linha-1-texto-' + i"
            />
          </div>
        </b-container>

        <!-- completo  TEXTO ESQUERDA / TEXTO DIREITA / TEXTO CENTRALIZADO-->
        <b-container
          v-if="
            componente.tipoComponente == 'TEXTO ESQUERDA' ||
            componente.tipoComponente == 'TEXTO CENTRALIZADO' ||
            componente.tipoComponente == 'TEXTO DIREITA'
          "
          class="configuracoes-forms-modal-componentes configuracoes-forms"
        >
          <b-row>
            <b-col class="py-5 my-5">
              <label for="modal-pagina-modal-comp-banner-principal-titulo"
                >Titulo</label
              >
              <input
                v-model="componente.titulo"
                id="modal-pagina-modal-comp-banner-principal-titulo" />
              <label
                for="modal-pagina-modal-comp-banner-principal-banner-cor-fundo"
                >Cor de fundo</label
              >
              <ColorPicker
                v-model="componente.corFundo"
                id="modal-pagina-modal-comp-banner-principal-banner-cor-fundo"
            /></b-col>
            <b-col>
              <label for="modal-pagina-modal-comp-banner-principal-texto"
                >Conteudo</label
              >
              <textarea
                id="modal-pagina-modal-comp-banner-principal-texto"
                cols="20"
                rows="6"
                v-model="componente.texto"
              ></textarea>
              <div
                v-if="
                  componente.tipoComponente == 'TEXTO ESQUERDA' ||
                  componente.tipoComponente == 'TEXTO DIREITA'
                "
              >
                <label
                  for="modal-pagina-modal-comp-banner-principal-urlImagemWeb"
                  >Imagem</label
                >
                <input
                  type="file"
                  @change="saveImages($event, componente, 'desktop', 0)"
                  id="modal-pagina-modal-comp-banner-principal-urlImagemWeb"
                />
                <!-- <span v-if="componente.imagens.length != 0"
                  ><strong>Com imagem</strong>
                </span>
                <span v-else><strong>Sem imagem </strong></span> -->
              </div>
            </b-col>
          </b-row>
        </b-container>

        <!-- Incompleto  CONTEUDO GALERIA-->
        <b-container
          v-if="componente.tipoComponente == 'CONTEUDO GALERIA'"
          class="configuracoes-forms-modal-componentes configuracoes-forms"
        >
          <label for="modal-pagina-modal-comp-">
            <strong>Upload de imagens</strong>
          </label>
          <SPAN> Selecione várias imagens de uma vez </SPAN>
          <label for="modal-pagina-modal-comp-banner-principal-urlImagemWeb"
            >Imagem Desktop</label
          >
          <div></div>
          <input
            type="file"
            @change="saveImages($event, componente, 'desktop', 0)"
            multiple
            id="modal-pagina-modal-comp-banner-principal-urlImagemWeb"
          />
          <div class="mt-4 p-2 border border-primary " >

          </div>
          <!-- <span v-if="componente.imagens.length != 0"
            ><strong>Com imagem</strong>
          </span>
          <div v-else class="mt-5 bg-info">imagnes</div> -->
          <b-row>
            <b-col> </b-col>
          </b-row>
        </b-container>

        <!-- completo  MAPA-->
        <b-container
          v-if="componente.tipoComponente == 'MAPA'"
          class="configuracoes-forms-modal-componentes configuracoes-forms"
        >
          <b-row>
            <b-col>
              <label for="modal-pagina-modal-comp-banner-principal-texto"
                >Código do iframe</label
              >
              <span class="h6 mt-4">Disponível pelo Google Maps</span>
              <textarea
                id="modal-pagina-modal-comp-banner-principal-texto"
                cols="20"
                rows="6"
                v-model="componente.urlBotao1"
              ></textarea>
            </b-col>
          </b-row>
        </b-container>
      </div>

      <div class="mt-4">
        <div class="float-right">
          <button class="btn-cancelar mr-2" @click="saveAlteracoes(false)">
            Cancelar
          </button>
          <button class="btn-salvar" @click="saveAlteracoes(true)">
            Salvar
          </button>
        </div>
      </div>
    </b-modal>
  </div>
</template>

<script>
import { mapActions, mapGetters } from "vuex";
export default {
  data() {
    return {
      pagina: "",
      componente: "",
      imgsAux: [],
    };
  },
  methods: {
    ...mapActions({
      objImagemEx: "componente/createComponente",
      getPaginas: "paginas/getPaginas",
      postImagem: "imagens/postImagem",
    }),
    async saveAlteracoes(save) {
      if (save == true) {
        if (this.imgsAux != null) {
          this.postImagem(this.imgsAux);
        }
        console.log(this.componente);
        await this.$axios
          .put("api/Componentes/updateComponente", this.componente)
          .then((response) => {
            alert(response.data.msg);
            console.log(response);
            this.getPaginas();
          })
          .catch((error) => {
            alert("Ocorreu um erro ao salvar o componente, tente novamente");
            console.log(error);
          });
      }
      this.componente = {};
      this.$bvModal.hide("modal-componentes");
    },
    async saveImages(arquivos, componente, tipo, posicao) {
      if (arquivos.target.files.length == 0) {
        return;
      }
      if (componente.tipoComponente == "CONTEUDO GALERIA") {
        for (let index = 0; index < arquivos.target.files.length; index++) {
          this.componente.imagens.push(await this.objImagemEx());
          this.componente.imagens[(this.componente.imagens.length +index-1)].imgUrl =  arquivos.target.files[index].name;
          this.componente.imagens[(this.componente.imagens.length +index-1)].compatibilidade = tipo;
          console.log(index);
        }
        return;
      }
      if (this.componente.imagens.length <= posicao) {
        for (
          let index = this.componente.imagens.length;
          index < posicao + 1;
          index++
        ) {
          this.componente.imagens.push(await this.objImagemEx());
        }
      }
      this.componente.imagens.forEach((img) => {
        if (img.ordenacao == posicao) {
          img.imgUrl = arquivos.target.files[0].name;
          img.compatibilidade = tipo;
          posicao = -1;
        }
      });
      if (posicao < 0) {
        return;
      }
      this.componente.imagens[posicao].ordenacao = posicao;
      this.componente.imagens[posicao].imgUrl = arquivos.target.files[0].name;
      this.componente.imagens[posicao].compatibilidade = tipo;
      arquivos.target.files.forEach((file) => {
        this.imgsAux.push(file);
      });
    },
    getCompoenenteEPaginaId(nomePagina, componente) {
      this.pagina = nomePagina;
      this.componente = null;
      this.componente = componente;
      console.log(this.componente.imagens);
      this.$bvModal.show("modal-componentes");
    },
  },
};
</script>

<style scoped>
.configuracoes-forms-modal-componentes {
  display: grid;
}

.configuracoes-forms-modal-componentes .col {
  display: inline-grid !important;
}
.modal-grid-2-inline {
  grid-template-columns: auto auto;
}
.modal-grid-2-inline div {
  margin: 7px 12px;
  display: inline-grid !important;
}

.configuracoes-forms-modal-componentes label {
  margin: 20px 5px 0 0;
}
</style>