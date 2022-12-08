using MyBankApp.Data.Entities;

namespace MyBankApp.Data.Interfaces
{
    public interface IAccountRepository
    {
        void Create(Account account);
    }
}
