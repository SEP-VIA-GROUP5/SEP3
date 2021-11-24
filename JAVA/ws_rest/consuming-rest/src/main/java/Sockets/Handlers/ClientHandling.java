package Sockets.Handlers;


import Sockets.Models.User;
import Sockets.Packages.UserPackage;

import java.io.*;
import java.net.Socket;

public class ClientHandling {

    private static String HOST = "localhost";
    private static int PORT = 65456;
    private Socket socket;
    private InputStream inputStream;
    private ObjectInputStream objectInputStream;
    private ObjectOutputStream objectOutputStream;
    private OutputStream outputStream;

    public ClientHandling() throws IOException {
        connect();
    }

    public void sendToServer(Object obj) throws IOException {
        objectOutputStream.writeObject(obj);
    }

    public Object receiveFromServer() throws IOException, ClassNotFoundException
    {
        System.out.println("Received");
        final Object obj = objectInputStream.readObject();
        if(obj instanceof UserPackage)
        {
            final UserPackage user = (UserPackage) obj;
            return user;
        }
        else{

        }
        return null;
    }

    public void connect() throws IOException {
        System.out.println("Connecting...");
        this.socket = new Socket(HOST, PORT);
        outputStream = socket.getOutputStream();
        objectOutputStream = new ObjectOutputStream(outputStream);
        inputStream = socket.getInputStream();
        objectInputStream = new ObjectInputStream(inputStream);
        System.out.println("Connected");
    }

    public void disconnect() throws IOException {
        System.out.println("Closed");
        socket.close();
    }
}