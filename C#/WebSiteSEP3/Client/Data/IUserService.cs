using System;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Data
{
    public interface IUserService
    {
        //Test for getting a receipt for a specific user
        Task<User> GetUser(string username);
        Task<User> ValidateLogin(string username, string password);
        
        Task<User> RegisterUserAsync(string Username, string Password, string FirstName, string LastName);
        Task<User> EditUser(int ID, string Username, string Photo, string FirstName, string LastName);
        Task<User> ChangePassword(string Username, string Password);
    }
}