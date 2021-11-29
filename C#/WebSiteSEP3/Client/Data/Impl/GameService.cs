using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Data.Impl
{
    public class GameService : IGameService
    {
        private readonly HttpClient Client = new HttpClient();
        private readonly string Uri = "http://localhost:8080";

        public async Task<Game> getGameAsync(int gameId)
        {
            string gameAsJson = null;
            HttpResponseMessage responseMessage =
                await Client.GetAsync($"http://localhost:8080/game/getGame?gameId={gameId}");
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
                await Client.GetAsync($"http://localhost:8080/page/getCluster?page={page}");
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
                await Client.GetAsync($"http://localhost:8080/readReceipt?userId={user.Id}&gameId={game.GameId}");
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                receipt = await responseMessage.Content.ReadAsStringAsync();
                string receiptResult = JsonSerializer.Deserialize<string>(receipt);
                return receiptResult;
            }

            return null;
        }

        public async Task<string> getProductKeyAsync(Game game)
        {
            string productKey = null;
            HttpResponseMessage responseMessage =
                await Client.GetAsync($"http://localhost:8080/readReceipt?userId={game.GameId}");
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                productKey = await responseMessage.Content.ReadAsStringAsync();
                string productKeyResult = JsonSerializer.Deserialize<string>(productKey);
                return productKeyResult;
            }

            return null;
        }

        public async Task<Game> addGameAsync(Game gameToSend)
        {
            string game = null;
            HttpResponseMessage responseMessage =
                await Client.GetAsync($"http://localhost:8080/addGame?gameName={gameToSend.GameName}&price={gameToSend.Price}&photo={gameToSend.Photo}" +
                                      $"&esrb={gameToSend.ESRB}&ign={gameToSend.IGN}&description={gameToSend.ShortDescription}");
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                game = await responseMessage.Content.ReadAsStringAsync();
                Game gameResult = JsonSerializer.Deserialize<Game>(game);
                return gameResult;
            }

            return null;
        }
    }
}