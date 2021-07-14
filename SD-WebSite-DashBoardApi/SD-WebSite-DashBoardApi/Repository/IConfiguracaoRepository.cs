using SD_WebSite_DashBoardApi.Data;

namespace SD_WebSite_DashBoardApi.Repository
{
    public interface IConfiguracaoRepository
    {
        public RodapeContatoVO GetByDate(RodapeContatoVO configuracao);
        object FindLast();
    }
}