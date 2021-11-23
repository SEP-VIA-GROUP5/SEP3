package Sockets.Handling;

import Sockets.Models.User;
import Sockets.Packages.UserPackage;
import com.google.gson.Gson;
import mediator.DatabaseServer;

import java.io.*;
import java.net.ServerSocket;
import java.net.Socket;
import java.sql.SQLException;

public class ServerHandling implements Runnable{
    private Socket socket;
    private DatabaseServer databaseServer;
    private User user;
    private Gson gson;

    public ServerHandling(DatabaseServer databaseServer) throws IOException, SQLException {
        connect(databaseServer);
    }

    private void connect(DatabaseServer databaseServer) throws IOException
    {
        ServerSocket serverSocket = new ServerSocket(54321);
        System.out.println("Server started...");
        this.socket = serverSocket.accept();
        gson = new Gson();
        this.databaseServer = databaseServer;
    }

    public void run()
    {
        while(true)
        {
            try {
                InputStream inputStream = socket.getInputStream();
                ObjectInputStream objectInputStream = new ObjectInputStream(inputStream);
                Object obj = objectInputStream.readObject();
                if(obj instanceof UserPackage)
                {

                    UserPackage received = (UserPackage)obj;
                    //Receiving user from client
                    user = received.getUser();
                    switch (received.getType())
                    {
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
                        default:
                            System.out.println("Type not found");
                    }
                }

            }
            catch (Exception e)
            {
                e.printStackTrace();
            }
            }


        }

    public void sendDataToServer(UserPackage obj) throws IOException {
        OutputStream outputStream = socket.getOutputStream();
        ObjectOutputStream objectOutputStream = new ObjectOutputStream(outputStream);
        objectOutputStream.writeObject(obj);
        System.out.println("Sent object");
    }
    public void disconnect() throws IOException {
        System.out.println("Closed");
        socket.close();
    }
    }

