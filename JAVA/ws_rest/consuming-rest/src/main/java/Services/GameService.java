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
    public Game getGame(int gameId) throws IOException, ClassNotFoundException{
        return null;
    }

    @Override
    public GameCluster getGameCluster(int page) throws IOException, ClassNotFoundException{
        return null;
    }

    @Override
    public String getReceipt(int userId, int gameId) throws IOException, ClassNotFoundException{
        return null;
    }

    @Override
    public String getProductKey(int gameId) throws IOException, ClassNotFoundException{
        return null;
    }

    @Override
    public Game addGame(String name, double price, String photo, String ESRB, String IGN, String shortDescription, String specifications, String date) throws IOException, ClassNotFoundException{
        return null;
    }

    @Override
    public String addProductKey(int gameId, String porductKey) throws IOException, ClassNotFoundException {
        return null;
    }
}
