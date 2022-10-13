using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aquasend.Models
{
    public class Statistics
    {
        public int TotalUsers { get; set; }
        public int TotalDrivers { get; set; }
        public int TotalRequests { get; set; }
        public int PendingRequests { get; set; }
    }
}
