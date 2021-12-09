using System;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Data
{
    public interface IUserService
    {
        Task<User> GetUser(string username);
        Task<User> ValidateLogin(string username, string password);
        
        Task<User> RegisterUserAsync(User user);
        Task<User> EditUser(User user);
        Task<User> ChangePassword(User user);
    }
}