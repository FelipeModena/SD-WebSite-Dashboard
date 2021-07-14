using SD_WebSite_DashBoardApi.Data;
using SD_WebSite_DashBoardApi.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Repository.RepositoryImplementation
{
    public class ConfiguracaoRepository: IConfiguracaoRepository
    {
        private readonly MyDbContext dbContext;

        public ConfiguracaoRepository(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public object FindLast()
        {
            //var config = new RodapeContatoVO {
            //    Contato =  dbContext.Contato.OrderBy(c=>c.Modificacao).Last(),
            //    Rodape = dbContext.Rodape.OrderBy(c => c.Modificacao).Last()
            //};
            return new {};
        }

        public RodapeContatoVO GetByDate(RodapeContatoVO configuracao)
        {
            throw new NotImplementedException();
        }
    }
}
