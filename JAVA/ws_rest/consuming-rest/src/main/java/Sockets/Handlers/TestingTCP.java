package Sockets.Handlers;

import Services.GameService;
import Sockets.Models.GameCluster;
import Sockets.Models.User;
import Sockets.Packages.UserPackage;

import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.Socket;

public class TestingTCP
{
  public static void main(String[] args) throws Exception
  {
    GameService gameService = new GameService();
    GameCluster gameCluster = gameService.getSearch("Forza Horizon");
    System.out.println(gameCluster.toString());
  }

}
