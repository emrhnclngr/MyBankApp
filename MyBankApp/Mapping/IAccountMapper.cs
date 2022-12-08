using MyBankApp.Data.Entities;
using MyBankApp.Models;

namespace MyBankApp.Mapping
{
    public interface IAccountMapper
    {
        public Account Map(AccountCreateModel model);
    }
}
