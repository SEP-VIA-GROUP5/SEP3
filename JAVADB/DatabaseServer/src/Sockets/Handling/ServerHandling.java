package Sockets.Handling;

import Sockets.Models.Game;
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

public class ServerHandling implements Runnable{
    private Socket socket;
    private DatabaseServer databaseServer;
    private User user;
    private Game game;
    private Gson gson;
    private ObjectInputStream objectInputStream;
    private ObjectOutputStream objectOutputStream;

    public ServerHandling(DatabaseServer databaseServer, Socket socket) throws IOException, SQLException {
//        this.serverSocket = new ServerSocket(5678);
        this.socket = socket;
        OutputStream outputStream = socket.getOutputStream();
        this.objectOutputStream = new ObjectOutputStream(outputStream);
        InputStream inputStream = socket.getInputStream();
        this.objectInputStream = new ObjectInputStream(inputStream);
        this.databaseServer = databaseServer;
        System.out.println("Server started...");
    }


    public void run()
    {
        while(true)
        {
            try {
//                System.out.println("Waiting for a client...");
//                this.socket = serverSocket.accept();
                Object obj = objectInputStream.readObject();
                if(obj instanceof UserPackage)
                {

                    UserPackage received = (UserPackage)obj;
                    //Receiving user from client
                    user = received.getUser();
                    System.out.println(user.getUsername());
                    switch (received.getType())
                    {
                        //Test for getting a receipt for a specific user
                        case "gettingUser" :
                        {
                            System.out.println("Validating login");
                            //Getting user from database with credentials given from Client
                            User userToBeSent = databaseServer.getUserDB(user.getUsername());
                            UserPackage toSentPackage = new UserPackage(userToBeSent, "user");
                            //Sending back the user such that it can be validated
                            sendDataToServer(toSentPackage);
                            System.out.println("Getting user in request back");
                            break;
                        }
                        case "validateLogin" :
                        {
                            System.out.println("Validating login");
                            //Getting user from database with credentials given from Client
                            User userToBeSent = databaseServer.getUserDB(user.getUsername(), user.getPassword());
                            UserPackage toSentPackage = new UserPackage(userToBeSent, "lol");
                            //Sending back the user such that it can be validated
                            sendDataToServer(toSentPackage);
                            System.out.println("Logging in request sent back");
                            break;
                        }
                        case "validateRegister" :
                        {
                            System.out.println("Validating register");
                            //Registering user in db with the credentials from client
                            User userToBeSent1 = databaseServer.registerUser(user.getUsername(), user.getPassword(), user.getFirstName(), user.getLastName());
                            UserPackage toSentPackage1 = new UserPackage(userToBeSent1, "idk");
                            //sending back the user from the database, if not registered the user will be null
                            sendDataToServer(toSentPackage1);
                            System.out.println("Registering request sent back");
                            break;
                        }
                        case "getLibrary":
                        {
                            System.out.println("Getting a library");
                            ArrayList<Game> games = databaseServer.getLibrary(received.getUser().getUsername());
                            GamePackage gamePackage = new GamePackage("library", games);
                            sendDataToServer(gamePackage);
                            System.out.println("Sending library");
                            break;
                        }
                        case "editUser":
                        {
                            System.out.println("Editing user");
                            databaseServer.editUserInfo(received.getUser().getId(),
                                received.getUser().getUsername(),
                                received.getUser().getPhoto(),
                                received.getUser().getFirstName(),
                                received.getUser().getLastName());
                            break;
                        }
                        case"changePassword":
                        {
                            System.out.println("Changing password");
                            databaseServer.changePassword(user.Username,
                                user.Password);
                            break;
                        }
                        default:
                            System.out.println("Type not found");
                    }
                }
                else if(obj instanceof GamePackage)
                {
                    GamePackage received = (GamePackage) obj;
                    //Receiving user from client

                    switch (received.getType())
                    {
                        case "getGame":
                        {
                            System.out.println("Getting game");
                            game = received.getGame();
                            System.out.println(game.getGameName());
                            Game gameToBeSent = databaseServer.getGameDB(game.getGameName());
                            GamePackage toSentPackage = new GamePackage(gameToBeSent, "");
                            sendDataToServer(toSentPackage);
                            System.out.println("Sending requested game");
                            break;
                        }
                        case "getProductKey":
                        {
                            System.out.println("Getting key");
                            game = received.getGame();
                            System.out.println(game.getGameName());
                            Game gameToBeSent = databaseServer.buyGame(game.getGameId(), received.getUsername());
                            GamePackage toSentPackage = new GamePackage(gameToBeSent, "");
                            sendDataToServer(toSentPackage);
                            System.out.println("Sending requested game");
                            break;
                        }
                        case "AllGames":
                        {
                            System.out.println("Getting games");
                            GamePackage sendGamePackage = new GamePackage("AllGames", databaseServer.getAllGames());
                            sendDataToServer(sendGamePackage);
                            System.out.println("Sending all games");
                            break;
                        }
                        case "getSearch":
                        {
                            System.out.println("Searching for games");
                            Game receivedGame = received.getGame();
                            GamePackage sendGamePackage = new GamePackage("foundGames", databaseServer.searchGamesByName(receivedGame.getGameName()));
                            sendDataToServer(sendGamePackage);
                            System.out.println("Sending games found");
                            break;
                        }
                        case "registerGame":
                        {
                            System.out.println("Registering game");
                            Game receivedGame = received.getGame();
                            databaseServer.registerGame(receivedGame.getGameName(),
                                receivedGame.getPrice(),
                                receivedGame.getDescription(),
                                receivedGame.getSpecifications(),
                                receivedGame.getIGNRating(),
                                receivedGame.getESRBRating(),
                                receivedGame.getPhotoURL(),
                                receivedGame.getReleaseDate());
                            break;
                        }
                        case "editGame":
                            {
                                System.out.println("Printing out game");
                                Game receivedGame = received.getGame();
                                databaseServer.editGame(receivedGame.getGameId(),
                                    receivedGame.getGameName(),
                                    receivedGame.getPrice(),
                                    receivedGame.getDescription(),
                                    receivedGame.getSpecifications(),
                                    receivedGame.getIGNRating(),
                                    receivedGame.getESRBRating(),
                                    receivedGame.getPhotoURL(),
                                    receivedGame.getReleaseDate());
                                break;
                        }
                        case "sortedByDate":
                        {
                            System.out.println("Getting games");
                            GamePackage sendGamePackage = new GamePackage("sortedByDate", databaseServer.sortByDate());
                            sendDataToServer(sendGamePackage);
                            System.out.println("Sending all games");
                            break;
                        }

                        default:
                            System.out.println("Type not found");
                    }
                }
                else if((obj instanceof CartPackage))
                {
                    CartPackage received = (CartPackage) obj;
                    switch (received.getType())
                    {
                        case "add":
                        {
                            System.out.println("Adding to shopping cart");
                            System.out.println(received.getUserName());
                            System.out.println(received.getGameId());
                            databaseServer.addToShoppingCart(received.getUserName(),
                                received.getGameId());
                            System.out.println("Added to shopping cart");
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
                            System.out.println("Getting shopping cart");
                            ArrayList<Game> games = databaseServer.getShoppingCart(received.getUserName());
                            //System.out.println(games);
                            CartPackage toSend = new CartPackage(games);
                            sendDataToServer(toSend);
                            break;
                        }
                        default:
                            System.out.println("Type not found");
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

    public void sendDataToServer(UserPackage obj) throws IOException {
        //OutputStream outputStream = socket.getOutputStream();
        //ObjectOutputStream objectOutputStream = new ObjectOutputStream(outputStream);
        objectOutputStream.writeObject(obj);
        System.out.println("Sent object");
    }

    public void sendDataToServer(GamePackage obj) throws IOException {
        //OutputStream outputStream = socket.getOutputStream();
        //ObjectOutputStream objectOutputStream = new ObjectOutputStream(outputStream);
        objectOutputStream.writeObject(obj);
        System.out.println("Sent object");
    }

    public void sendDataToServer(CartPackage obj) throws IOException {
        //OutputStream outputStream = socket.getOutputStream();
        //ObjectOutputStream objectOutputStream = new ObjectOutputStream(outputStream);
        objectOutputStream.writeObject(obj);
        System.out.println("Sent object");
    }

    public void disconnect() throws IOException {
        System.out.println("Closed");
        socket.close();
    }
    }

