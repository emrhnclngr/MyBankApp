﻿using MyBankApp.Data.Context;
using MyBankApp.Data.Entities;
using MyBankApp.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MyBankApp.Data.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly BankContext _context;

        public ApplicationUserRepository(BankContext context)
        {
            _context = context;
        }

       

        public ApplicationUser GetById(int id)
        {
           return _context.ApplicationUsers.SingleOrDefault(x => x.Id == id);
        }
        public void Create (ApplicationUser user)
        {
            _context.Set<ApplicationUser>().Add(user);
            _context.SaveChanges();
        }
        public void Remove (ApplicationUser user)
        {
            _context.Set<ApplicationUser>().Remove(user);
            _context.SaveChanges();
        }
        public List<ApplicationUser> GetAll()
        {
            return _context.Set<ApplicationUser>().ToList();
        }
    }
}
