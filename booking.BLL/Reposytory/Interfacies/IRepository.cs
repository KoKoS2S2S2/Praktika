using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking.Infrastructure.Reposytory.Interfacies
{
    namespace booking.Infactructury.Interfaces
    {
        public interface IRepository<T> where T : class
        {
            public Task<T?> GetOneAsync(string id);
            public Task CreateAsync(T newModel);
            public Task UpAsync(T updatedModel);
            public Task DeleteAsync(string id);
        }
    }
}
