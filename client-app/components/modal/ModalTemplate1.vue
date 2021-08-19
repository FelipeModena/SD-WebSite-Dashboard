<template>
  <div>
    <b-modal
      id="modal-componentes-template-1"
      size="xl"
      hide-footer
      hide-header
    >
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
              <EditorTexto
                v-bind:value.sync="componente.titulo"
                :id="'modal-pagina-modal-comp-banner-principal-titulo'"
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
          <br /><br />
          <b-row>
            <b-col class="configuracoes-forms-modal-componentes">
              <div
                v-for="(img, index) in verificaImagemLength"
                :key="index"
                class="
                  configuracoes-forms-modal-componentes
                  pb-4
                  mb-3
                  border-bottom border-primary
                "
              >
                <div v-if="index == 0">
                  <b-row>
                    <b-col>
                      <label
                        for="modal-pagina-modal-comp-banner-principal-urlImagemMobile"
                        >Imagem de fundo do banner</label
                      >
                      <input
                        type="file"
                        @change="
                          saveImages($event, componente, 'desktop', index)
                        "
                        id="modal-pagina-modal-comp-banner-principal-urlImagemMobile"
                      />
                      <span v-if="img.imgUrl !== null && img.imgUrl !== 'null'">
                        Com imagem {{ img.imgUrl }}
                      </span>
                    </b-col>
                  </b-row>
                  <br />
                </div>
                <div v-else>
                  <button
                    class="bg-danger"
                    style="width: 2%"
                    @click="GetIdImagemParaDeletar(img.id)"
                  >
                    X
                  </button>
                  <b-row>
                    <b-col>
                      <label
                        :for="
                          'modal-pagina-modal-comp-mini-galeria-linha-1-texto-' +
                          index
                        "
                        >Texto imagem 0{{ index }}</label
                      >
                      <EditorTexto
                        v-bind:value.sync="img.texto"
                        :id="
                          'modal-pagina-modal-comp-mini-galeria-linha-1-texto-' +
                          index
                        "
                      />
                      <label
                        for="modal-pagina-modal-comp-banner-principal-urlImagemMobile"
                        >Imagem {{ index }}
                      </label>
                      <input
                        type="file"
                        @change="
                          saveImages($event, componente, 'desktop', index)
                        "
                        id="modal-pagina-modal-comp-banner-principal-urlImagemMobile"
                      />
                      <span v-if="img.imgUrl !== null && img.imgUrl !== 'null'">
                        Com imagem {{ img.imgUrl }}
                      </span>
                    </b-col>
                  </b-row>
                </div>
              </div>

              <button @click="pushImagem()" class="mt-4 btn btn-primary">
                Adicionar mais uma página do caroussel
              </button>
            </b-col>
          </b-row>
        </b-container>

        <!-- completo  MINI GALERIA-->
        <b-container
          v-if="
            componente.tipoComponente == 'MINI GALERIA' ||
            componente.tipoComponente == 'CARDS ESTATICOS' ||
            componente.tipoComponente == 'IMAGENS HOVER'
          "
          class="configuracoes-forms configuracoes-forms-modal-componentes"
        >
          <div
            v-if="componente.tipoComponente == 'CARDS ESTATICOS'"
            class="configuracoes-forms mb-4"
          >
            <label for="modal-pagina-modal-comp-banner-principal-titulo"
              >Titulo</label
            >
            <EditorTexto
              v-bind:value.sync="componente.titulo"
              :id="'modal-pagina-modal-comp-banner-principal-titulo'"
            />
            <label
              for="modal-pagina-modal-comp-banner-principal-banner-cor-fundo"
              >Cor de fundo</label
            >
            <ColorPicker
              v-model="componente.corFundo"
              id="modal-pagina-modal-comp-banner-principal-banner-cor-fundo"
            />

            <label for="modal-pagina-modal-comp-banner-principal-btn1"
              >Botão de ação</label
            >
            <br />
            <input
              v-model="componente.txtBotao1"
              id="modal-pagina-modal-comp-banner-principal-btn1"
            />
            <label
              v-if="componente.txtBotao1 != null && componente.txtBotao1 != ''"
              for="modal-pagina-modal-comp-banner-principal-urlBotao1"
              >Direcionamento de botão de ação</label
            >
            <select
              v-if="componente.txtBotao1 != null && componente.txtBotao1 != ''"
              id="modal-pagina-modal-comp-banner-principal-urlBotao1"
              name=""
              v-model="componente.urlBotao1"
            >
              <option value="">Sem rota</option>
              <option v-for="(pag, i) in paginas" :value="pag.url" :key="i">
                {{ pag.url }}
              </option>
            </select>
            <br />
            <label
              v-if="componente.urlBotao1 != '' && componente.urlBotao1 != null"
              for="modal-pagina-modal-comp-banner-principal-btn1-cor"
              >Cor do botão</label
            >
            <ColorPicker
              v-if="componente.urlBotao1 != '' && componente.urlBotao1 != null"
              v-model="componente.corBotao1"
              id="modal-pagina-modal-comp-banner-principal-btn1-cor"
            />
            <br /><br />
          </div>
          <div
            class="configuracoes-forms-modal-componentes modal-grid-2-inline"
          >
            <div
              v-for="(img, index) in verificaImagemLength"
              :key="index + 'col1'"
            >
              <button
                class="bg-danger"
                style="width: 2%"
                @click="GetIdImagemParaDeletar(img.id)"
              >
                X
              </button>
              <label
                :for="
                  'modal-pagina-modal-comp-mini-galeria-linha-1-file-' + index
                "
                >Imagem 0{{ index + 1 }}</label
              >
              <input
                type="file"
                @change="saveImages($event, componente, 'desktop', index)"
                :id="
                  'modal-pagina-modal-comp-mini-galeria-linha-1-file-' + index
                "
              />

              <label
                :for="
                  'modal-pagina-modal-comp-mini-galeria-linha-1-texto-' + index
                "
                >Texto imagem 0{{ index + 1 }}</label
              >
              <EditorTexto
                v-bind:value.sync="img.texto"
                :id="
                  'modal-pagina-modal-comp-mini-galeria-linha-1-texto-' + index
                "
              />
            </div>
          </div>

          <button @click="pushImagem()" class="my-4 btn-primary w-100">
            Adicionar mais uma página do caroussel
          </button>
        </b-container>

        <!-- Incompleto IMAGENS HOVER-->
        <b-container
          v-if="componente.tipoComponente == 'IMAGENS HOVER'"
          class="configuracoes-forms-modal-componentes configuracoes-forms"
        >
          <div
            class="
              pb-4
              configuracoes-forms-modal-componentes
              border-bottom border-primary
            "
          >
            <label for="modal-pagina-modal-comp-banner-principal-btn1"
              >Botão de ação</label
            >
            <br />
            <input
              v-model="componente.txtBotao1"
              id="modal-pagina-modal-comp-banner-principal-btn1"
            />
            <label
              v-if="componente.txtBotao1 != null && componente.txtBotao1 != ''"
              for="modal-pagina-modal-comp-banner-principal-urlBotao1"
              >Direcionamento de botão de ação</label
            >
            <select
              v-if="componente.txtBotao1 != null && componente.txtBotao1 != ''"
              id="modal-pagina-modal-comp-banner-principal-urlBotao1"
              name=""
              v-model="componente.urlBotao1"
            >
              <option value="">Sem rota</option>
              <option v-for="(pag, i) in paginas" :value="pag.url" :key="i">
                {{ pag.url }}
              </option>
            </select>
            <br />
            <label
              v-if="componente.urlBotao1 != '' && componente.urlBotao1 != null"
              for="modal-pagina-modal-comp-banner-principal-btn1-cor"
              >Cor do botão</label
            >
            <ColorPicker
              v-if="componente.urlBotao1 != '' && componente.urlBotao1 != null"
              v-model="componente.corBotao1"
              id="modal-pagina-modal-comp-banner-principal-btn1-cor"
            />
          </div>
          <div class="modal-grid-2-inline">
            <div v-for="(img, index) in verificaImagemLength" :key="index">
              <b-row>
                <b-col>
                  <button
                    class="bg-danger"
                    style="width: 2%"
                    @click="GetIdImagemParaDeletar(img.id)"
                  >
                    X
                  </button>
                  <label
                    :for="
                      'modal-pagina-modal-comp-mini-galeria-linha-1-file-' +
                      index
                    "
                    >Enredeço loja {{ index }}</label
                  >
                  <input
                    type="file"
                    @change="saveImages($event, componente, 'desktop', index)"
                    :id="
                      'modal-pagina-modal-comp-mini-galeria-linha-1-file-' +
                      index
                    "
                  />
                  <span
                    v-if="
                      img.imgUrl != null ||
                      img.imgUrl != '' ||
                      img.imgUrl != undefined
                    "
                    >{{ img.imgUrl }} no local</span
                  >
                  <label
                    :for="
                      'modal-pagina-modal-comp-mini-galeria-linha-1-texto-' +
                      index
                    "
                    >Texto imagem 0{{ index }}</label
                  >
                  <input
                    v-model="img.texto"
                    :id="
                      'modal-pagina-modal-comp-mini-galeria-linha-1-texto-' +
                      index
                    "
                  />
                </b-col>
              </b-row>
            </div>
          </div>
          <button @click="pushImagem()" class="my-4 btn-primary">
            Adicionar nova imagem
          </button>
        </b-container>

        <!-- completo  FORMULARIO-->
        <b-container
          v-if="componente.tipoComponente == 'FORMULARIO E IFRAME MAPS' || componente.tipoComponente == 'FORMULARIO E CONTATOS'"
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
              <label
                for="modal-pagina-modal-comp-banner-principal-banner-cor-fonte"
                >Cor da fonte</label
              >
              <ColorPicker
                v-model="componente.corTitulo"
                id="modal-pagina-modal-comp-banner-principal-banner-cor-fonte"
              />
              <br />
              <label
                for="modal-pagina-modal-comp-banner-principal-banner-cor-fundo"
                >Cor de fundo</label
              >
              <ColorPicker
                v-model="componente.corFundo"
                id="modal-pagina-modal-comp-banner-principal-banner-cor-fundo"
              />

              <br />
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
              <br>
              <label
                for="modal-pagina-modal-comp-banner-principal-banner-cor-fundo-carrousel"
                ><span
                  v-if="componente.tipoComponente == 'FORMULARIO E IFRAME MAPS'"
                >Ativar iframe (o mesmo do MAPA)</span
              >
              <span v-if="componente.tipoComponente == 'FORMULARIO E CONTATOS'">Ativar contatos </span>
              </label>
              <select class="w-25" v-model="componente.corSubTitulo"  id="modal-pagina-modal-comp-banner-principal-banner-cor-fundo-carrousel">
                <option value="true">Ativado</option>
                <option value="false">Desativado</option>
              </select>

                
            </b-col>
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

        <!-- completo IMAGEM PRINCIPAL-->
        <b-container
          v-if="
            componente.tipoComponente == 'IMAGEM PRINCIPAL' ||
            componente.tipoComponente == 'BANNER'
          "
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
            @change="saveImages($event, componente, 'mobile', 1)"
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

        <!-- completo  CARROUSEL-->
        <b-container v-if="componente.tipoComponente == 'CARROUSEL'">
          <div class="w-50 my-3">
            <label
              for="modal-pagina-modal-comp-banner-principal-banner-cor-fonte"
              >Cor de fonte</label
            >
            <ColorPicker
              v-model="componente.corTitulo"
              id="modal-pagina-modal-comp-banner-principal-banner-cor-fonte"
            />
            <label
              for="modal-pagina-modal-comp-banner-principal-banner-cor-fundo"
              >Cor de fundo</label
            >
            <ColorPicker
              v-model="componente.corFundo"
              id="modal-pagina-modal-comp-banner-principal-banner-cor-fundo"
            />
          </div>
          <div class="configuracoes-forms modal-grid-2-inline">
            <div
              v-for="(img, index) in verificaImagemLength"
              :key="index + 'col1'"
            >
              <div class="w-100">
                <button
                  class="bg-danger"
                  style="width: 27px; height: 27px"
                  @click="GetIdImagemParaDeletar(img.id)"
                >
                  X
                </button>
                <label
                  :for="
                    'modal-pagina-modal-comp-mini-galeria-linha-1-file-' + index
                  "
                  >Iamgem principal</label
                >
                <input
                  type="file"
                  @change="saveImages($event, componente, 'desktop', index)"
                  :id="
                    'modal-pagina-modal-comp-mini-galeria-linha-1-file-' + index
                  "
                />
                <label
                  :for="
                    'modal-pagina-modal-comp-mini-galeria-linha-1-titulo-' +
                    index
                  "
                  >Titulo carrousel</label
                >
                <input
                  v-model="componente.titulo"
                  :id="
                    'modal-pagina-modal-comp-mini-galeria-linha-1-titulo-' +
                    index
                  "
                />
                <label
                  :for="
                    'modal-pagina-modal-comp-mini-galeria-linha-1-texto-' +
                    index
                  "
                  >Texto imagem 0{{ index + 1 }}</label
                >
                <EditorTexto
                  v-bind:value.sync="img.texto"
                  :id="
                    'modal-pagina-modal-comp-mini-galeria-linha-1-texto-' +
                    index
                  "
                />
              </div>
            </div>
            <button @click="pushImagem()" class="my-4 btn-primary">
              Adicionar card ao caroussel
            </button>
          </div>
        </b-container>

        <!-- completo  TEXTO ESQUERDA / TEXTO DIREITA / TEXTO CENTRALIZADO-->
        <b-container
          v-if="
            componente.tipoComponente == 'TEXTO DIREITA E IMAGEM ESQUERDA' ||
            componente.tipoComponente == 'TEXTO CENTRALIZADO' ||
            componente.tipoComponente == 'TEXTO ESQUERDA E IMAGEM DIREITA'
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
                id="modal-pagina-modal-comp-banner-principal-titulo"
              />
              <label
                for="modal-pagina-modal-comp-banner-principal-banner-cor-fonte"
                >Cor de fonte</label
              >
              <ColorPicker
                v-model="componente.corTitulo"
                id="modal-pagina-modal-comp-banner-principal-banner-cor-fonte"
              />

              <label
                for="modal-pagina-modal-comp-banner-principal-banner-cor-fundo"
                >Cor de fundo</label
              >
              <ColorPicker
                v-model="componente.corFundo"
                id="modal-pagina-modal-comp-banner-principal-banner-cor-fundo"
              />
              <br />
              <label for="modal-pagina-modal-comp-banner-principal-btn1"
                >Botão de ação</label
              >
              <br />
              <input
                v-model="componente.txtBotao1"
                id="modal-pagina-modal-comp-banner-principal-btn1"
              />
              <label
                v-if="
                  componente.txtBotao1 != null && componente.txtBotao1 != ''
                "
                for="modal-pagina-modal-comp-banner-principal-urlBotao1"
                >Direcionamento de botão de ação</label
              >
              <select
                v-if="
                  componente.txtBotao1 != null && componente.txtBotao1 != ''
                "
                id="modal-pagina-modal-comp-banner-principal-urlBotao1"
                name=""
                v-model="componente.urlBotao1"
              >
                <option value="">Sem rota</option>
                <option v-for="(pag, i) in paginas" :value="pag.url" :key="i">
                  {{ pag.url }}
                </option>
              </select>
              <br />
              <label
                v-if="
                  componente.urlBotao1 != '' && componente.urlBotao1 != null
                "
                for="modal-pagina-modal-comp-banner-principal-btn1-cor"
                >Cor do botão</label
              >
              <ColorPicker
                v-if="
                  componente.urlBotao1 != '' && componente.urlBotao1 != null
                "
                v-model="componente.corBotao1"
                id="modal-pagina-modal-comp-banner-principal-btn1-cor"
              />
            </b-col>
            <b-col>
              <label for="modal-pagina-modal-comp-banner-principal-texto"
                >Conteudo</label
              >
              <EditorTexto v-bind:value.sync="componente.texto" />

              <div
                v-if="
                  componente.tipoComponente ==
                    'TEXTO DIREITA E IMAGEM ESQUERDA' ||
                  componente.tipoComponente == 'TEXTO ESQUERDA E IMAGEM DIREITA'
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
          <label for="modal-pagina-modal-comp-banner-principal-titulo"
            >Titulo</label
          >
          <input
            v-model="componente.titulo"
            id="modal-pagina-modal-comp-banner-principal-titulo"
          />
          <label for="modal-pagina-modal-comp-banner-principal-banner-cor-fonte"
            >Cor de fonte</label
          >
          <ColorPicker
            v-model="componente.corTitulo"
            id="modal-pagina-modal-comp-banner-principal-banner-cor-fonte"
          />
          <br />
          <label for="modal-pagina-modal-comp-">
            <strong>Upload de imagens</strong>
          </label>
          <span> Selecione várias imagens de uma vez </span>
          <label for="modal-pagina-modal-comp-banner-principal-urlImagemWeb"
            >Imagem Desktop</label
          >
          <input
            type="file"
            @change="saveImages($event, componente, 'desktop', 0)"
            multiple
            id="modal-pagina-modal-comp-banner-principal-urlImagemWeb"
          />
          <div class="mt-4 p-2 border border-primary">
            <div
              v-for="(img, index) in componente.imagens"
              :key="index"
              class="d-inline-block"
            >
              <div class="configuracoes-forms-modal-componentes text-center">
                <img
                  class="mx-3 mouse-hover-icone-select"
                  width="100px"
                  height="100px"
                  :src="API_URL + '/images/' + img.imgUrl"
                  alt=""
                  @click="
                    $bvModal.show('modal-componentes-conteudo-galeria-' + index)
                  "
                />
                <button
                  class="bg-danger rounded-circle position-absolute"
                  @click="GetIdImagemParaDeletar(img.id)"
                >
                  X
                </button>
                <span class="mb-3" v-if="img.texto !== '' && img.texto != null"
                  >Com texto</span
                >
              </div>
              <b-modal
                :id="'modal-componentes-conteudo-galeria-' + index"
                size="lg"
              >
                <template #modal-title>
                  Editando imagem {{ img.imgUrl }}
                </template>
                <label
                  :for="
                    'modal-pagina-modal-comp-mini-galeria-linha-1-texto-' +
                    index
                  "
                  >Texto imagem 0{{ index + 1 }}</label
                >
                <EditorTexto
                  v-bind:value.sync="img.texto"
                  :id="
                    'modal-pagina-modal-comp-mini-galeria-linha-1-texto-' +
                    index
                  "
                />
              </b-modal>
            </div>
          </div>
          <!-- <span v-if="componente.imagens.length != 0"
            ><strong>Com imagem</strong>
          </span>
          <div v-else class="mt-5 bg-info">imagnes</div> -->
        </b-container>

        <!-- completo  LOCALIZACAO-->
        <b-container
          v-if="componente.tipoComponente == 'LOCALIZACAO'"
          class="configuracoes-forms-modal-componentes configuracoes-forms"
        >
          <b-row
            v-for="(localizacao, index) in verificaImagemLength"
            :key="index"
          >
            <b-col>
              <label for="modal-pagina-modal-comp-banner-principal-texto"
                >Código do iframe</label
              >
              <span class="h6 mt-4">Disponível pelo Google Maps</span>
              <textarea
                id="modal-pagina-modal-comp-banner-principal-texto"
                v-model="localizacao.urlBotao1"
              ></textarea>
            </b-col>
            <c-lol class="px-auto">
              <input
                type="file"
                @change="saveImages($event, 'null', 'desktop', 0)"
                multiple
                id="modal-pagina-modal-comp-banner-principal-urlImagemWeb"
            /></c-lol>
            <c-lol>
              <EditorTexto
                v-bind:value.sync="localizacao.texto"
                id="
                    modal-pagina-modal-comp-banner-principal-texto"
            /></c-lol>
          </b-row>
          <b-row>
            <button @click="pushImagem()" class="my-4 btn-primary">
              Adicionar card ao caroussel
            </button>
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
      imgsDeletadas: [],
    };
  },
  computed: {
    ...mapGetters({
      paginas: "paginas/paginas",
    }),
    verificaImagemLength() {
      if (this.componente.imagens.length == 0) {
        this.componente.imagens.push(this.objImagemEx());
      }
      return this.componente.imagens;
    },
  },
  methods: {
    ...mapActions({
      objImagemEx: "componente/createComponente",
      getPaginas: "paginas/getPaginas",
      updateComponente: "componente/updateComponente",
      postImagem: "imagens/postImagem",
      deleteImagem: "imagens/deleteImagens",
    }),
    async saveAlteracoes(save) {
      if (save == true) {
        if (this.imgsAux.length > 0) {
          this.postImagem(this.imgsAux);
        }
        if (this.imgsDeletadas.length > 0) {
          this.deleteImagem(this.imgsDeletadas);
        }
        alert(await this.updateComponente(this.componente));
        this.getPaginas();
      }
      this.componente = {};
      this.imgsDeletadas = [];
      this.$bvModal.hide("modal-componentes-template-1");
    },
    async saveImages(arquivos, componente, tipo, posicao) {
      if (arquivos.target.files.length == 0) {
        return;
      }
      if (componente.tipoComponente == "CONTEUDO GALERIA") {
        for (let index = 0; index < arquivos.target.files.length; index++) {
          this.pushImagem();
          console.log(this.componente.imagens.length);
          this.componente.imagens[this.componente.imagens.length - 1].imgUrl =
            arquivos.target.files[index].name;
          this.componente.imagens[
            this.componente.imagens.length - 1
          ].compatibilidade = tipo;
        }
      } else {
        if (this.componente.imagens.length <= posicao) {
          for (
            let index = this.componente.imagens.length;
            index < posicao + 1;
            index++
          ) {
            this.pushImagem();
          }
        }
        if (posicao < 0) {
          return;
        }
        this.componente.imagens[posicao].ordenacao = posicao;
        this.componente.imagens[posicao].imgUrl = arquivos.target.files[0].name;
        this.componente.imagens[posicao].compatibilidade = tipo;
      }
      arquivos.target.files.forEach((file) => {
        console.log(file);
        this.imgsAux.push(file);
      });
    },
    pushImagem() {
      this.componente.imagens.push(this.objImagemEx());
    },
    GetIdImagemParaDeletar(id) {
      console.log(id);
      this.imgsDeletadas.push(id);
      this.componente.imagens.splice(
        this.componente.imagens.findIndex((a) => a.id === id),
        1
      );
    },
    getCompoenenteEPaginaNome(nomePagina, componente) {
      this.pagina = nomePagina;
      this.componente = null;
      this.componente = componente;
      console.log(this.componente);
      this.$bvModal.show("modal-componentes-template-1");
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