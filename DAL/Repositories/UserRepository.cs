using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Repositories
{
    public class UserRepository
    {
        BookManagementDbContext _context;

        public UserAccount checkLogin(string email, string password)
        {
            _context = new();
            var user = _context.UserAccounts.FirstOrDefault(user => email == user.Email && password == user.Password);
            return user;
        }
    }
}
