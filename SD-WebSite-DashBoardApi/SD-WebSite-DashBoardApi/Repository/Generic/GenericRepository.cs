using Microsoft.EntityFrameworkCore;
using SD_WebSite_DashBoardApi.Models.Base;
using SD_WebSite_DashBoardApi.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Repositorio.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T:BaseEntity
    {
        private MyDbContext _mySqlContext;
        private DbSet<T> dataSet;

        public GenericRepository(MyDbContext mySqlContext)
        {
            _mySqlContext = mySqlContext;
            dataSet = _mySqlContext.Set<T>();
        }

        public T Create(T item)
        {
            try
            {
                dataSet.Add(item);
                _mySqlContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return item;
        }

        public void Delete(long id)
        {
            var result = dataSet.SingleOrDefault(personDb => personDb.Id == id);
            if (result != null)
            {
                try
                {
                    dataSet.Remove(result);
                    _mySqlContext.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public bool Exists(long id)
        {
            if (dataSet.FirstOrDefault(person => person.Id == id) != null)
            {
                return true;
            }
            else return false;
        }

        public List<T> FindAll()
        {
            return dataSet.ToList();
        }

        public T FindById(long id)
        {
            return dataSet.SingleOrDefault(personDb => personDb.Id == id);
        }

        public T Update(T item)
        {
            var result = dataSet.SingleOrDefault(personDb => personDb.Id == item.Id);
            if (result != null)
            {
                try
                {
                    _mySqlContext.Entry(result).CurrentValues.SetValues(item);
                    _mySqlContext.SaveChanges();
                    return result;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                return null;
            }
        }

    }
}
