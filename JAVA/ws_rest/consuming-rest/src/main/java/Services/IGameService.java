package Services;

import Sockets.Models.Game;
import Sockets.Models.GameCluster;
import Sockets.Models.GameKey;

import java.io.IOException;

public interface IGameService {
    Game getGame(String gameName) throws IOException, ClassNotFoundException;
    GameCluster getGameCluster(int page) throws IOException, ClassNotFoundException;
    String getReceipt(int userId, int gameId) throws IOException, ClassNotFoundException;
    GameKey getProductKey(int gameId) throws IOException, ClassNotFoundException;
    Game addGame(String name, double price, String photo, String ESRB, String IGN, String shortDescription, String specifications, String date) throws IOException, ClassNotFoundException;
    String addProductKey(int gameId, String porductKey) throws IOException, ClassNotFoundException;
    GameCluster getSearch(String search) throws IOException, ClassNotFoundException;
}
