package mediator;

import Sockets.Models.User;

import java.sql.SQLException;

public interface DatabaseServer
{
  User getUserDB(String username, String password) throws SQLException;
  User registerUser(String username, String password, String firstName, String lastName) throws SQLException;
  boolean checkIfUsernameExists(String username) throws SQLException;
}
