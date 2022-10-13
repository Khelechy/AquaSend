using aquasend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aquasend.ViewModels
{
    public class AdminDashboardViewModel
    {
        public User User { get; set; }
        public Statistics StatisticsData { get; set; }
    }
}
