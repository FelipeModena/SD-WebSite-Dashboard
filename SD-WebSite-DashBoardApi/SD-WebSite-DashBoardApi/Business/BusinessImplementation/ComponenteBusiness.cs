using SD_WebSite_DashBoardApi.Models;
using SD_WebSite_DashBoardApi.Repositorio.Generic;
using SD_WebSite_DashBoardApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Business.BusinessImplementation
{
    public class ComponenteBusiness : IComponenteBusiness
    {
        private readonly IGenericRepository<Componente> _genericRepository;
        private readonly IGenericRepository<Log> _logGeneric;
        private readonly IComponenteRepository componenteRepository;

        public ComponenteBusiness(IGenericRepository<Componente> genericRepository, IGenericRepository<Log> logGeneric, IComponenteRepository componenteRepository)
        {
            _genericRepository = genericRepository;
            _logGeneric = logGeneric;
            this.componenteRepository = componenteRepository;
        }

        public object UpdateComponente(Componente componente)
        {
            try
            {
               var algo= componenteRepository.Update(componente);

            return new {msg= "Componente " + componente.TipoComponente + " atualizado com sucesso" ,imgs= algo };
            }
            catch (Exception e)
            {
                Log log = new Log() {
                    Data = System.DateTime.Now,
                    Error = e.InnerException.ToString(),
                    Table = "Componente"
                 };
                _logGeneric.Create(log);
                throw;
            }

        }

        public object UpdateComponentes(List<Componente> componentes)
        {
            throw new NotImplementedException();
        }
    }
}
