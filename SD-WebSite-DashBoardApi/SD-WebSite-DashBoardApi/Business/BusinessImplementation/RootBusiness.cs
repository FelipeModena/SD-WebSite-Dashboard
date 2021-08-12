using SD_WebSite_DashBoardApi.Models;
using SD_WebSite_DashBoardApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Business.BusinessImplementation
{
    public class RootBusiness : IRootBusiness
    {
        private readonly IRootRepository _rootRepository;

        public RootBusiness(IRootRepository rootRepository)
        {
            _rootRepository = rootRepository;
        }

        public object CreateUser(string user, string password, int modelo)
        {
            Administrador _administrador = _rootRepository.CreateAdministrador(user, password, modelo);

            _rootRepository.CreateRodapeEContato(_administrador);

            _rootRepository.CreatePages(_administrador, modelo);


            foreach (var pagina in _administrador.Pagina)
            {
                _rootRepository.CreateComponentes(pagina, modelo);
                _rootRepository.CreateImagem(pagina.Componente);

            }
            return new { administrador = _administrador };
        }

        public object DeleteUser(int id)
        {
            
            return _rootRepository.DeleteUser(id);
        }
    }
}
