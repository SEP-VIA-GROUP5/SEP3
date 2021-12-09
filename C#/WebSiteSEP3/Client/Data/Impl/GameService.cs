using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Data.Impl
{
    public class GameService : IGameService
    {
        private readonly HttpClient Client = new HttpClient();
        private readonly string Uri = "http://localhost:8080";

        public async Task<Game> getGameAsync(string gameName)
        {
            string gameAsJson = null;
            HttpResponseMessage responseMessage =
                await Client.GetAsync($"http://localhost:8080/game/getGame?gameName={gameName}");
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                gameAsJson = await responseMessage.Content.ReadAsStringAsync();
                Game resultGame = JsonSerializer.Deserialize<Game>(gameAsJson);
                return resultGame; 
            }

            return null;
        }

        public async Task<GameCluster> getGameClusterAsync(int page)
        {
            string gameClusterAsJson = null;
            HttpResponseMessage responseMessage =
                await Client.GetAsync($"http://localhost:8080/game/getCluster?page={page}");
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                gameClusterAsJson = await responseMessage.Content.ReadAsStringAsync();
                GameCluster resultGameCluster = JsonSerializer.Deserialize<GameCluster>(gameClusterAsJson);
                return resultGameCluster; 
            }

            return null;
        }

        public async Task<string> getReceiptAsync(User user, Game game)
        {
            string receipt = null;
            HttpResponseMessage responseMessage =
                await Client.GetAsync($"http://localhost:8080/game/readReceipt?userId={user.Id}&gameId={game.GameId}");
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                receipt = await responseMessage.Content.ReadAsStringAsync();
                string receiptResult = JsonSerializer.Deserialize<string>(receipt);
                return receiptResult;
            }

            return null;
        }

        public async Task<GameKey> getProductKeyAsync(int gameId, string userName)
        {
            string productKeyJson = null;
            HttpResponseMessage responseMessage =
                await Client.GetAsync($"http://localhost:8080/game/getProductKey?gameId={gameId}&userName={userName}");
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                productKeyJson = await responseMessage.Content.ReadAsStringAsync();
                GameKey productKeyResult = JsonSerializer.Deserialize<GameKey>(productKeyJson);
                return productKeyResult;
            }

            return null;
        }

        public async Task<Game> addGameAsync(Game gameToSend)
        {
            string gameAsJson = JsonSerializer.Serialize(gameToSend);
            StringContent content = new StringContent(gameAsJson,
                Encoding.UTF8,
                "application/json");

            HttpResponseMessage responseMessage =
                await Client.PostAsync("http://localhost:8080/game/addGame", content);
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                return gameToSend;
            }

            return null;
        }
        
        public async Task<GameCluster> getSearchAsync(string search)
        {
            String _gameClusterJson;
            HttpResponseMessage responseMessage =
                await Client.GetAsync($"http://localhost:8080/game/getSearch?search={search}");
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                _gameClusterJson = await responseMessage.Content.ReadAsStringAsync();
                GameCluster gameCluster = JsonSerializer.Deserialize<GameCluster>(_gameClusterJson);
                return gameCluster;
            }

            return null;
        }

        public async Task<bool> addGameToShoppingCartAsync(string userName, Game game)
        {
            string gameAsJson = JsonSerializer.Serialize(game);
            StringContent content = new StringContent(gameAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage responseMessage =
                await Client.PostAsync($"http://localhost:8080/game/cart/add?userName={userName}", content);
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> removeGameFromShoppingCartAsync(string userName, int gameId)
        {
            HttpResponseMessage responseMessage =
                await Client.DeleteAsync($"http://localhost:8080/game/cart/remove?userName={userName}&gameId={gameId}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<GameCluster> getShoppingCartAsync(string userName)
        {
            String _gameClusterJson;
            HttpResponseMessage responseMessage =
                await Client.GetAsync($"http://localhost:8080/game/cart/get?userName={userName}");
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                _gameClusterJson = await responseMessage.Content.ReadAsStringAsync();
                GameCluster gameCluster = JsonSerializer.Deserialize<GameCluster>(_gameClusterJson);
                return gameCluster;
            }

            return null;
        }

        public async Task<GameCluster> getLibraryAsync(string userName)
        {
            String _gameClusterJson;
            HttpResponseMessage responseMessage =
                await Client.GetAsync($"http://localhost:8080/game/library/get?userName={userName}");
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                _gameClusterJson = await responseMessage.Content.ReadAsStringAsync();
                GameCluster gameCluster = JsonSerializer.Deserialize<GameCluster>(_gameClusterJson);
                return gameCluster;
            }

            return null;
        }
        
        public async Task<Game> editGameAsync(Game gameToSend)
        {
            string gameAsJson = JsonSerializer.Serialize(gameToSend);
            StringContent content = new StringContent(gameAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage responseMessage =
                await Client.PutAsync($"http://localhost:8080/game/editGame", content);
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                return gameToSend;
            }

            return null;
        }
        
        public async Task<GameCluster> getNewlyReleased()
        {
            String _gameClusterJson;
            HttpResponseMessage responseMessage =
                await Client.GetAsync($"http://localhost:8080/game/getNewRelease?");
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                _gameClusterJson = await responseMessage.Content.ReadAsStringAsync();
                GameCluster gameCluster = JsonSerializer.Deserialize<GameCluster>(_gameClusterJson);
                return gameCluster;
            }

            return null;
        }

        public async Task addGameToWishlistAsync(string userName, Game game)
        {
            string gameAsJson = JsonSerializer.Serialize(game);
            StringContent content = new StringContent(gameAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage responseMessage =
                await Client.PostAsync($"http://localhost:8080/game/wishlist/add?userName={userName}", content);
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("game added successfully!");
            }
            else
            {
                Console.WriteLine("game was NOT added!");
            }
        }

        public async Task<bool> removeGameFromWishlistAsync(string userName, int gameId)
        {
            HttpResponseMessage responseMessage =
                await Client.DeleteAsync($"http://localhost:8080/game/wishlist/remove?userName={userName}&gameId={gameId}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<GameCluster> getWishlistAsync(string userName)
        {
            String _gameClusterJson;
            HttpResponseMessage responseMessage =
                await Client.GetAsync($"http://localhost:8080/game/wishlist/get?userName={userName}");
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                _gameClusterJson = await responseMessage.Content.ReadAsStringAsync();
                GameCluster gameCluster = JsonSerializer.Deserialize<GameCluster>(_gameClusterJson);
                return gameCluster;
            }

            return null;
        }
    }
}