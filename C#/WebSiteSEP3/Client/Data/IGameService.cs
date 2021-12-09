using System;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Data
{
    public interface IGameService
    {
        Task<Game> getGameAsync(string gameName);
        Task<GameCluster> getGameClusterAsync(int page);
        Task<string> getReceiptAsync(User user, Game game);
        Task<GameKey> getProductKeyAsync(int gameId, string userName);
        Task<Game> addGameAsync(Game game);
        Task<GameCluster> getSearchAsync(string search);
        Task<bool> addGameToShoppingCartAsync(string userName, Game game);
        Task<bool> removeGameFromShoppingCartAsync(string userName, int gameId);
        Task<GameCluster> getShoppingCartAsync(string userName);
        Task<GameCluster> getLibraryAsync(string userName);
        Task<Game> editGameAsync(Game game);
        Task<GameCluster> getNewlyReleased();
        Task addGameToWishlistAsync(string userName,Game game);
        Task<bool> removeGameFromWishlistAsync(string userName, int gameId);
        Task<GameCluster> getWishlistAsync(string userName);
    }
}