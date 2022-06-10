using NormativeCalculator.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Database.Authentication
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password, string firstName, string lastName);
        Task<ServiceResponse<string>> Login(string user, string password);
        Task<bool> UserExists(string username);
    }
}
