package Sockets.Handling;

import Sockets.Models.Game;
import Sockets.Models.GameKey;
import Sockets.Models.User;
import Sockets.Packages.CartPackage;
import Sockets.Packages.GamePackage;
import Sockets.Packages.UserPackage;
import com.google.gson.Gson;
import mediator.DatabaseServer;

import java.io.*;
import java.net.ServerSocket;
import java.net.Socket;
import java.sql.SQLException;
import java.util.ArrayList;

/**
 * A method, thad handles sockets connection with tier 2.
 */
public class ServerHandling implements Runnable{
    private Socket socket;
    private DatabaseServer databaseServer;
    private User user;
    private Game game;
    private Gson gson;
    private ObjectInputStream objectInputStream;
    private ObjectOutputStream objectOutputStream;

    /**
     * Constructor initializing instance variables.
     * @param databaseServer database server as and object.
     * @param socket connection with tier 2.
     * @throws IOException
     * @throws SQLException
     */
    public ServerHandling(DatabaseServer databaseServer, Socket socket) throws IOException, SQLException {
        this.socket = socket;
        OutputStream outputStream = socket.getOutputStream();
        this.objectOutputStream = new ObjectOutputStream(outputStream);
        InputStream inputStream = socket.getInputStream();
        this.objectInputStream = new ObjectInputStream(inputStream);
        this.databaseServer = databaseServer;
    }

    /**
     * A method, that executes different methods depending on package received and that package type.
     */
    public void run()
    {
        while(true)
        {
            try {
                Object obj = objectInputStream.readObject();
                if(obj instanceof UserPackage)
                {

                    UserPackage received = (UserPackage)obj;
                    user = received.getUser();
                    System.out.println(user.getUsername());
                    switch (received.getType())
                    {
                        case "gettingUser" :
                        {
                            User userToBeSent = databaseServer.getUserDB(user.getUsername());
                            UserPackage toSentPackage = new UserPackage(userToBeSent, "user");
                            sendDataToServer(toSentPackage);
                            break;
                        }
                        case "validateLogin" :
                        {
                            User userToBeSent = databaseServer.getUserDB(user.getUsername(), user.getPassword());
                            UserPackage toSentPackage = new UserPackage(userToBeSent, "lol");
                            sendDataToServer(toSentPackage);
                            break;
                        }
                        case "validateRegister" :
                        {
                            User userToBeSent1 = databaseServer.registerUser(user);
                            UserPackage toSentPackage1 = new UserPackage(userToBeSent1, "idk");
                            sendDataToServer(toSentPackage1);
                            break;
                        }
                        case "getLibrary":
                        {
                            ArrayList<Game> games = databaseServer.getLibrary(received.getUser().getUsername());
                            GamePackage gamePackage = new GamePackage("library", games);
                            sendDataToServer(gamePackage);
                            break;
                        }
                        case "editUser":
                        {
                            databaseServer.editUserInfo(user);
                            break;
                        }
                        case"changePassword":
                        {
                            databaseServer.changePassword(user);
                            break;
                        }
                        default:
                    }
                }
                else if(obj instanceof GamePackage)
                {
                    GamePackage received = (GamePackage) obj;

                    switch (received.getType())
                    {
                        case "getGame":
                        {

                            game = received.getGame();
                            Game gameToBeSent = databaseServer.getGameDB(game.getGameName());
                            GamePackage toSentPackage = new GamePackage(gameToBeSent, "");
                            sendDataToServer(toSentPackage);
                            break;
                        }
                        case "getProductKey":
                        {
                            game = received.getGame();
                            Game gameToBeSent = databaseServer.buyGame(game.getGameId(), received.getUsername());
                            if(gameToBeSent.getGameKey().getGameKey() == null)
                            {
                                gameToBeSent.setGameKey(new GameKey("No product key available"));
                            }
                            GamePackage toSentPackage = new GamePackage(gameToBeSent, "");
                            sendDataToServer(toSentPackage);
                            break;
                        }
                        case "AllGames":
                        {
                            GamePackage sendGamePackage = new GamePackage("AllGames", databaseServer.getAllGames());
                            sendDataToServer(sendGamePackage);
                            break;
                        }
                        case "getSearch":
                        {
                            Game receivedGame = received.getGame();
                            GamePackage sendGamePackage = new GamePackage("foundGames", databaseServer.searchGamesByName(receivedGame.getGameName()));
                            sendDataToServer(sendGamePackage);
                            break;
                        }
                        case "registerGame":
                        {
                            Game receivedGame = received.getGame();
                            databaseServer.registerGame(receivedGame);
                            break;
                        }
                        case "editGame":
                            {
                                Game receivedGame = received.getGame();
                                databaseServer.editGame(receivedGame);
                                break;
                        }
                        case "sortedByDate":
                        {
                            GamePackage sendGamePackage = new GamePackage("sortedByDate", databaseServer.sortByDate());
                            sendDataToServer(sendGamePackage);
                            break;
                        }

                        default:
                    }
                }
                else if((obj instanceof CartPackage))
                {
                    CartPackage received = (CartPackage) obj;
                    switch (received.getType())
                    {
                        case "add":
                        {
                            databaseServer.addToShoppingCart(received.getUserName(),
                                received.getGameId());
                            break;
                        }
                        case "remove":
                        {
                            ArrayList<Game> games = databaseServer.removeFromShoppingCart(received.getUserName(), received.getGameId());
                            CartPackage toSend = new CartPackage(games);
                            sendDataToServer(toSend);
                            break;
                        }
                        case "get":
                        {
                            ArrayList<Game> games = databaseServer.getShoppingCart(received.getUserName());
                            CartPackage toSend = new CartPackage(games);
                            sendDataToServer(toSend);
                            break;
                        }
                        case "addWishlist":
                        {
                            databaseServer.addToWishlist(received.getUserName(),
                                received.getGameId());
                            break;
                        }
                        case "removeWishlist":
                        {
                            ArrayList<Game> games = databaseServer.removeFromWishlist(received.getUserName(), received.getGameId());
                            CartPackage toSend = new CartPackage(games);
                            sendDataToServer(toSend);
                            break;
                        }
                        case "getWishlist":
                        {
                            ArrayList<Game> games = databaseServer.getWishlist(received.getUserName());
                            CartPackage toSend = new CartPackage(games);
                            sendDataToServer(toSend);
                            break;
                        }
                        default:
                    }
                }
            }
            catch (Exception e)
            {
                e.printStackTrace();
                break;
            }
            }


        }

    /**
     * A method, that sends user package to tier 2.
     * @param obj user package object.
     * @throws IOException
     */
    public void sendDataToServer(UserPackage obj) throws IOException {
        objectOutputStream.writeObject(obj);
    }

    /**
     * A method, that sends user package to tier 2.
     * @param obj game package object.
     * @throws IOException
     */
    public void sendDataToServer(GamePackage obj) throws IOException {
        objectOutputStream.writeObject(obj);
    }

    /**
     * A method, that sends cart package to tier 2.
     * @param obj cart package object.
     * @throws IOException
     */
    public void sendDataToServer(CartPackage obj) throws IOException {
        objectOutputStream.writeObject(obj);
    }

    /**
     * A method, that disconnects from tier 2.
     * @throws IOException
     */
    public void disconnect() throws IOException {
        socket.close();
    }
    }

