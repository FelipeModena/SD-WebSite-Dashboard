using SD_WebSite_DashBoardApi.Data;
using SD_WebSite_DashBoardApi.Models;
using System.Collections.Generic;

namespace SD_WebSite_DashBoardApi
{
    public interface IConfiguracaoBusiness
    {
        object FindLast();
        void Delete(long id);
        object UpdateRodape(Rodape rodape);
        object UpdateContato(Contato contato);
    }
}