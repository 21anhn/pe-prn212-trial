using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;

namespace BLL.Services
{
    public class UserService
    {
        private UserRepository _userRepository = new();

        public bool checkUserLogin(string email, string password)
        {
            return _userRepository.checkLogin(email, password);
        }
    }
}
