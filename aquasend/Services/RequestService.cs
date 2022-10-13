using aquasend.Data;
using aquasend.Models;
using aquasend.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aquasend.Services
{
    public class RequestService : IRequestService
    {
        private readonly AquaContext _context;
        private readonly IUserService _userService;
        private readonly IMailService _mailService;

        public RequestService(AquaContext context, IUserService userService, IMailService mailService)
        {
            _context = context;
            _userService = userService;
            _mailService = mailService;
        }

        public async Task<bool> SaveChanges()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
        public async Task<bool> AcceptRequest(int id, string driverId)
        {
            var request = _context.Requests.FirstOrDefault(r => r.Id == id);
            request.RequestStatus = Enums.RequestEnum.accepted;
            request.DriverId = driverId;
            var user = await _userService.GetUserById(request.UserId.ToString());
            var driver = await _userService.GetUserById(driverId.ToString());
            request.DriverEmail = driver.Email;  
           
            _context.Update(request);   
            var isAcceptedt = await SaveChanges();
            if (isAcceptedt)
            {
                await _mailService.SendMailAsync(driver, driver.Email, "One new delivery", $"You have a water delivery to make to {user.FirstName} with phone number {user.PhoneNumber} at address {request.Address} .");
                await _mailService.SendMailAsync(user, user.Email, "Request Accepted", $"Your water delivery request has been accepted and the tank driver with name {driver.FirstName} and phone number {driver.PhoneNumber} is coming to your address.");
            }
            return isAcceptedt;
        }

        public async Task<bool> RejectRequest(int id)
        {
            var request = await _context.Requests.FirstOrDefaultAsync(r => r.Id == id);
            request.RequestStatus = Enums.RequestEnum.rejected;
            var user = await _userService.GetUserById(request.UserId.ToString());
           
            var isRejected = await SaveChanges();
            if (isRejected)
            {
                await _mailService.SendMailAsync(user, user.Email, "Request Rejected", $"Your water delivery request has been rejected.");
            }
            return isRejected;
        }

        public async Task<Tuple<bool, string>> CreateRequest(RequestViewModel request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var userId = _userService.GetUserId();
            var hasActiveRequest = await _context.Requests.FirstOrDefaultAsync(r => r.UserId == userId && r.RequestStatus == Enums.RequestEnum.pending);
            if(hasActiveRequest != null)
            {
                return new Tuple<bool, string>(false, "User has a pending request");
            }
            var admin = await _context.Users.FirstOrDefaultAsync(x => x.IsAdmin == true); 
            var req = new Request
            {
                Address = request.Address,
                RequestStatus = Enums.RequestEnum.pending,
                RequestDate = DateTime.Now,
                UserId = userId,
            };
            await _context.Requests.AddAsync(req);
            var isCreated = await SaveChanges();
            if (isCreated)
            {
                await _mailService.SendMailAsync(admin, admin.Email, "New Water Delivery Request", $"Anew water delivery request has been logged.");
            }
            return new Tuple<bool, string>(isCreated, "Request is succesfully logged, you will assigned a driver on approval");
        }

        public async Task<IEnumerable<Request>> GetAllRequest()
        {
            return await _context.Requests
                .Include(u => u.User)
                .ToListAsync();
        }

        public async Task<Request> GetRequestById(int id)
        {
            return await _context.Requests.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<IEnumerable<Request>> GetUserRequest(string userId)
        {
            return await _context.Requests.Where(x => x.UserId == userId).ToListAsync();
        }
    }
}
