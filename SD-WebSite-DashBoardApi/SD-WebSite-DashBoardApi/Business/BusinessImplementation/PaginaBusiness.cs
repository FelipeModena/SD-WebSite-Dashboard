using SD_WebSite_DashBoardApi.Models;
using SD_WebSite_DashBoardApi.Repositorio.Generic;
using SD_WebSite_DashBoardApi.Repository;
using System.Collections.Generic;

namespace SD_WebSite_DashBoardApi.Business.BusinessImplementation
{
    public class PaginaBusiness : IPaginaBusiness
    {
        private readonly IPaginaRepository paginaRepository;

        public PaginaBusiness( IPaginaRepository paginaRepository = null)
        {
            this.paginaRepository = paginaRepository;
        }


        public object FindAllPagesAndComponents()
        {
            return paginaRepository.FindAllPagesAndComponents();
        }


        public object UpdatePages(List<Pagina> paginas)
        {
            
            return paginaRepository.UpdatePages(paginas);
        }
    }
}
