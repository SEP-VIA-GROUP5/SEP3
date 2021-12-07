package Services;

import Sockets.Models.Game;
import Sockets.Models.GameCluster;
import Sockets.Models.GameKey;

import java.io.IOException;

public interface IGameService {
    Game getGame(String gameName) throws IOException, ClassNotFoundException;
    GameCluster getGameCluster(int page) throws IOException, ClassNotFoundException;
    String getReceipt(int userId, int gameId) throws IOException, ClassNotFoundException;
    GameKey getProductKey(int gameId, String username) throws IOException, ClassNotFoundException;
    Game addGame(String name, double price, String photo, String ESRB, int IGN, String shortDescription, String specifications, String date) throws IOException, ClassNotFoundException;
    String addProductKey(int gameId, String porductKey) throws IOException, ClassNotFoundException;
    GameCluster getSearch(String search) throws IOException, ClassNotFoundException;
    String addGameToShoppingCart(String userName,int gameId) throws IOException;
    GameCluster removeGameFromShoppingCart(String userName, int gameId) throws IOException, ClassNotFoundException;
    GameCluster getShoppingCart(String userName) throws IOException, ClassNotFoundException;
    GameCluster getLibrary(String userName) throws IOException, ClassNotFoundException;
    Game editGame(int gameID, String name, double price, String photo, String ESRB, int IGN, String shortDescription, String specifications, String date) throws IOException, ClassNotFoundException;
    GameCluster sortByDate()throws IOException, ClassNotFoundException;
}
