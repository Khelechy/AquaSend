using aquasend.Models;
using aquasend.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aquasend.Services
{
    public interface IRequestService
    {
        Task<IEnumerable<Request>> GetAllRequest();

        Task<IEnumerable<Request>> GetUserRequest(string userId);
        Task<Request> GetRequestById(int id);
        Task<bool> AcceptRequest(int id, string driverId);
        Task<bool> RejectRequest(int id);
        Task<Tuple<bool, string>> CreateRequest(RequestViewModel request);
    }
}
