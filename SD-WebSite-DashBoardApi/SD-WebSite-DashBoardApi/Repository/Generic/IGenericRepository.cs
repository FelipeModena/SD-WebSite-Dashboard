using SD_WebSite_DashBoardApi.Models.Base;
using System.Collections.Generic;

namespace SD_WebSite_DashBoardApi.Repositorio.Generic
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindById(long id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long id);
        bool Exists(long id);
    }
}