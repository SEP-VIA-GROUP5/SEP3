using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Data.Impl
{
    public class UserService : IUserService
    {
        private readonly HttpClient Client = new HttpClient();
        private readonly string Uri = "http://localhost:8080";
        
        //Test for getting a receipt for a specific user
        public async Task<User> GetUser(string username)
        {
            HttpResponseMessage responseMessage =
                await Client.GetAsync($"http://localhost:8080/user/getter?username={username}");
            if (responseMessage.StatusCode == HttpStatusCode.NotFound)
            {
                throw new Exception("User not found");
            }

            if (responseMessage.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new Exception("Problems with connection with database");
            } 
            string userAsJson = await responseMessage.Content.ReadAsStringAsync();
            User resultUser = JsonSerializer.Deserialize<User>(userAsJson); 
            return resultUser;
        }
        
        public async Task<User> ValidateLogin(string username, string password)
        {
            HttpResponseMessage responseMessage =
                await Client.GetAsync($"http://localhost:8080/user/login?username={username}&password={password}");
            if (responseMessage.StatusCode == HttpStatusCode.NotFound)
            {
                throw new Exception("User not found");
            }

            if (responseMessage.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new Exception("Problems with connection with database");
            } 
            string userAsJson = await responseMessage.Content.ReadAsStringAsync();
            User resultUser = JsonSerializer.Deserialize<User>(userAsJson); 
            return resultUser;
        }
        public async Task<User> RegisterUserAsync(string username, string password, string firstName, string lastName)
        {
            string userAsJson = null;
            Console.WriteLine("Registering...");
            HttpResponseMessage responseMessage =
                await Client.GetAsync($"http://localhost:8080/user/register?username={username}&password={password}&firstname={firstName}&lastname={lastName}");
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                userAsJson = await responseMessage.Content.ReadAsStringAsync();
                User resultUser = JsonSerializer.Deserialize<User>(userAsJson);
                return resultUser; //EXPECTED A USUAL USER TO BE RETURNED
            }

            return null;
        }

        public async Task<User> EditUser(int ID, string username, string photo, string firstName, string lastName)
        {
            string userAsJson = null;
            Console.WriteLine("Editing...");
            HttpResponseMessage responseMessage =
                await Client.GetAsync($"http://localhost:8080/user/edit?ID={ID}&username={username}&photo={photo}&firstname={firstName}&lastname={lastName}");
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                userAsJson = await responseMessage.Content.ReadAsStringAsync();
                User resultUser = JsonSerializer.Deserialize<User>(userAsJson);
                return resultUser; //EXPECTED A USUAL USER TO BE RETURNED
            }

            return null;
        }
        public async Task<User> ChangePassword(string username, string password)
        {
            string userAsJson = null;
            Console.WriteLine("Changing password...");
            HttpResponseMessage responseMessage =
                await Client.GetAsync($"http://localhost:8080/user/changePassword?username={username}&password={password}");
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                userAsJson = await responseMessage.Content.ReadAsStringAsync();
                User resultUser = JsonSerializer.Deserialize<User>(userAsJson);
                return resultUser; //EXPECTED A USUAL USER TO BE RETURNED
            }
            return null;
        }
    }
}