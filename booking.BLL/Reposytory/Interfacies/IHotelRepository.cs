using booking.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking.Infrastructure.Reposytory.Interfacies
{
    public interface IHotelRepository
    {
        public List<Hotel> GetHotels();

        public Hotel GetById(int Id);

        public Hotel UpdateHotel(Hotel hotel);
    }
    
}
