using booking.Common.Models;
using booking.Infrastructure.Reposytory.Interfacies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking.Infrastructure.Reposytory.Implementations
{
    public class HotelRepository : IHotelRepository
    {
        private ApplicationContext context;

        public HotelRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public Hotel GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Hotel> GetHotels()
        {
            throw new NotImplementedException();
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
