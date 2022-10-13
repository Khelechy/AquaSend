using aquasend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aquasend.Data
{
    public class AquaContext : IdentityDbContext<User>
    {
        public AquaContext(DbContextOptions<AquaContext> option) : base(option)
        {

        }
        public new DbSet<User> Users { get; set; }
        public DbSet<Request> Requests { get; set; }
    }
}
