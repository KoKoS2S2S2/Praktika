using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using booking.Common.Models;
using booking.Infrastructure.Reposytory.Interfacies.booking.Infactructury.Interfaces;

namespace booking.Infactructury.Interfaces
{
    public interface IClientsRepository : IRepository<Clients>
    {
        public List<Clients> GetClients();
    }
}
