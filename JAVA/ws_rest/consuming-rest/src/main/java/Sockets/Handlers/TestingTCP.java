package Sockets.Handlers;

import Sockets.Models.User;
import Sockets.Packages.UserPackage;

import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.Socket;

public class TestingTCP
{
  public static void main(String[] args) throws Exception
  {
    Socket socket = new Socket("localhost", 6789);
    System.out.println("1");
    ObjectOutputStream outStream = new ObjectOutputStream(socket.getOutputStream());
    System.out.println("2");
    ObjectInputStream inStream = new ObjectInputStream(socket.getInputStream());
    System.out.println("3");
    User user = new User("admin", "admin");
    System.out.println("4");
    UserPackage userPackage = new UserPackage(user, "validateRegister");
    outStream.writeObject(userPackage);
    UserPackage userPackage1 = (UserPackage) inStream.readObject();
    System.out.println(userPackage1.getUser().Password);
  }

}
