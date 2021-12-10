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

    final int PORT = 6789;
    ServerSocket welcomeSocket = new ServerSocket(PORT);
    while(true)
    {
      Socket socket = welcomeSocket.accept();
      ServerHandling c = new ServerHandling(databaseServer, socket);
      Thread t = new Thread(c);
      t.start();
    }
  }
}
