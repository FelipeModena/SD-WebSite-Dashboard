<template>
  <div class="py-3 px-4 w-100">
    <h3><strong>Configurações de contato</strong></h3>
    <b-container id="configuracoes-contato" class="w-100 p-4 configuracoes-forms">
      <b-row>
        <b-col>
          <label for="configuracoes-input-endereco"><strong>Endereço</strong></label>
          <input
            type="text"
            id="configuracoes-input-endereco"
            v-model="configs.endereco"
          />
        </b-col>
        <b-col>
          <label for="configuracoes-input-complemento">Complemento</label>
          <input
            type="text"
            id="configuracoes-input-complemento"
            v-model="configs.complemento"
          />
        </b-col>
        <b-col>
          <label for="configuracoes-input-bairro">Bairro</label>
          <input type="text" id="configuracoes-input-bairro" v-model="configs.bairro" />
        </b-col>
      </b-row>
      <b-row>
        <b-col>
          <label for="configuracoes-input-cidade">Cidade</label>
          <input type="text" id="configuracoes-input-cidade" v-model="configs.cidade" />
        </b-col>
        <b-col>
          <label for="configuracoes-input-estado">Estado</label>
          <input type="text" id="configuracoes-input-estado" v-model="configs.estado" />
        </b-col>
        <b-col>
          <label for="configuracoes-input-telefone">Telefone</label>
          <input
            type="text"
            id="configuracoes-input-telefone"
            v-model="configs.telefone"
          />
        </b-col>
      </b-row>
      <b-row>
        <b-col>
          <label for="configuracoes-input-whatsapp">WhatsApp</label>
          <input
            type="text"
            id="configuracoes-input-whatsapp"
            v-model="configs.whatsapp"
          />
        </b-col>
        <b-col>
          <label for="configuracoes-input-email">E-mail</label>
          <input type="text" id="configuracoes-input-email" v-model="configs.email" />
        </b-col>
        <b-col>
          <label for="configuracoes-input-facebook">Facebook</label>
          <input
            type="text"
            id="configuracoes-input-facebook"
            v-model="configs.facebook"
          />
        </b-col>
      </b-row>
      <b-row>
        <b-col>
          <label for="configuracoes-input-instagram">Instagram</label>
          <input
            type="text"
            id="configuracoes-input-instagram"
            v-model="configs.instagram"
          />
        </b-col>
        <b-col>
          <label for="configuracoes-input-linkedin">Linkedin</label>
          <input
            type="text"
            id="configuracoes-input-linkedin"
            v-model="configs.linkedin"
          />
        </b-col>
        <b-col>
          <label for="configuracoes-input-youtube">Youtube</label>
          <input type="text" id="configuracoes-input-youtube" v-model="configs.youtube" />
        </b-col>
      </b-row>
      <div class="mt-4">
        <div class="float-right">
          <button class="btn-cancelar mr-2">Cancelar</button>
          <button class="btn-salvar">Salvar</button>
        </div>
      </div>
    </b-container>

    <h3 class="mt-4"><strong>Configurações do rodapé</strong></h3>
    <b-container id="configuracoes-contato-rodape" class="w-100 p-4 configuracoes-forms"
      ><b-row>
        <b-col>
          <label for="configuracoes-input-rodape"><strong>Mostrar rodapé</strong></label>
          <select>
            <option value="true">Sim</option>
            <option value="false">Não</option>
          </select>
        </b-col>
        <b-col>
          <label for="configuracoes-input-complemento">Cor fundo</label>
          <input
            type="text"
            id="configuracoes-input-complemento"
            v-model="configs.complemento"
          />
        </b-col>
        <b-col>
          <label for="configuracoes-input-bairro">Bairro</label>
          <input type="text" id="configuracoes-input-bairro" v-model="configs.bairro" />
        </b-col>
      </b-row>
    </b-container>
  </div>
</template>
<script>
import { mapActions, mapGetters } from "vuex";

export default {
  data() {
    return {
      configs: "",
    };
  },
  computed: {
    ...mapGetters({
      configuracoes: "configuracoes/configuracoes",
    }),
  },
  watch: {
    configuracoes: function (newVal, oldVal) {
      console.log("newVal");
      console.log(newVal);
      if (newVal != null) {
        this.configs = Object.assign({}, newVal);
      }
    },
  },
  methods: {
    ...mapActions({
      getConfiguracoes: "configuracoes/getConfiguracoes", //also supports payload `this.nameOfAction(amount)`
    }),
  },

  created() {
    this.getConfiguracoes();
  },
};
</script>
<style>
.configuracoes-forms {
  background: white;
  display: grid;
}
.configuracoes-forms .col {
  display: grid;
}
.configuracoes-forms label {
  margin: 22px 5px 2px 5px;
}

.configuracoes-forms input {
  border-bottom: thin 2px;
  border-top: none;
  border-left: none;
  border-right: none;
}
.configuracoes-forms input:focus {
  outline: none;
}
</style>
