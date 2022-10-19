using aquasend.Data;
using aquasend.Models;
using aquasend.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace aquasend.Services
{
    public class UserService : IUserService
    {
        private readonly AquaContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;

        public UserService(AquaContext context, UserManager<User> userManager, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
        }
        public async Task<IEnumerable<User>> GetAllDrivers(string searchString)
        {
            if (string.IsNullOrEmpty(searchString))
            {
                return await _context.Users.Where(x => x.IsAdmin == false && x.IsDriver == true).ToListAsync();
            }
            else
            {
                return await _context.Users.Where(x => x.IsDriver == true &&
                ((x.FirstName.ToLower() == searchString.ToLower())
                || (x.LastName.ToLower() == searchString.ToLower())))
                    .ToListAsync();
            }
        }

        public async Task<IEnumerable<User>> GetAllUsers(string searchString)
        {
            if (string.IsNullOrEmpty(searchString))
            {
                return await _context.Users.Where(x => x.IsAdmin == false && x.IsDriver == false && x.IsDeleted == false).ToListAsync();
            }
            else
            {
                return await _context.Users.Where(x => x.IsAdmin == false && x.IsDriver == false && x.IsDeleted == false &&
                ((x.FirstName.ToLower() == searchString.ToLower())
                || (x.LastName.ToLower() == searchString.ToLower())))
                    .ToListAsync();
            }

        }

        public async Task<User> GetUserById(string id)
        {
            return await _userManager.FindByIdAsync(id);
        }

        public async Task<Tuple<string, User>> Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                return null;
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return new Tuple<string, User>("No user with such email", null);
            var result = await _userManager.CheckPasswordAsync(user, password);
            if (!result)
            {
                return new Tuple<string, User>("Incorrect Password", null);
            }
            var token = GenerateToken(user);
            return new Tuple<string, User>(token, user); ;
        }

        public async Task<Tuple<bool, string>> Register(RegisterModel userModel)
        {
            if (userModel == null)
            {
                throw new ArgumentNullException(nameof(userModel));
            }
            var existinguser = await _userManager.FindByEmailAsync(userModel.Email);
            if (existinguser != null)
                return new Tuple<bool, string>(false, "Email already exists");

            User user = new User();
            user.Email = userModel.Email;
            user.UserName = userModel.Email;
            user.FirstName = userModel.FirstName;
            user.IsAdmin = false;
            user.IsDriver = false;
            user.LastName = userModel.LastName;
            user.PhoneNumber = userModel.PhoneNumber;

            var result = await _userManager.CreateAsync(user, userModel.Password);
            if (result.Succeeded)
                return new Tuple<bool, string>(true, "Success");
            else
                return new Tuple<bool, string>(false, result.Errors.First().Description.ToString());
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public string GetUserId()
        {
            var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return userID;
        }

        public string GenerateToken(User user)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, $"{user.FirstName} {" "} {user.LastName}"),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
            };

            if (user.IsAdmin)
            {
                claims.Add(new Claim(ClaimTypes.Role, "Admin"));
            }
            else
            {
                claims.Add(new Claim(ClaimTypes.Role, "User"));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:SecretKey"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<User> GetUser()
        {
            var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userID != null)
                return await _userManager.FindByIdAsync(userID);
            return null;
        }

        public async Task<Tuple<bool, string>> ChangePasswordAsync(ChangePasswordViewModel model)
        {
            var user = await GetUser();
            if (user == null)
                return new Tuple<bool, string>(false, "There is no account with this email");
            var isPasswordCorrect = await _userManager.CheckPasswordAsync(user, model.Password);

            if (!isPasswordCorrect)
                return new Tuple<bool, string>(false, "Incorrect Password");

            else if (model.NewPassword != model.ConfirmNewPassword)
                return new Tuple<bool, string>(false, "New Passwords do not match");

            var result = await _userManager.ChangePasswordAsync(user, model.Password, model.NewPassword);

            if (result.Succeeded)
            {
                return new Tuple<bool, string>(true, "Password Changed Succesfully");
            }
            else
                return new Tuple<bool, string>(false, result.Errors.Select(e => e.Description).ToString());
        }

        public async Task<Tuple<bool, string, User>> UpdateProfileAsync(UpdateProfileViewModel user)
        {
            var oldUser = await GetUser();
            if (user == null)
            {
                return new Tuple<bool, string, User>(false, "Unable to fetch user", null);
            }

            oldUser.FirstName = string.IsNullOrEmpty(user.Firstname) ? oldUser.FirstName : user.Firstname;
            oldUser.LastName = string.IsNullOrEmpty(user.Lastname) ? oldUser.LastName : user.Lastname; ;
            oldUser.PhoneNumber = string.IsNullOrEmpty(user.PhoneNumber) ? oldUser.PhoneNumber : user.PhoneNumber; ;

            var result = await _userManager.UpdateAsync(oldUser);
            if (result.Succeeded)
            {
                return new Tuple<bool, string, User>(true, "Profile updated successfully", oldUser);
            }
            else
            {
                return new Tuple<bool, string, User>(false, result.Errors.Select(e => e.Description).ToString(), null);
            }
        }

        public async Task<Statistics> LoadStatistics()
        {
            var totalUsers = await _context.Users.Where(u => u.IsAdmin == false && u.IsDriver == false && u.IsDeleted == false).CountAsync();
            var totalDrivers = await _context.Users.Where(u => u.IsDriver == true).CountAsync();
            var totalRequests = await _context.Requests.CountAsync();
            var pendingRequests = await _context.Requests.Where(u => u.RequestStatus == Enums.RequestEnum.pending).CountAsync();

            return new Statistics
            {
                TotalUsers = totalUsers,
                TotalDrivers = totalDrivers,
                TotalRequests = totalRequests,
                PendingRequests = pendingRequests
            };
        }

        public async Task<Tuple<bool, string>> AddDriver(RegisterModel userModel)
        {
            if (userModel == null)
            {
                throw new ArgumentNullException(nameof(userModel));
            }
            var existinguser = await _userManager.FindByEmailAsync(userModel.Email);
            if (existinguser != null)
                return new Tuple<bool, string>(false, "Email already exists");

            User user = new User();
            user.Email = userModel.Email;
            user.UserName = userModel.Email;
            user.FirstName = userModel.FirstName;
            user.IsAdmin = false;
            user.IsDriver = true;
            user.LastName = userModel.LastName;
            user.PhoneNumber = userModel.PhoneNumber;

            var result = await _userManager.CreateAsync(user, "Default@123");
            if (result.Succeeded)
                return new Tuple<bool, string>(true, "Success");
            else
                return new Tuple<bool, string>(false, result.Errors.First().Description.ToString());
        }

        public async Task DeleteUser(string id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            user.IsDeleted = true;  
            _context.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
