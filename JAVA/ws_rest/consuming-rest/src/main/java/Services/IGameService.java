package Services;

import Sockets.Models.Game;
import Sockets.Models.GameCluster;

import java.io.IOException;

public interface IGameService {
    Game getGame(int gameId) throws IOException, ClassNotFoundException;
    GameCluster getGameCluster(int page) throws IOException, ClassNotFoundException;
    String getReceipt(int userId, int gameId) throws IOException, ClassNotFoundException;
    String getProductKey(int gameId) throws IOException, ClassNotFoundException;
    Game addGame(String name, double price, String photo, String ESRB, String IGN, String shortDescription, String specifications, String date) throws IOException, ClassNotFoundException;
    String addProductKey(int gameId, String porductKey) throws IOException, ClassNotFoundException;
}
