using MyBankApp.Data.Context;
using System.Collections.Generic;
using MyBankApp.Data.Interfaces;
using System.Linq;

namespace MyBankApp.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T: class,new()
    {
        private readonly BankContext _context;

        public Repository(BankContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public List<T> GetAll()
        {
           return _context.Set<T>().ToList();
        }

        public T GetById(object id)
        {
            return _context.Set<T>().Find(id);
        }

        public IQueryable<T> GetQueryable()
        {
            return _context.Set<T>().AsQueryable();
        }

        public void Remove(T entitiy)
        {
            _context.Set<T>().Remove(entitiy);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            
        }
    }
}
