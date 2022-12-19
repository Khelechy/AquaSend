using aquasend.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aquasend.Data
{
    public class SeedDatabase
    {
        private readonly UserManager<User> _userManager;

        public SeedDatabase(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task InitialSeed(AquaContext db)
        {
            await SeedAdmin(db);
        }

        public async Task SeedAdmin(AquaContext _db)
        {
            var user = new User();
            user.Email = "chikejoe50@gmail.com";
            user.FirstName = "Admin";
            user.LastName = "Admin";
            user.PhoneNumber = "09000000000";
            user.IsAdmin = true;
            user.UserName = user.Email;
            var result = await _userManager.CreateAsync(user, "Admin@123");
        }
    }
}
