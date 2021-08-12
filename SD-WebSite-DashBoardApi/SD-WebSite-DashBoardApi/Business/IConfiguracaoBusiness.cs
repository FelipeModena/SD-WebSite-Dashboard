using SD_WebSite_DashBoardApi.Models;

namespace SD_WebSite_DashBoardApi
{
    public interface IConfiguracaoBusiness
    {
        object FindByID(int id);
        void Delete(long id);
        object UpdateRodape(Rodape rodape);
        object UpdateContato(Contato contato);
    }
}