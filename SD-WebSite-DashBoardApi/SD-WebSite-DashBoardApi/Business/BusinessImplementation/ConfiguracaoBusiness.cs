using SD_WebSite_DashBoardApi.Models;
using SD_WebSite_DashBoardApi.Repositorio.Generic;
using SD_WebSite_DashBoardApi.Repository;
using System;

namespace SD_WebSite_DashBoardApi.Business.BusinessImplementation
{
    public class ConfiguracaoBusiness:IConfiguracaoBusiness
    {
        private readonly IConfiguracaoRepository configuracaoRepository;
        public ConfiguracaoBusiness(IConfiguracaoRepository configuracaoRepository = null)
        {
            this.configuracaoRepository = configuracaoRepository;
        }


        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public object FindByID(int id)
        {
            
            return configuracaoRepository.FindById(id);
        }

        public object UpdateRodape(Rodape rodape)
        {
            return configuracaoRepository.UpdateRodape(rodape);
        }
        public object UpdateContato(Contato contato)
        {
            return configuracaoRepository.UpdateContato(contato);
        }
    }
}
