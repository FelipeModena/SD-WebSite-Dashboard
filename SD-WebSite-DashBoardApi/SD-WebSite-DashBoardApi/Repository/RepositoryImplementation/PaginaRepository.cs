using Microsoft.EntityFrameworkCore;
using SD_WebSite_DashBoardApi.Models;
using SD_WebSite_DashBoardApi.Models.Context;
using System.Collections.Generic;

namespace SD_WebSite_DashBoardApi.Repository.RepositoryImplementation
{
    public class PaginaRepository : IPaginaRepository
    {
        MyDbContext _myDbContext;

        public PaginaRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }



        public object FindAllPagesAndComponents()
        {
            var paginas = _myDbContext.Pagina.Include(c=>c.Componente);
            return paginas;
        }

        public object UpdatePages(List<Pagina> paginas)
        {
            foreach (var pagina  in paginas)
            {
                pagina.Modificacao =System.DateTime.Now;
            }
            try
            {
                _myDbContext.Pagina.UpdateRange(paginas);
            }
            catch (System.Exception e)
            {

                _myDbContext.Log.Add(new Log {
                Data=System.DateTime.Now,
                Error = e.Message,
                Table= "Pagina",
                });
            }

                _myDbContext.SaveChanges();
            return new { };
        }
    }
}
