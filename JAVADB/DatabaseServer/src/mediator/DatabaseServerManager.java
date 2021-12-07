package mediator;

import Sockets.Models.Game;
import Sockets.Models.GameKey;
import Sockets.Models.User;

import java.sql.*;
import java.sql.Date;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;

import static java.lang.String.valueOf;

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


    //Test for getting receipt for a specific user
    @Override public User getUserDB (String username) throws SQLException
    {
        User user = null;
        try(Connection connection = getConnection())
        {

            PreparedStatement statement = connection.prepareStatement("SELECT * FROM users WHERE username = ?;");
            statement.setString(1, username);

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
        throws SQLException, ParseException
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
            statement.setDate(8, java.sql.Date.valueOf(releaseDate));

            statement.executeUpdate();

            game = getGameDB(gameName);
        }
        return game;
    }

    @Override public Game buyGame(int gameID, String username) throws SQLException
    {
        Game gameDummy = getGameByID(gameID);
        Game gameToReturn;
        String productKey = getKey(gameID);
        addToLibrary(username, gameID, productKey);
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

    @Override public ArrayList<Game> getAllGames() throws SQLException
    {
        ArrayList<Game> games = new ArrayList<>();

        try(Connection connection = getConnection())
        {
            PreparedStatement statement = connection.prepareStatement("SELECT * FROM games");
            ResultSet resultSet = statement.executeQuery();
            while(resultSet.next())
            {
                Game game = new Game();
                game.setDescription(resultSet.getString("description"));
                game.setESRBRating(resultSet.getString("esrb_rating"));
                game.setGameId(resultSet.getInt("game_id"));
                game.setGameName(resultSet.getString("game_name"));
                game.setIGNRating(resultSet.getInt("ign_rating"));
                game.setPhotoURL(resultSet.getString("photo_url"));
                game.setPrice(resultSet.getDouble("price"));
                game.setReleaseDate(resultSet.getString("release_date"));
                game.setSpecifications(resultSet.getString("specifications"));

                games.add(game);
            }
        }
        return games;
    }

    @Override public ArrayList<Game> searchGamesByName(String gameName)
        throws SQLException
    {
        ArrayList<Game> games = new ArrayList<>();
        String toSearch = gameName + ":*";

        try(Connection connection = getConnection())
        {
            PreparedStatement statement = connection.prepareStatement("SELECT * FROM games WHERE to_tsvector(game_name) @@ to_tsquery(?);");

            statement.setString(1, toSearch);

            ResultSet resultSet = statement.executeQuery();
            while(resultSet.next())
            {
                Game game = new Game();
                game.setDescription(resultSet.getString("description"));
                game.setESRBRating(resultSet.getString("esrb_rating"));
                game.setGameId(resultSet.getInt("game_id"));
                game.setGameName(resultSet.getString("game_name"));
                game.setIGNRating(resultSet.getInt("ign_rating"));
                game.setPhotoURL(resultSet.getString("photo_url"));
                game.setPrice(resultSet.getDouble("price"));
                game.setReleaseDate(resultSet.getString("release_date"));
                game.setSpecifications(resultSet.getString("specifications"));

                games.add(game);
            }
        }
        return games;
    }

//    @Override public void addToShoppingCart(String username, int gameID)
//        throws SQLException
//    {
//        try(Connection connection = getConnection())
//        {
//            PreparedStatement statement = connection.prepareStatement("INSERT INTO shopping_cart(user_id, game_id) VALUES (?, ?)");
//            statement.setInt(1, getUserDB(username).getId());
//            statement.setInt(2, gameID);
//            statement.executeUpdate();
//        }
//    }

//    @Override public ArrayList<Game> removeFromShoppingCart(String username,
//        int gameID) throws SQLException
//    {
//        try(Connection connection = getConnection())
//        {
//            PreparedStatement statement = connection.prepareStatement("DELETE FROM shopping_cart WHERE user_id = ? AND game_id = ?;");
//            statement.setInt(1, getUserDB(username).getId());
//            statement.setInt(2, gameID);
//            statement.executeUpdate();
//        }
//        ArrayList<Game> games = getShoppingCart(username);
//        return games;
//    }
//
//    @Override public ArrayList<Game> getShoppingCart(String username)
//        throws SQLException
//    {
//        ArrayList<Game> games = new ArrayList<Game>();
//        try(Connection connection = getConnection())
//        {
//            PreparedStatement statement = connection.prepareStatement("SELECT game_id FROM shopping_cart WHERE user_id = ?");
//            statement.setInt(1, getUserDB(username).getId());
//            ResultSet resultSet = statement.executeQuery();
//            while(resultSet.next())
//            {
//                Game game = getGameByID(resultSet.getInt("game_id"));
//                games.add(game);
//            }
//        }
//        return games;
//    }

    @Override public ArrayList<Game> removeFromShoppingCart(String username,
        int gameID) throws SQLException
    {
        int id = getUserDB(username).getId();
        try(Connection connection = getConnection())
        {

            PreparedStatement statement = connection.prepareStatement("DELETE FROM shopping_cart WHERE user_id = ? AND game_id = ?;");
            statement.setInt(1, id);
            statement.setInt(2, gameID);
            statement.executeUpdate();
        }
        ArrayList<Game> games = getShoppingCart(username);
        return games;
    }
    @Override public ArrayList<Game> getShoppingCart(String username)
        throws SQLException
    {
        ArrayList<Game> games = new ArrayList<Game>();
        int id = getUserDB(username).getId();
        try(Connection connection = getConnection())
        {
            PreparedStatement statement = connection.prepareStatement("SELECT game_id FROM shopping_cart WHERE user_id = ?");
            statement.setInt(1, id);
            ResultSet resultSet = statement.executeQuery();
            while(resultSet.next())
            {
                Game game = getGameByID(resultSet.getInt("game_id"));
                games.add(game);
            }
        }
        return games;
    }

    @Override public void addToLibrary(String username, int gameID, String gameKey)
        throws SQLException
    {
        int userID = getUserDB(username).getId();
        try(Connection connection = getConnection())
        {
            PreparedStatement statement = connection.prepareStatement("INSERT INTO library(game_id, user_id, purchased_game_key) VALUES (?, ?, ?)");
            statement.setInt(1, gameID);
            statement.setInt(2, userID);
            statement.setString(3, gameKey);
            statement.executeUpdate();
        }
    }

    @Override public ArrayList<Game> getLibrary(String username)
        throws SQLException
    {
        int id = getUserDB(username).getId();
        ArrayList<Game> games = new ArrayList<>();
        Game game;
        String productKey;
        try(Connection connection = getConnection())
        {
            PreparedStatement statement = connection.prepareStatement("SELECT game_id, purchased_game_key FROM library WHERE user_id = ?;");
            statement.setInt(1, id);

            ResultSet resultSet = statement.executeQuery();

            while(resultSet.next())
            {
                int game_id = resultSet.getInt("game_id");
                productKey = resultSet.getString("purchased_game_key");
                game = getGameByID(game_id);
                GameKey gameKey = new GameKey(productKey);
                game.setGameKey(gameKey);
                games.add(game);
            }
        }
        return games;
    }

    @Override public void addToShoppingCart(String username, int gameID)
        throws SQLException
    {
        int id = getUserDB(username).getId();
        try(Connection connection = getConnection())
        {

            PreparedStatement statement = connection.prepareStatement("INSERT INTO shopping_cart(user_id, game_id) VALUES (?, ?)");
            statement.setInt(1, id);
            statement.setInt(2, gameID);
            statement.executeUpdate();
        }
    }
    @Override public void editGame(int ID, String gameName, double price,
        String description, String specifications, int IGNRating,
        String ESRBRating, String photoURL, String releaseDate)
        throws SQLException
    {
        try(Connection connection = getConnection())
        {
            PreparedStatement statement = connection.prepareStatement("UPDATE games SET game_name = ?,price = ?, description = ?, specifications = ?, ign_rating = ?, esrb_rating = ?, photo_url = ?, release_date = ? WHERE game_id = ?;");
            statement.setString(1, gameName);
            statement.setDouble(2, price);
            statement.setString(3, description);
            statement.setString(4, specifications);
            statement.setInt(5, IGNRating);
            statement.setString(6, ESRBRating);
            statement.setString(7, photoURL);
            statement.setDate(8, java.sql.Date.valueOf(releaseDate));
            statement.setInt(9, ID);
            statement.executeUpdate();
        }
    }

    @Override public ArrayList<Game> sortByDate() throws SQLException
    {
        ArrayList<Game> games = new ArrayList<>();
        try(Connection connection = getConnection())
        {

            PreparedStatement statement = connection.prepareStatement("SELECT * FROM games ORDER BY release_date DESC LIMIT 5");

            ResultSet resultSet = statement.executeQuery();
            while(resultSet.next())
            {
                Game game = new Game();
                game.setDescription(resultSet.getString("description"));
                game.setESRBRating(resultSet.getString("esrb_rating"));
                game.setGameId(resultSet.getInt("game_id"));
                game.setGameName(resultSet.getString("game_name"));
                game.setIGNRating(resultSet.getInt("ign_rating"));
                game.setPhotoURL(resultSet.getString("photo_url"));
                game.setPrice(resultSet.getDouble("price"));
                game.setReleaseDate(resultSet.getString("release_date"));
                game.setSpecifications(resultSet.getString("specifications"));

                games.add(game);
            }
        }
        return games;
    }

    @Override public void editUserInfo(int ID, String username, String photo, String firstName, String lastName) throws SQLException
    {
        try(Connection connection = getConnection())
        {
            PreparedStatement statement = connection.prepareStatement("UPDATE Users SET username = ?, photo = ?, first_name = ?, last_name = ? WHERE id = ?");
            statement.setString(1, username);
            statement.setString(2, photo);
            statement.setString(3, firstName);
            statement.setString(4, lastName);
            statement.setInt(5, ID);
            statement.executeUpdate();
        }
    }

    @Override public void changePassword(String username, String password) throws SQLException
    {
        try(Connection connection = getConnection())
        {
            PreparedStatement statement = connection.prepareStatement("UPDATE Users SET password = ? WHERE username = ?");
            statement.setString(1, password);
            statement.setString(2, username);
            statement.executeUpdate();
        }
    }

    @Override public void addToWishlist(String username, int gameID)
        throws SQLException
    {
        User user = getUserDB(username);
        try(Connection connection = getConnection())
        {
            PreparedStatement statement = connection.prepareStatement("INSERT INTO wishlist(user_id, game_id) VALUES(?, ?)");
            statement.setInt(1, user.getId());
            statement.setInt(2, gameID);
            statement.executeUpdate();
        }
    }

    @Override public ArrayList<Game> removeFromWishlist(String username, int gameID)
        throws SQLException
    {
        int id = getUserDB(username).getId();
        try(Connection connection = getConnection())
        {

            PreparedStatement statement = connection.prepareStatement("DELETE FROM wishlist WHERE user_id = ? AND game_id = ?;");
            statement.setInt(1, id);
            statement.setInt(2, gameID);
            statement.executeUpdate();
        }
        ArrayList<Game> games = getWishlist(username);
        return games;
    }

    @Override public ArrayList<Game> getWishlist(String username)
        throws SQLException
    {
        User user = getUserDB(username);
       ArrayList<Game> games = new ArrayList<>();
        try(Connection connection = getConnection())
        {
            PreparedStatement statement = connection.prepareStatement("SELECT * FROM wishlist WHERE user_id = ?");
            statement.setInt(1, user.getId());
            ResultSet resultSet = statement.executeQuery();
            while(resultSet.next())
            {
                Game game = getGameByID(resultSet.getInt("game_id"));
                games.add(game);
            }
        }
        return games;
    }

    private Connection getConnection() throws SQLException
    {
        String url = "jdbc:postgresql://ella.db.elephantsql.com:5432/zgckhgwi";
        String username = "zgckhgwi";
        String password = "S_S0QYXJm9u10Vi53oEXaHAJo0W5Q7vB";
        return DriverManager.getConnection(url, username, password);
    }
}
