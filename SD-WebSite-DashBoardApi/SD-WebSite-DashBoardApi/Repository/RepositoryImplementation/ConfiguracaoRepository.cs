using SD_WebSite_DashBoardApi.Data;
using SD_WebSite_DashBoardApi.Models;
using SD_WebSite_DashBoardApi.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Repository.RepositoryImplementation
{
    public class ConfiguracaoRepository : IConfiguracaoRepository
    {
        private readonly MyDbContext dbContext;

        public ConfiguracaoRepository(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public object FindLast()
        {

            try
            {
               
                return new
                {
                    Contato = dbContext.Contato.OrderBy(c => c.Modificacao).Last(),
                    Rodape = dbContext.Rodape.OrderBy(c => c.Modificacao).Last()
                };
            }
            catch (Exception)
            {

                throw;
            }

        }

        public object UpdateContato(Contato contato)
        {
            try
            {
                contato.Modificacao = System.DateTime.Now;
                dbContext.Contato.Update(contato);

                dbContext.SaveChanges();
            return new { status="Contato atualizado com sucesso" };
            }
            catch (Exception)
            {

                throw;
            }
        }

        public object UpdateRodape(Rodape rodape)
        {
            try
            {
                rodape.Modificacao = System.DateTime.Now;
                dbContext.Rodape.Update(rodape);

                dbContext.SaveChanges();
                return new { status = "Rodape atualizado com sucesso" };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
