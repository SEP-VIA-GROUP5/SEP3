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
    public void disconnect() throws IOException {
        System.out.println("Closed");
        socket.close();
    }
    }

