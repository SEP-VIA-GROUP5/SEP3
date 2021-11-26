using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Client.Models;
using Microsoft.AspNetCore.Http;

namespace Client.Data.Impl
{
    public class UserService : IUserService
    {
        private readonly HttpClient Client = new HttpClient();
        private readonly string Uri = "http://localhost:8080";
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
        public async Task RegisterUserAsync(User user)
        {
            string userAsJson = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(userAsJson,
                Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage =
                await Client.PostAsync("https://localhost:8080/user/register", content);
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception("User could not be registered.");
            }
            Console.WriteLine("User " + user.Username + " successfully registered.");
        }
    }
}