using booking.Infrastructure.Reposytory.Interfacies.booking.Infactructury.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using booking.Common.Models;

namespace booking.Infactructury.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        public Task<User?> GetOneAsync(string login);
        public Task<User?> GetOneLoginAndPasswordAsync(string login, string password);
        public List<User> GetUsers();

    }
}