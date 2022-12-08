using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyBankApp.Data.Context;
using MyBankApp.Data.Entities;
using MyBankApp.Data.Interfaces;
using MyBankApp.Data.Repositories;
using MyBankApp.Data.UnitOfWork;
using MyBankApp.Mapping;
using MyBankApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyBankApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUow _uow;
        private readonly IUserMapper _userMapper;

        public HomeController(IUserMapper userMapper, IUow uow)
        {

            _userMapper = userMapper;
            _uow = uow;
        }

        public IActionResult Index()
        {
            return View(_userMapper.MapToListOfUserList(_uow.GetRepository<ApplicationUser>().GetAll()));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
