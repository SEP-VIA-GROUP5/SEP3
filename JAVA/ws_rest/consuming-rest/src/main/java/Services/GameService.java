package Services;

import Sockets.Handlers.ClientHandling;
import Sockets.Models.Game;
import Sockets.Models.GameCluster;
import Sockets.Packages.GamePackage;
import com.google.gson.Gson;

import java.io.IOException;

public class GameService implements IGameService{

    private ClientHandling clientHandling;
    private Gson gson;

    public GameService() throws IOException{
        clientHandling = new ClientHandling();
        gson = new Gson();
    }

    @Override
    public Game getGame(String gameName) throws IOException, ClassNotFoundException{
        Game game = new Game(gameName);
        GamePackage gamePackage = new GamePackage(game,"getGame");
        clientHandling.sendToServer(gamePackage);
        Object dataReceivedFromServer = clientHandling.receiveFromServer();
        gamePackage = (GamePackage) dataReceivedFromServer;
        return gamePackage.getGame();
    }

    @Override
    public GameCluster getGameCluster(int page) throws IOException, ClassNotFoundException{
        return null;
        //TODO
    }

    @Override
    public String getReceipt(int userId, int gameId) throws IOException, ClassNotFoundException{
        return null;
        //TODO
    }

    @Override
    public String getProductKey(int gameId) throws IOException, ClassNotFoundException{
        Game game = new Game(gameId);
        GamePackage gamePackage = new GamePackage(game,"getProductKey");
        clientHandling.sendToServer(gamePackage);
        Object dataReceivedFromServer = clientHandling.receiveFromServer();
        gamePackage = (GamePackage) dataReceivedFromServer;
        return gamePackage.getGame().getGameKey();
    }

    @Override
    public Game addGame(String name, double price, String photo, String ESRB, String IGN, String shortDescription, String specifications, String date) throws IOException, ClassNotFoundException{
        return null;
        //TODO
    }

    @Override
    public String addProductKey(int gameId, String porductKey) throws IOException, ClassNotFoundException {
        return null;
        //TODO
    }
}
