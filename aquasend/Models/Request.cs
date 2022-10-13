using aquasend.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aquasend.Models
{
    public class Request
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string DriverId { get; set; }
        public User User { get; set; }
        public string DriverEmail { get; set; }
        public string Address { get; set; }
        public DateTime RequestDate { get; set; }
        public RequestEnum RequestStatus { get; set; } = RequestEnum.pending;
    }
}
