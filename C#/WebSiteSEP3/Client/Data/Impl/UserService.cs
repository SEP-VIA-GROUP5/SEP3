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
        public async Task<User> ValidateLogin(string username, string password)
        {
            HttpResponseMessage responseMessage =
                await Client.GetAsync($"http://localhost:8080/user/login?username={username}&password={password}");
            String reply = await responseMessage.Content.ReadAsStringAsync();

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
            Console.WriteLine("Registering...");
            HttpResponseMessage responseMessage =
                await Client.GetAsync($"http://localhost:8080/user/register?username={username}&password={password}&firstname={firstName}&lastname={lastName}");
            String reply = await responseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(reply);
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                string userAsJson = await responseMessage.Content.ReadAsStringAsync();
                User resultUser = JsonSerializer.Deserialize<User>(userAsJson);
                return resultUser; //EXPECTED A USUAL USER TO BE RETURNED
            }

            throw new Exception("User could not be registered");
        }

    }
}