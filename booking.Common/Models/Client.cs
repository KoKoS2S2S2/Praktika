using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking.Common.Models
{
    public class Clients
    {
        public int id_Client { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Citizenship { get; set; }
        public string Birtday { get; set; }
        public string Email { get; set; }
    }
}
