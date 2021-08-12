using SD_WebSite_DashBoardApi.Models;
using SD_WebSite_DashBoardApi.Models.Context;
using System;
using System.Linq;

namespace SD_WebSite_DashBoardApi.Repository.RepositoryImplementation
{
    public class ConfiguracaoRepository : IConfiguracaoRepository
    {
        private readonly MyDbContext dbContext;

        public ConfiguracaoRepository(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public object FindById(int id)
        {

            try
            {

                    var administrador = dbContext.Administrador.FirstOrDefault(admin=>admin.Id == id);
                return new
                {
                    Contato = dbContext.Contato.FirstOrDefault(contato => contato.Administrador== administrador),
                    Rodape = dbContext.Rodape.FirstOrDefault(rodape => rodape.Administrador == administrador)
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
