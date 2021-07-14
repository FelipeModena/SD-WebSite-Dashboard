using SD_WebSite_DashBoardApi.Repository;
using System;

namespace SD_WebSite_DashBoardApi.Business.BusinessImplementation
{
    public class ConfiguracaoBusiness:IConfiguracaoBusiness
    {
        private readonly IConfiguracaoRepository configuracaoRepository;
        public ConfiguracaoBusiness( IConfiguracaoRepository configuracaoRepository = null)
        {
            this.configuracaoRepository = configuracaoRepository;
        }


        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public object FindLast()
        {
           return configuracaoRepository.FindLast();
        }

        public object Update(RodapeContatoVO configuracao)
        {
            return configuracaoRepository.GetByDate(configuracao);
        }
    }
}
