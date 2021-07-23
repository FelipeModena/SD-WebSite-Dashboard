using SD_WebSite_DashBoardApi.Models;
using SD_WebSite_DashBoardApi.Models.Context;
using SD_WebSite_DashBoardApi.Repositorio.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Repository.RepositoryImplementation
{
    public class ComponenteRepository : IComponenteRepository
    {
        private readonly MyDbContext dbContext;
        private readonly IGenericRepository<Log> _logGeneric;

        public ComponenteRepository(MyDbContext dbContext, IGenericRepository<Log> logGeneric = null)
        {
            this.dbContext = dbContext;
            _logGeneric = logGeneric;
        }

        public object Update(Componente componente)
        {

            try
            {
                var result = dbContext.Componente.SingleOrDefault(comp => comp.Id == componente.Id);
                Imagem imgDb;
                if (result != null)
                {
                    dbContext.Entry(result).CurrentValues.SetValues(componente);

                    if (componente.Imagens != null)
                    {
                        foreach (var imagem in componente.Imagens)
                        {
                            if (imagem.Compatibilidade != "" || imagem.ImgUrl != "")
                            {
                                imagem.Componente = result;
                                imgDb = dbContext.Imagem.Find(imagem.Id);
                                if (imgDb == null)
                                {
                                    imagem.Id = 0;
                                    dbContext.Imagem.Add(imagem);
                                }
                                else
                                {
                                    dbContext.Entry(imgDb).CurrentValues.SetValues(imagem);
                                }
                            }
                        }
                    }
                    dbContext.SaveChanges();
                    return new Imagem { };


                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Log log = new Log()
                {
                    Data = System.DateTime.Now,
                    Error = e.InnerException.ToString(),
                    Table = "Componente"
                };
                _logGeneric.Create(log);
            }
            return componente;
        }

    }
}
