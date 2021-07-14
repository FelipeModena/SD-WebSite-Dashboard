using SD_WebSite_DashBoardApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Repository
{
    public interface IAdministradorRepository
    {
        public Administrador GetAdministrador(string user,string password);
    }
}
