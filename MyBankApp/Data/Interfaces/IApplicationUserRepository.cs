using MyBankApp.Data.Entities;
using System.Collections.Generic;

namespace MyBankApp.Data.Interfaces
{
    public interface IApplicationUserRepository
    {
        public List<ApplicationUser> GetAll();
        public ApplicationUser GetById(int id);
    }
}
