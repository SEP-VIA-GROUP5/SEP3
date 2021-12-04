package mediator;

import Sockets.Models.Game;
import Sockets.Models.User;

import javax.print.DocFlavor;
import java.sql.SQLException;
import java.text.ParseException;
import java.util.ArrayList;

public interface DatabaseServer
{
  User getUserDB(String username, String password) throws SQLException;
  //Test for getting a receipt for a specific user
  User getUserDB (String username) throws SQLException;
  User registerUser(String username, String password, String firstName, String lastName) throws SQLException;
  boolean checkIfUsernameExists(String username) throws SQLException;
  Game getGameDB(String gameName) throws SQLException;
  Game registerGame(String gameName, double price, String description, String specifications, int IGNRating, String ESRBRating, String photoURL, String releaseDate)
      throws SQLException, ParseException;
  Game buyGame(int gameID, String username) throws SQLException;
  String getKey(int gameID) throws SQLException;
  Game getGameByID(int id) throws SQLException;
  ArrayList<Game> getAllGames() throws SQLException;
  ArrayList<Game> searchGamesByName(String gameName) throws SQLException;
  void addToShoppingCart(String username, int gameID) throws SQLException;
  ArrayList<Game> removeFromShoppingCart(String username, int gameID) throws SQLException;
  ArrayList<Game> getShoppingCart(String username) throws SQLException;
  void addToLibrary(String username, int gameID, String gameKey) throws SQLException;
  ArrayList<Game> getLibrary(String username) throws SQLException;
}
