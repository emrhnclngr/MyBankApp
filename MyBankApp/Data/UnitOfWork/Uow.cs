using MyBankApp.Data.Context;
using MyBankApp.Data.Interfaces;
using MyBankApp.Data.Repositories;

namespace MyBankApp.Data.UnitOfWork
{
    public class Uow : IUow
    {
        private BankContext _context;

        public Uow(BankContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : class, new()
        {
            return new Repository<T>(_context);
        }

        public void SaveChanges()
        {
           _context.SaveChanges();
        }
    }
}
