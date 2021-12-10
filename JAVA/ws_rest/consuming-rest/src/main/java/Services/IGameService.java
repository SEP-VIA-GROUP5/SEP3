package Services;

import Sockets.Models.Game;
import Sockets.Models.GameCluster;
import Sockets.Models.GameKey;
import Sockets.Models.User;

import java.io.IOException;

public interface IGameService {
    Game getGame(String gameName) throws IOException, ClassNotFoundException;
    GameCluster getGameCluster(int page) throws IOException, ClassNotFoundException;
    GameKey getProductKey(int gameId, String username) throws IOException, ClassNotFoundException;
    Game addGame(Game game);
    GameCluster getSearch(String search) throws IOException, ClassNotFoundException;
    String addGameToShoppingCart(String userName,int gameId);
    GameCluster removeGameFromShoppingCart(String userName, int gameId) throws IOException, ClassNotFoundException;
    GameCluster getShoppingCart(String userName) throws IOException, ClassNotFoundException;
    GameCluster getLibrary(String userName) throws IOException, ClassNotFoundException;
    Game editGame(Game game);
    GameCluster sortByDate()throws IOException, ClassNotFoundException;
    String addGameToWishlist(String userName,int gameId) throws IOException;
    GameCluster removeGameFromWishlist(String userName, int gameId) throws IOException, ClassNotFoundException;
    GameCluster getWishlist(String userName) throws IOException, ClassNotFoundException;
}
