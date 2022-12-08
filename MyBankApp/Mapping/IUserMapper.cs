using MyBankApp.Data.Entities;
using MyBankApp.Models;
using System.Collections.Generic;

namespace MyBankApp.Mapping
{
    public interface IUserMapper
    {
        List<UserListModel> MapToListOfUserList(List<ApplicationUser> users);
        UserListModel MapToUserList(ApplicationUser user);
    }
}
