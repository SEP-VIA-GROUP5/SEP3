package Services;

import Sockets.Handlers.ClientHandling;
import Sockets.Models.Game;
import Sockets.Models.GameCluster;
import Sockets.Models.GameKey;
import Sockets.Packages.GamePackage;
import com.google.gson.Gson;

import java.io.IOException;
import java.util.ArrayList;

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
        GamePackage gamePackage = new GamePackage("AllGames");
        clientHandling.sendToServer(gamePackage);
        Object dataReceivedFromServer = clientHandling.receiveFromServer();
        gamePackage = (GamePackage) dataReceivedFromServer;
        ArrayList<Game> allGames;
        allGames = gamePackage.getGames();
        int gamesPerPage = 5;
        double pagesDouble = allGames.size()/gamesPerPage;
        int pages;

        if((pagesDouble % 1) > 0)
        {
            pages = (int) pagesDouble + 1;
        }
        else
        {
            pages = (int) pagesDouble;
        }

        Game [][] gamesPerPageArray = new Game[pages][gamesPerPage];
        for(int i = 0; i < pages; i++)
        {
            for(int j = 0; j < gamesPerPage; j++)
            {
                gamesPerPageArray[i][j] = allGames.get(0);
                allGames.remove(0);
                if(allGames.size() == 0)
                {
                    break;
                }
            }
        }

        ArrayList<Game> gamesToSend = new ArrayList<>();
        for(int i = 0; i < gamesPerPage; i++)
        {
            if(gamesPerPageArray[page][i] == null)
            {
                break;
            }
            gamesToSend.add(gamesPerPageArray[page][i]);
        }
        GameCluster gameCluster = new GameCluster();
        gameCluster.setGameStack(gamesToSend);
        return gameCluster;
    }

    @Override
    public String getReceipt(int userId, int gameId) throws IOException, ClassNotFoundException{
        return null;
        //TODO
    }

    @Override
    public GameKey getProductKey(int gameId) throws IOException, ClassNotFoundException{
        Game game = new Game(gameId);
        GamePackage gamePackage = new GamePackage(game,"getProductKey");
        clientHandling.sendToServer(gamePackage);
        Object dataReceivedFromServer = clientHandling.receiveFromServer();
        gamePackage = (GamePackage) dataReceivedFromServer;
        System.out.println(gamePackage.getGame().getGameKey().getGameKey());
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
