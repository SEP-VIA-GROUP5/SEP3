package Sockets.Handlers;


import Sockets.Models.User;
import Sockets.Packages.CartPackage;
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

    /**
     * Sends object to database server
     * @param obj object to send
     * @throws IOException throws exception when object is incorrect
     */
    public void sendToServer(Object obj) throws IOException {
        outStream.writeObject(obj);
    }

    /**
     * Receives objects from database server
     * @return returns the extracted object from package or null if package does not exist
     * @throws IOException throws exception when object is incorrect
     * @throws ClassNotFoundException throws exception when object is incorrect
     */
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
        else if(obj instanceof CartPackage)
        {
            final CartPackage cart = (CartPackage) obj;
            return cart;
        }
        else{
            //TODO
        }
        return null;
    }

    /**
     * Connects to database server
     * @throws IOException when the connection is interrupted
     */
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

    /**
     * Disconnects from database server
     * @throws IOException when the disconnection is interrupted
     */
    public void disconnect() throws IOException {
        System.out.println("Closed");
        socket.close();
    }
}