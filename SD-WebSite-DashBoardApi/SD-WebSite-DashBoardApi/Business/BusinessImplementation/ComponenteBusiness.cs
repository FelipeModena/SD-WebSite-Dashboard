using SD_WebSite_DashBoardApi.Models;
using SD_WebSite_DashBoardApi.Repositorio.Generic;
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

        public ComponenteBusiness(IGenericRepository<Componente> genericRepository, IGenericRepository<Log> logGeneric)
        {
            _genericRepository = genericRepository;
            _logGeneric = logGeneric;
        }

        public object UpdateComponente(Componente componente)
        {
            try
            {
            _genericRepository.Update(componente);
            return new {msg= "Componente " + componente.TipoComponente + " atualizado com sucesso" };
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
