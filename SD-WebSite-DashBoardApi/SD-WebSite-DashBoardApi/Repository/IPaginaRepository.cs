using SD_WebSite_DashBoardApi.Models;
using System.Collections.Generic;

namespace SD_WebSite_DashBoardApi.Repository
{
    public interface IPaginaRepository
    {
        object FindAllPagesAndComponents();
        object UpdatePages(List<Pagina> paginas);
    }
}
