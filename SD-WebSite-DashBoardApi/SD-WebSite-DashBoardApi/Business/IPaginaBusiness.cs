using SD_WebSite_DashBoardApi.Models;
using System.Collections.Generic;

namespace SD_WebSite_DashBoardApi.Business
{
    public interface IPaginaBusiness
    {
        object FindAllPagesAndComponents();
        object UpdatePages(List<Pagina> paginas);
        object UpdatePage(Pagina pagina);
    }
}
