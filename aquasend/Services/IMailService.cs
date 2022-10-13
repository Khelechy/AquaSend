using aquasend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aquasend.Services
{
    public interface IMailService
    {
        Task SendMailAsync(User user, string toEmail, string subject, string content, bool sendAsync = true);
    }
}
