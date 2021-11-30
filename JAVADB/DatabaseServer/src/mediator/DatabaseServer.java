package mediator;

import Sockets.Models.Game;
import Sockets.Models.User;

import java.sql.SQLException;

public interface DatabaseServer
{
  User getUserDB(String username, String password) throws SQLException;
  User registerUser(String username, String password, String firstName, String lastName) throws SQLException;
  boolean checkIfUsernameExists(String username) throws SQLException;
  Game getGameDB(String gameName) throws SQLException;
  Game registerGame(String gameName, double price, String description, String specifications, int IGNRating, String ESRBRating, String photoURL, String releaseDate)
      throws SQLException;
  Game buyGame(int gameID) throws SQLException;
  String getKey(int gameID) throws SQLException;
  Game getGameByID(int id) throws SQLException;
}
