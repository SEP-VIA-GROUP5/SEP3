package Sockets.Handlers;


import Sockets.Models.User;
import Sockets.Packages.GamePackage;
import Sockets.Packages.UserPackage;

import java.io.*;
import java.net.Socket;

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
            //System.out.println(user.getUser().getPassword());
            return user;
        }
        else if(obj instanceof GamePackage)
        {
            final GamePackage game = (GamePackage) obj;
            //System.out.println(user.getUser().getPassword());
            return game;
        }
        else{
            //TODO
        }
        return null;
    }

    public void connect() throws IOException {
        System.out.println("Connecting...");
        this.socket = new Socket(HOST, PORT);
        outStream = new ObjectOutputStream(socket.getOutputStream());
        inStream = new ObjectInputStream(socket.getInputStream());

//        User user1 = new User("Lukas", "Jusk");
//        UserPackage userPackage1 = new UserPackage(user1, "lol");
//        outStream.writeObject(userPackage1);

        System.out.println("Connected");
//        disconnect();
    }

    public void disconnect() throws IOException {
        System.out.println("Closed");
        socket.close();
    }
}