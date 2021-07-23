using SD_WebSite_DashBoardApi.Models;
using SD_WebSite_DashBoardApi.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Repository.RepositoryImplementation
{
    public class ComponenteRepository : IComponenteRepository
    {
        private readonly MyDbContext dbContext;

        public ComponenteRepository(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public object Update(Componente componente)
        {
            try
            {
                var result = dbContext.Componente.SingleOrDefault(comp => comp.Id == componente.Id);
                if (result != null)
                {
                    try
                    {
                        dbContext.Entry(result).CurrentValues.SetValues(componente);
 
                        if (componente.Imagens !=null)
                        {
                            foreach (var imagem in componente.Imagens)
                            {
                                if (imagem.Compatibilidade!="" || imagem.ImgUrl != "")
                                {
                                    imagem.Componente = result;
                                dbContext.Imagem.Add( imagem);
                                }
                            }
                        }
                        dbContext.SaveChanges();
                        return result;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
