using System;
using System.Net;
using System.Net.Http;
using System.Text;
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

        public async Task<User> RegisterUserAsync(User user)
        {
            Console.WriteLine("Registering...");
            string userAsJson = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(userAsJson,
                Encoding.UTF8,
                "application/json");

            HttpResponseMessage responseMessage =
                await Client.PostAsync("http://localhost:8080/user/register", content);
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                return user;
            }

            return null;
        }

        
        public async Task<User> EditUser(User user)
        {

            Console.WriteLine("Editing...");
            string userAsJson = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(
                userAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage responseMessage =
                await Client.PutAsync($"http://localhost:8080/user/edit", content);
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                return user;
            }

            return null;
        }

        public async Task<User> ChangePassword(User user)
        {
            string userAsJson = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(
                userAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage responseMessage =
                await Client.PutAsync($"http://localhost:8080/user/changePassword", content);
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                return user;
            }

            return null;
        }
    }
}