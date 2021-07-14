using SD_WebSite_DashBoardApi.Models;
using SD_WebSite_DashBoardApi.Repositorio.Generic;
using SD_WebSite_DashBoardApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Business.BusinessImplementation
{
    public class AdministradorBusiness : IAdminstradorBusiness
    {
        private readonly IGenericRepository<Administrador> _genericRepository;
        private readonly IAdministradorRepository _administradorRepository;

        public AdministradorBusiness(IGenericRepository<Administrador> genericRepository, IAdministradorRepository administradorRepository)
        {
            _genericRepository = genericRepository;
            _administradorRepository = administradorRepository;
        }

        public Administrador FindByUser(string user, string password)
        {
            return _administradorRepository.GetAdministrador(user, password);
                }
        public Administrador Create(Administrador pagina)
        {
            return _genericRepository.Create(pagina);
        }

        public void Delete(long id)
        {
            _genericRepository.Delete(id);
        }

        public List<Administrador> FindAll()
        {
            return _genericRepository.FindAll();
        }

        public Administrador FindById(long id)
        {
            return _genericRepository.FindById(id);
        }



        public Administrador Update(Administrador pagina)
        {
            return _genericRepository.Update(pagina);
        }
    }
}
