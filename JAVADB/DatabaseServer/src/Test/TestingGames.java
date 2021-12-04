package Test;

import mediator.DatabaseServer;
import mediator.DatabaseServerManager;

import java.sql.SQLException;

public class TestingGames
{
  public static void main(String[] args) throws SQLException
  {
    DatabaseServer databaseServer = new DatabaseServerManager();
    System.out.println(databaseServer.getShoppingCart("admin"));
  }
}
