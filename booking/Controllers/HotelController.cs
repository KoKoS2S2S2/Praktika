using boking.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private HotelService hotelService;

        public HotelController(HotelService hotelService)
        {
            this.hotelService = hotelService;
        }

        [HttpGet]
        [Route("GetAll")]
        public Task<IActionResult> GetAllMeetups()
        {
            var meetups = this.hotelService
                .GetHotels();

            if (meetups is not null)
            {
                return Ok(meetups);
            }

            return BadRequest();
        }
    }
}
