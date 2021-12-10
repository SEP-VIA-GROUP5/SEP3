package Services;

import Sockets.Handlers.ClientHandling;
import Sockets.Models.Game;
import Sockets.Models.GameCluster;
import Sockets.Models.GameKey;
import Sockets.Models.User;
import Sockets.Packages.CartPackage;
import Sockets.Packages.GamePackage;
import Sockets.Packages.UserPackage;
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

    /**
     * Takes a game name as a parameter, creates an object of Game, only with the name of the game
     * puts it in a GamePackage object with a type "getGame" and sends it to the Database server. The
     * Database server then return an object of GamePackage with the complete Game object that was found by the
     * game name given in the parameters
     * <p>
     * @param  gameName  The name of the game
     * @return A game object
     *
     */
    @Override
    public Game getGame(String gameName) throws IOException, ClassNotFoundException{
        Game game = new Game(gameName);
        GamePackage gamePackage = new GamePackage(game,"getGame");
        clientHandling.sendToServer(gamePackage);
        Object dataReceivedFromServer = clientHandling.receiveFromServer();
        gamePackage = (GamePackage) dataReceivedFromServer;
        return gamePackage.getGame();
    }

    /**
     * Asks for all games from the database server, then divides all the games into different pages
     * and returns a GameCluster of games for the page asked in the parameters
     * <p>
     * @param  page  a number of the page
     * @return GameCluster object with the games from the page given
     *
     */
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

    /**
     * Takes gameId and username to get a product key of the game that ID was given
     * and saves it in the database for that user
     * <p>
     * @param  gameId game ID
     * @param  username users username
     * @return Game key
     *
     */
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

  /**
   * Used to add games to the database. Takes a Game object, to add to the database.
   * If added returns the game, otherwise returns null
   * <p>
   * @param  game a game object
   * @return game if it was added, otherwise null
   *
   */
    @Override
    public Game addGame(Game game) {
        try{
            GamePackage gamePackage = new GamePackage(game, "registerGame");
            clientHandling.sendToServer(gamePackage);
            return game;
        }
        catch (Exception e)
        {
            e.printStackTrace();
            return null;
        }
    }

  /**
   * Used to search for a games object by the name of the game.
   * <p>
   * @param  search game name
   * @return GameCluster with the games found
   *
   */
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

  /**
   * Used to add game objects to the shopping cart. Takes a username and gameID
   * to know which game to add for which user.
   * <p>
   * @param  userName a string with the users username
   * @param  gameId the ID of a game
   * @return "sent" if added, otherwise null
   *
   */
    @Override
    public String addGameToShoppingCart(String userName, int gameId) {
        try{
            CartPackage cartPackage = new CartPackage("add",userName,gameId);
            clientHandling.sendToServer(cartPackage);
            return "sent";
        }
        catch (Exception e)
        {
            e.printStackTrace();
            return null;
        }
    }

  /**
   * Used to remove a game object from users shopping cart. Takes username and gameID
   * to find a users shopping cart by username, and remove the game by gameID
   * <p>
   * @param  gameId game ID
   * @param  userName users username
   * @return gameCluster - the shopping cart with the game removed
   *
   */
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

  /**
   * Used to get a shopping cart of a user. Takes a username to find its shopping cart
   * by username. Return the shopping cart as a GameCluster object with a game list
   * <p>
   * @param  userName users username
   * @return GameCluster object
   *
   */
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

  /**
   * Used to get the game Library of a user. Takes username to find the users
   * game library by username. Return the game library as a GameCluster of all
   * the games bought by a user with game keys
   * <p>
   * @param  userName users username
   * @return GameCluster object
   *
   */
    @Override public GameCluster getLibrary(String userName)
        throws IOException, ClassNotFoundException
    {
        User user = new User(userName);
        UserPackage userPackage = new UserPackage(user, "getLibrary");
        clientHandling.sendToServer(userPackage);
        Object dataReceived = clientHandling.receiveFromServer();
        GamePackage gamePackage = (GamePackage) dataReceived;
        GameCluster gameCluster = new GameCluster();
        for(Game game: gamePackage.getGames())
        {
            gameCluster.addGameToCluster(game);
        }
        return gameCluster;
    }

  /**
   * Used to edit Game object variables values. Takes a game object and sends it
   * to the database server to change it in the database. Returns the same object
   * if changed, otherwise returns null
   * <p>
   * @param  game changed game object
   * @return game if changed, otherwise null
   *
   */
    @Override
    public Game editGame(Game game){
        try {
            GamePackage gamePackage = new GamePackage(game, "editGame");
            clientHandling.sendToServer(gamePackage);
            return game;
        }
        catch (Exception e)
        {
            e.printStackTrace();
            return null;
        }
    }

  /**
   * Used to get new released games as a game cluster. Returns the newest games
   * in a GameCluster object from the database server
   * <p>
   * @return GameCluster object
   *
   */
    @Override public GameCluster sortByDate()
        throws IOException, ClassNotFoundException
    {
        GamePackage gamePackage = new GamePackage("sortedByDate");
        clientHandling.sendToServer(gamePackage);
        Object dataReceivedFromServer = clientHandling.receiveFromServer();
        gamePackage = (GamePackage) dataReceivedFromServer;
        GameCluster gameCluster = new GameCluster();
        gameCluster.setGameStack(gamePackage.getGames());
        return gameCluster;
    }

  /**
   * Used to add games to a users WishList. Takes a username and a game ID to
   * find a users Wishlist in the database by username and add the game by game ID
   * to it.
   * <p>
   * @param  userName users username
   * @param  gameId ID of a game to be added
   * @return "sent"
   *
   */
    @Override
    public String addGameToWishlist(String userName, int gameId) throws IOException {
        CartPackage cartPackage = new CartPackage("addWishlist",userName,gameId);
        clientHandling.sendToServer(cartPackage);
        return "sent";
    }

  /**
   * Used to remove a game from users WishList. Takes a username and game ID to
   * find a users Wishlist in the database by username and find a game to remove
   * by the game ID taken
   * <p>
   * @param  userName users username
   * @param  gameId an ID of a game
   * @return GameCluster object, all games in the Wishlist
   *
   */
    @Override
    public GameCluster removeGameFromWishlist(String userName, int gameId) throws IOException, ClassNotFoundException {
        CartPackage cartPackage = new CartPackage("removeWishlist",userName,gameId);
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

  /**
   * Used to get a WishList of a user from the database. Takes a username to
   * find the Wishlist in the database that belongs to that username
   * <p>
   * @param  userName users username
   * @return GameCluster object, all games in the Wishlist of a user
   *
   */
    @Override
    public GameCluster getWishlist(String userName) throws IOException, ClassNotFoundException {
        CartPackage cartPackage = new CartPackage("getWishlist",userName);
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
