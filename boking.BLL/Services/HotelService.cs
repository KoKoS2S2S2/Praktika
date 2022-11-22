using booking.Common.Models;
using booking.Infrastructure.Reposytory.Interfacies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boking.BLL.Services
{
    public class HotelService
    {
        private IHotelRepository hotelRepository;

        public HotelService(IHotelRepository hotelRepository)
        {
            this.hotelRepository = hotelRepository;
        }

        public List<Hotel> GetHotels()
        {
            return hotelRepository.GetHotels();
        }
    }
}
