package mediator;

import Sockets.Models.Game;
import Sockets.Models.User;

import java.sql.*;

public class DatabaseServerManager implements DatabaseServer
{
    public DatabaseServerManager() throws SQLException {
        DriverManager.registerDriver(new org.postgresql.Driver());
        try {
            Class.forName("org.postgresql.Driver");
        }
        catch (java.lang.ClassNotFoundException e) {
            System.out.println(e.getMessage());
        }
    }

    @Override public User getUserDB (String username, String password) throws SQLException
    {
        User user = null;
        try(Connection connection = getConnection())
        {

            PreparedStatement statement = connection.prepareStatement("SELECT * FROM users WHERE username = ? AND password = ?;");
            statement.setString(1, username);
            statement.setString(2, password);

            ResultSet resultSet = statement.executeQuery();

            while(resultSet.next())
            {
                user = new User(Integer.parseInt(resultSet.getString("id")), resultSet.getString("username"),
                        resultSet.getString("password"), resultSet.getString("photo"),
                        resultSet.getString("first_name"), resultSet.getString("last_name"),
                        resultSet.getString("security_level"), resultSet.getString("role"));
            }
        }
        return user;
    }

    @Override public User registerUser(String username, String password,
                                       String firstName, String lastName) throws SQLException
    {
        User user = null;
        int security_level = 0;
        String role = "Member";
        if (checkIfUsernameExists(username))
        {
            return user;
        }
        try(Connection connection = getConnection())
        {
            PreparedStatement statement = connection.prepareStatement( "INSERT INTO Users(username, password, first_name, last_name, security_level, role) VALUES (?, ?, ?, ?, ?, ?);");
            statement.setString(1, username);
            statement.setString(2, password);
            statement.setString(3, firstName);
            statement.setString(4, lastName);
            statement.setInt(5, security_level);
            statement.setString(6, role);
            statement.executeUpdate();

            user = getUserDB(username, password);
        }
        return user;
    }

    @Override public boolean checkIfUsernameExists(String username)
            throws SQLException
    {
        boolean exists = true;
        String isUsername = null;
        try(Connection connection = getConnection())
        {
            PreparedStatement statement = connection.prepareStatement("SELECT username FROM users WHERE username = ?;");
            statement.setString(1, username);

            ResultSet resultSet = statement.executeQuery();

            while(resultSet.next())
            {
                isUsername = resultSet.getString("username");
            }
            if(isUsername == null)
            {
                exists = false;
            }
        }
        return exists;
    }

    @Override public Game getGameDB(String gameName) throws SQLException
    {
        Game game = null;
        try(Connection connection = getConnection())
        {
            PreparedStatement statement = connection.prepareStatement("SELECT * FROM games WHERE game_name = ?;");
            statement.setString(1, gameName);

            ResultSet resultSet = statement.executeQuery();

            while(resultSet.next())
            {
                game = new Game(resultSet.getInt("game_id"),
                        resultSet.getString("game_name"),
                        resultSet.getDouble("price"),
                        resultSet.getString("description"),
                        resultSet.getString("specifications"),
                        resultSet.getInt("ign_rating"),
                        resultSet.getString("esrb_rating"),
                        resultSet.getString("photo_url"),
                        resultSet.getString("release_date"));
            }
        }
        return game;
    }

    @Override public Game registerGame(String gameName, double price,
                                       String description, String specifications, int IGNRating,
                                       String ESRBRating, String photoURL, String releaseDate)
            throws SQLException
    {
        Game game = null;



        try(Connection connection = getConnection())
        {
            PreparedStatement statement = connection.prepareStatement( "INSERT INTO games(game_name, price, description, specifications, ign_rating, esrb_rating, photo_url, release_date) VALUES (?, ?, ?, ?, ?, ?, ?, ?);");
            statement.setString(1, gameName);
            statement.setDouble(2, price);
            statement.setString(3, description);
            statement.setString(4, specifications);
            statement.setInt(5, IGNRating);
            statement.setString(6, ESRBRating);
            statement.setString(7, photoURL);
            statement.setString(8, releaseDate);

            statement.executeUpdate();

            game = getGameDB(gameName);
        }
        return game;
    }

    @Override public Game buyGame(int gameID) throws SQLException
    {
        Game gameDummy = getGameByID(gameID);
        Game gameToReturn;
        String productKey = getKey(gameID);

        try(Connection connection = getConnection())
        {
            gameToReturn = new Game(gameDummy.getGameId(),
                    gameDummy.getGameName(),
                    gameDummy.getPrice(),
                    gameDummy.getDescription(),
                    gameDummy.getSpecifications(),
                    gameDummy.getIGNRating(),
                    gameDummy.getESRBRating(),
                    gameDummy.getPhotoURL(),
                    gameDummy.getReleaseDate(),
                    productKey);
            PreparedStatement statement = connection.prepareStatement("DELETE FROM games_keys WHERE game_key = ?;");

            statement.setString(1, productKey);

            statement.executeUpdate();
        }
        return gameToReturn;
    }

    @Override public String getKey(int gameID) throws SQLException
    {
        String productKey = null;
        try(Connection connection = getConnection())
        {

            PreparedStatement statement = connection.prepareStatement("SELECT game_key FROM games_keys WHERE game_id = ? LIMIT 1;");
            statement.setInt(1, gameID);

            ResultSet resultSet = statement.executeQuery();

            while(resultSet.next())
            {
                productKey = resultSet.getString("game_key");
            }
        }
        return productKey;
    }

    @Override public Game getGameByID(int id) throws SQLException
    {
        Game game = null;
        try(Connection connection = getConnection())
        {
            PreparedStatement statement = connection.prepareStatement("SELECT * FROM games WHERE game_id = ?;");
            statement.setInt(1, id);

            ResultSet resultSet = statement.executeQuery();

            while(resultSet.next())
            {
                game = new Game(resultSet.getInt("game_id"),
                        resultSet.getString("game_name"),
                        resultSet.getDouble("price"),
                        resultSet.getString("description"),
                        resultSet.getString("specifications"),
                        resultSet.getInt("ign_rating"),
                        resultSet.getString("esrb_rating"),
                        resultSet.getString("photo_url"),
                        resultSet.getString("release_date"));
            }
        }
        return game;
    }

    private Connection getConnection() throws SQLException
    {
        String url = "jdbc:postgresql://ella.db.elephantsql.com:5432/zgckhgwi";
        String username = "zgckhgwi";
        String password = "S_S0QYXJm9u10Vi53oEXaHAJo0W5Q7vB";
        return DriverManager.getConnection(url, username, password);
    }
}
