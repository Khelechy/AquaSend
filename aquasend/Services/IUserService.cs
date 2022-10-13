using aquasend.Models;
using aquasend.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aquasend.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsers(string searchString = "");
        Task<IEnumerable<User>> GetAllDrivers(string searchString = "");

        Task<Tuple<bool, string>> AddDriver(RegisterModel userModel);    
        Task<User> GetUserById(string id);
        Task<User> GetUser();
        Task<Tuple<bool, string>> ChangePasswordAsync(ChangePasswordViewModel model);
        Task<Tuple<bool, string, User>> UpdateProfileAsync(UpdateProfileViewModel user);
        Task<Tuple<string, User>> Login(string email, string password);
        Task<Tuple<bool, string>> Register(RegisterModel userModel);
        Task<Statistics> LoadStatistics();

        Task DeleteUser(string id);    
        string GetUserId();
        bool SaveChanges();
    }
}
