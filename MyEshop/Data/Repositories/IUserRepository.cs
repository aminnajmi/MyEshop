using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyEshop.Models;

namespace MyEshop.Data.Repositories
{
    public interface IUserRepository
   {
       bool IsExistUserByEmail(string email);
       void AddUser(Users user);
       Users GetUserForLogin(string email, string password);
   }

}
