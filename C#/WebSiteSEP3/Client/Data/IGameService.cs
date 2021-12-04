using System.Threading.Tasks;
using Client.Models;

namespace Client.Data
{
    public interface IGameService
    {
        Task<Game> getGameAsync(string gameName);
        Task<GameCluster> getGameClusterAsync(int page);
        Task<string> getReceiptAsync(User user, Game game);
        Task<GameKey> getProductKeyAsync(int gameId);
        Task<Game> addGameAsync(Game game);
        Task<GameKey> addGameKeyAsync(int gameId, string productKey);
        Task<GameCluster> getSearchAsync(string search);
        Task addGameToShoppingCartAsync(User user, int gameId);
        Task<GameCluster> removeGameFromShoppingCartAsync(User user, int gameId);
        Task<GameCluster> getShoppingCartAsync(User user);
    }
}