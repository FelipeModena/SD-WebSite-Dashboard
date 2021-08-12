using SD_WebSite_DashBoardApi.Models;

namespace SD_WebSite_DashBoardApi.Repository
{
    public interface IConfiguracaoRepository
    {
         object FindById(int id);
        object UpdateRodape(Rodape rodape);
        object UpdateContato(Contato contato);
    }
}