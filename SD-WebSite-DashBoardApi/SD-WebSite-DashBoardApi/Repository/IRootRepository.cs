using SD_WebSite_DashBoardApi.Models;
using System.Collections.Generic;

namespace SD_WebSite_DashBoardApi.Repository
{
    public interface IRootRepository
    {
        List<Pagina> CreatePages(Administrador administrador,int modelo);
        Componente CreateComponentes(Pagina pagina, int modelo);
        Administrador CreateAdministrador(string user,string password, int modelo);
        void CreateRodapeEContato(Administrador administrador);
        void CreateImagem(List<Componente> componente);
        object DeleteUser(int id);
    }
}