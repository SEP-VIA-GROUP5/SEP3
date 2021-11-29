using System.Threading.Tasks;
using Client.Models;

namespace Client.Data
{
    public interface IGameService
    {
        Task<Game> getGameAsync(int gameId);
        Task<GameCluster> getGameClusterAsync(int page);
        Task<string> getReceiptAsync(User user, Game game);
        Task<string> getProductKeyAsync(Game game);
        Task<Game> addGameAsync(Game game);
    }
}