<template>
  <div class="py-3 px-4 w-100">
    <h3><strong>Configurações de contato</strong></h3>
    <b-container
      id="configuracoes-contato"
      class="w-100 p-4 configuracoes-forms configuracoes-forms-formatacao"
    >
      <b-row>
        <b-col>
          <label for="configuracoes-contato-input-endereco"
            ><strong>Endereço</strong></label
          >
          <input
            type="text"
            id="configuracoes-contato-input-endereco"
            v-model="contato.endereco"
          />
        </b-col>
        <b-col>
          <label for="configuracoes-contato-input-complemento">
            <strong>Complemento</strong>
          </label>
          <input
            type="text"
            id="configuracoes-contato-input-complemento"
            v-model="contato.complemento"
          />
        </b-col>
        <b-col>
          <label for="configuracoes-contato-input-bairro"
            ><strong>Bairro</strong></label
          >
          <input
            type="text"
            id="configuracoes-contato-input-bairro"
            v-model="contato.bairro"
          />
        </b-col>
      </b-row>
      <b-row>
        <b-col>
          <label for="configuracoes-contato-input-cidade"
            ><strong>Cidade</strong></label
          >
          <input
            type="text"
            id="configuracoes-contato-input-cidade"
            v-model="contato.cidade"
          />
        </b-col>
        <b-col>
          <label for="configuracoes-contato-input-estado"
            ><strong>Estado</strong></label
          >
          <input
            type="text"
            id="configuracoes-contato-input-estado"
            v-model="contato.estado"
          />
        </b-col>
        <b-col>
          <label for="configuracoes-contato-input-telefone"
            ><strong>Telefone</strong></label
          >
          <input
            type="text"
            id="configuracoes-contato-input-telefone"
            v-model="contato.telefone"
          />
        </b-col>
      </b-row>
      <b-row>
        <b-col>
          <label for="configuracoes-contato-input-whatsapp"
            ><strong>WhatsApp</strong></label
          >
          <input
            type="text"
            id="configuracoes-contato-input-whatsapp"
            v-model="contato.whatsapp"
          />
        </b-col>
        <b-col>
          <label for="configuracoes-contato-input-email"
            ><strong>E-mail</strong></label
          >
          <input
            type="text"
            id="configuracoes-contato-input-email"
            v-model="contato.email"
          />
        </b-col>
        <b-col>
          <label for="configuracoes-contato-input-facebook"
            ><strong>Facebook</strong></label
          >
          <input
            type="text"
            id="configuracoes-contato-input-facebook"
            v-model="contato.facebook"
          />
        </b-col>
      </b-row>
      <b-row>
        <b-col>
          <label for="configuracoes-contato-input-instagram"
            ><strong>Instagram</strong></label
          >
          <input
            type="text"
            id="configuracoes-contato-input-instagram"
            v-model="contato.instagram"
          />
        </b-col>
        <b-col>
          <label for="configuracoes-contato-input-linkedin"
            ><strong>Linkedin</strong></label
          >
          <input
            type="text"
            id="configuracoes-contato-input-linkedin"
            v-model="contato.linkedin"
          />
        </b-col>
        <b-col>
          <label for="configuracoes-contato-input-youtube"
            ><strong>Youtube</strong></label
          >
          <input
            type="text"
            id="configuracoes-contato-input-youtube"
            v-model="contato.youtube"
          />
        </b-col>
      </b-row>
      <div class="mt-4">
        <div class="float-right">
          <button
            class="btn-cancelar mr-2"
            @click="cancelarAlteracao('contato')"
          >
            Cancelar
          </button>
          <button class="btn-salvar" @click="salvarConfiguracao('contato')">
            Salvar
          </button>
        </div>
      </div>
    </b-container>

    <h3 class="mt-4"><strong>Configurações do rodapé</strong></h3>
    <b-container
      id="configuracoes-contato-rodape"
      class="w-100 p-4 configuracoes-forms configuracoes-forms-formatacao"
      ><b-row>
        <b-col>
          <label for="configuracoes-rodape-input-rodape"
            ><strong>Mostrar rodapé</strong></label
          >
          <select v-model="rodape.rodapeAtivo">
            <option value="true">Sim</option>
            <option value="false">Não</option>
          </select>
        </b-col>
        <b-col>
          <label for="configuracoes-rodape-input-complemento"
            ><strong>Cor fundo</strong></label
          >

          <ColorPicker
            v-model="rodape.corFundo"
            id="configuracoes-rodape-input-complemento"
          />
        </b-col>
        <b-col>
          <label for="configuracoes-rodape-input-icones"
            ><strong>Icones de redes sociais</strong></label
          >
          <select
            id="configuracoes-rodape-input-icones"
            v-model="rodape.iconesRedesSociais"
          >
            <option value="dark">Dark</option>
            <option value="white">White</option>
          </select>
        </b-col>
      </b-row>
      <b-row class="w-25">
        <b-col>
          <label for="configuracoes-rodape-input-logo"
            ><strong>Logo do rodapé</strong></label
          >

          <input type="file" id="configuracoes-rodape-input-logo" />
          <span v-if="this.rodape.logo != null"
            ><strong>Imagem selecionada</strong></span
          >
          <span v-else> <strong>Sem Conteudo</strong></span>
        </b-col>
      </b-row>
      <div class="mt-4">
        <div class="float-right">
          <button
            class="btn-cancelar mr-2"
            @click="cancelarAlteracao('rodape')"
          >
            Cancelar
          </button>
          <button class="btn-salvar" @click="salvarConfiguracao('rodape')">
            Salvar
          </button>
        </div>
      </div>
    </b-container>
  </div>
</template>
<script>
import { mapActions, mapGetters } from "vuex";

export default {
  data() {
    return {
      rodape: "",
      contato: "",
    };
  },
  computed: {
    ...mapGetters({
      configuracoes: "configuracoes/configuracoes",
    }),
  },
  watch: {
    configuracoes: function (newVal, oldVal) {
      if (newVal != null) {
        console.log(newVal);
        this.contato = Object.assign({}, newVal.contato);
        this.rodape = Object.assign({}, newVal.rodape);
      }
    },
  },
  methods: {
    ...mapActions({
      getConfiguracoes: "configuracoes/getConfiguracoes",
      putRodape: "configuracoes/putRodape",
      putContato: "configuracoes/putContato",
      postImagem: "imagens/postImagem",
      autenticatorUser: "usuario/AutenticatorUser",
    }),
    salvarConfiguracao(formsSelecionado) {
      if (formsSelecionado == "contato") {
        if (this.contato == this.configuracoes.contato) {
          return;
        }
        this.putContato({ contato: this.contato });
      }
      if (formsSelecionado == "rodape") {
        if (this.rodape == this.configuracoes.rodape) {
          return;
        }
        let logoInput = $("#configuracoes-rodape-input-logo")[0].files;
        console.log(logoInput);
        if (logoInput.length != 0) {
          this.rodape.logo = logoInput[0].name;
          logoInput=[logoInput]
          this.postImagem(logoInput[0]);
        }
        this.putRodape({ rodape: this.rodape });
      }
    },

    cancelarAlteracao(formsSelecionado) {
      if (formsSelecionado == "contato") {
        this.contato = Object.assign({}, this.configuracoes.contato);
      }
      if (formsSelecionado == "rodape") {
        this.rodape = Object.assign({}, this.configuracoes.rodape);
      }
    },
  },

  created() {
    this.getConfiguracoes();
    this.autenticatorUser();
  },
};
</script>
<style>
.configuracoes-forms-formatacao {
  background: white;
  display: grid;
}
.configuracoes-forms-formatacao .col {
  display: grid;
}
.configuracoes-forms-formatacao label {
  margin: 22px 5px 2px 5px;
}
</style>
