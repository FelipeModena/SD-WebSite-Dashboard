using SD_WebSite_DashBoardApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Business
{
    public interface IAdminstradorBusiness
    {
        Administrador Create(Administrador administrador);
        Administrador FindById(long id);
        Administrador FindByUser(string user,string password);
        List<Administrador> FindAll();
        Administrador Update(Administrador administrador);
        void Delete(long id);
    }
}
