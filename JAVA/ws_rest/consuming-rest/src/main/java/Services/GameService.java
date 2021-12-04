package Services;

import Sockets.Handlers.ClientHandling;
import Sockets.Models.Game;
import Sockets.Models.GameCluster;
import Sockets.Models.GameKey;
import Sockets.Packages.CartPackage;
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
        double pagesDouble = (double)allGames.size()/(double)gamesPerPage;
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
            if(gamesPerPageArray[page][i] == (null))
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
    public GameKey getProductKey(int gameId, String username) throws IOException, ClassNotFoundException{
        Game game = new Game(gameId);
        GamePackage gamePackage = new GamePackage(game,"getProductKey", username);
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

    @Override
    public GameCluster getSearch(String search)
        throws IOException, ClassNotFoundException
    {
        String space = "<->";
        search = search.replaceAll(" ", space);
        Game game = new Game(search);
        GamePackage gamePackage = new GamePackage(game, "getSearch");
        clientHandling.sendToServer(gamePackage);
        Object dataReceivedFromServer = clientHandling.receiveFromServer();
        gamePackage = (GamePackage) dataReceivedFromServer;
        GameCluster gameCluster = new GameCluster();
        gameCluster.setGameStack(gamePackage.getGames());
        System.out.println(gameCluster.getGameStack().toString() + "| Found");
        return gameCluster;
    }

    @Override
    public String addGameToShoppingCart(String userName, int gameId) throws IOException {
        CartPackage cartPackage = new CartPackage("add",userName,gameId);
        clientHandling.sendToServer(cartPackage);
        return "sent";
    }

    @Override
    public GameCluster removeGameFromShoppingCart(String userName, int gameId) throws IOException, ClassNotFoundException {
        CartPackage cartPackage = new CartPackage("remove",userName,gameId);
        clientHandling.sendToServer(cartPackage);
        Object dataReceived = clientHandling.receiveFromServer();
        CartPackage cartPackage1 = (CartPackage) dataReceived;
        GameCluster gameCluster = new GameCluster();
        for(Game game: cartPackage1.getGames())
        {
            gameCluster.addGameToCluster(game);
        }
        return gameCluster;
    }

    @Override
    public GameCluster getShoppingCart(String userName) throws IOException, ClassNotFoundException {
        CartPackage cartPackage = new CartPackage("get",userName);
        clientHandling.sendToServer(cartPackage);
        Object dataReceived = clientHandling.receiveFromServer();
        CartPackage cartPackage1 = (CartPackage) dataReceived;
        GameCluster gameCluster = new GameCluster();
        for(Game game: cartPackage1.getGames())
        {
            gameCluster.addGameToCluster(game);
        }
        System.out.println(gameCluster.getGameStack());
        return gameCluster;
    }
}
