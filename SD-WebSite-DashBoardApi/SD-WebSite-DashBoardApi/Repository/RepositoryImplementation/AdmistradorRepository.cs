using SD_WebSite_DashBoardApi.Models;
using SD_WebSite_DashBoardApi.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Repository.RepositoryImplementation
{
    public class AdmistradorRepository : IAdministradorRepository
    {
        private readonly MyDbContext _dbContext;

        public AdmistradorRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Administrador GetAdministrador(string user, string password)
        {
            Administrador administrador = _dbContext.Administrador.FirstOrDefault(admin => admin.Usuario == user && admin.Password == password);
        return administrador;
        }
    }
}
