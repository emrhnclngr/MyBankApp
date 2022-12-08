using System.Collections.Generic;
using System.Linq;

namespace MyBankApp.Data.Interfaces
{
    public interface IRepository<T> where T : class, new()
    {
        void Create(T entity);
        void Remove(T entitiy);
        List<T> GetAll();
        T GetById(object id);
        void Update(T entity);
        IQueryable<T> GetQueryable();
    }
}
