package Test;

import Sockets.Handling.ServerHandling;
import Sockets.Models.User;
import Sockets.Packages.UserPackage;
import mediator.DatabaseServer;
import mediator.DatabaseServerManager;

import javax.imageio.IIOException;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.sql.SQLException;

public class StartServer
{
  public static void main(String[] args) throws SQLException, IOException
  {
    DatabaseServer databaseServer = new DatabaseServerManager();
//    ServerHandling serverHandling = new ServerHandling(databaseServer);

    final int PORT = 6789;
    System.out.println("Starting Server...");
    // Create welcoming socket at port 6789
    ServerSocket welcomeSocket = new ServerSocket(PORT);
    while (true)
    {
      System.out.println("Waiting for a client...");
      // Wait, on welcoming socket for contact by clientSocket
      Socket socket = welcomeSocket.accept();
      // Start a thread with the client communication
      ServerHandling c = new ServerHandling(databaseServer, socket);
      Thread t = new Thread(c);
      t.start();
    }
  }
}
