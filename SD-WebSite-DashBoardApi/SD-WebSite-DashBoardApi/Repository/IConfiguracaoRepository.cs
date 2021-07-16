using SD_WebSite_DashBoardApi.Data;
using SD_WebSite_DashBoardApi.Models;

namespace SD_WebSite_DashBoardApi.Repository
{
    public interface IConfiguracaoRepository
    {
         object FindLast();
        object UpdateRodape(Rodape rodape);
        object UpdateContato(Contato contato);
    }
}