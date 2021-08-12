using SD_WebSite_DashBoardApi.Models;
using SD_WebSite_DashBoardApi.Repositorio.Generic;
using SD_WebSite_DashBoardApi.Repository;
using System.Collections.Generic;

namespace SD_WebSite_DashBoardApi.Business.BusinessImplementation
{
    public class PaginaBusiness : IPaginaBusiness
    {
        private readonly IPaginaRepository paginaRepository;
        private readonly IGenericRepository<Pagina> _genericRepository;
        private readonly IConfiguracaoRepository _configuracaoRepository;
        public PaginaBusiness(IPaginaRepository paginaRepository = null, IGenericRepository<Pagina> genericRepository = null, IConfiguracaoRepository configuracaoRepository = null)
        {
            this.paginaRepository = paginaRepository;
            _genericRepository = genericRepository;
            _configuracaoRepository = configuracaoRepository;
        }


        public object FindAllPagesAndComponents(int idAdmin)
        {
            return paginaRepository.FindAllPagesAndComponents(idAdmin);
        }

        public object GetPaginasComponentesRodapeContato(int idAdmin)
        {
            return new
            {
                paginas = paginaRepository.FindAllPagesAndComponents(idAdmin),
                contatoRodape = _configuracaoRepository.FindById(idAdmin)
            };
        }

        public object UpdatePage(Pagina pagina)
        {
            Pagina page = _genericRepository.Update(pagina);
            if (page != null)
            {
                return "Pagina " + page.NomePagina + " atualizada";
            }
            return _genericRepository.Update(pagina);
        }

        public object UpdatePages(List<Pagina> paginas)
        {

            return paginaRepository.UpdatePages(paginas);
        }


    }
}
