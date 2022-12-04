using booking.Infactructury.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boking.BLL.Services
{
    public class UserService
    {
        private IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public List<User> GetUsers()
        {
            return userRepository.GetUsers();
        }
    }
}
