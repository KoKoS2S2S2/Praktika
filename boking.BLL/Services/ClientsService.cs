using booking.Common.Models;
using booking.Infactructury.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boking.BLL.Services
{
    public class ClientsService
    {
        private IClientsRepository clientsRepository;

        public ClientsService(IClientsRepository clientsRepository)
        {
            this.clientsRepository = clientsRepository;
        }

        public List<Clients> GetUsers()
        {
            return clientsRepository.GetClients();
        }
    }
}
