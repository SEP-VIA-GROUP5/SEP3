package Sockets.Handlers;


import Sockets.Models.User;
import Sockets.Packages.CartPackage;
import Sockets.Packages.GamePackage;
import Sockets.Packages.UserPackage;

import java.io.*;
import java.net.Socket;
/**
 * Used to establish a connection with tier 3, and send receive object from/to tier 3
 */
public class ClientHandling {

    private final static String HOST = "localhost";
    private final static int PORT = 6789;
    private Socket socket;
    private ObjectInputStream inStream;
    private ObjectOutputStream outStream;

    public ClientHandling() throws IOException {
        connect();
    }

    public void sendToServer(Object obj) throws IOException {
        outStream.writeObject(obj);
    }

    public Object receiveFromServer() throws IOException, ClassNotFoundException
    {
        System.out.println("Received");
        final Object obj = inStream.readObject();
        if(obj instanceof UserPackage)
        {
            final UserPackage user = (UserPackage) obj;
            System.out.println(user.getUser().toString());
            return user;
        }
        else if(obj instanceof GamePackage)
        {
            final GamePackage game = (GamePackage) obj;
            return game;
        }
        else if(obj instanceof CartPackage)
        {
            final CartPackage cart = (CartPackage) obj;
            return cart;
        }
        else{
            return null;
        }
    }

    public void connect() throws IOException {
        System.out.println("Connecting...");
        this.socket = new Socket(HOST, PORT);
        outStream = new ObjectOutputStream(socket.getOutputStream());
        inStream = new ObjectInputStream(socket.getInputStream());
        System.out.println("Connected");
    }

    public void disconnect() throws IOException {
        System.out.println("Closed");
        socket.close();
    }
}