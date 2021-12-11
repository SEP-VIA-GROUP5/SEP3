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

/**
 * This class handles communication with database.
 */
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

    /**
     * A method that returns user from database by username and password.
     * @param username username.
     * @param password password.
     * @return user object.
     * @throws SQLException
     */
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
                        resultSet.getInt("security_level"), resultSet.getString("role"));
            }
        }
        return user;
    }

    /**
     * A method that returns user from database by username.
     * @param username username.
     * @return user object.
     * @throws SQLException
     */
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
                        resultSet.getInt("security_level"), resultSet.getString("role"));
            }
        }
        return user;
    }

    /**
     * A method that registers user into the databse.
     * @param user user object with user details.
     * @return user object.
     * @throws SQLException
     */
    @Override public User registerUser(User user) throws SQLException
    {
        User validateUser = null;
        if (checkIfUsernameExists(user.getUsername()))
        {
            return null;
        }
        try(Connection connection = getConnection())
        {
            PreparedStatement statement = connection.prepareStatement( "INSERT INTO Users(username, password, first_name, last_name, security_level, role) VALUES (?, ?, ?, ?, ?, ?);");
            statement.setString(1, user.getUsername());
            statement.setString(2, user.getPassword());
            statement.setString(3, user.getFirstName());
            statement.setString(4, user.getLastName());
            statement.setInt(5, user.getSecurityLevel());
            statement.setString(6, user.getRole());
            statement.executeUpdate();

            validateUser = getUserDB(user.getUsername());
        }

        return validateUser;
    }

    /**
     * A method that checks if such username already exist in the database.
     * @param username username.
     * @return true if username already exists, false if otherwise.
     * @throws SQLException
     */
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

    /**
     * A method that gets a game from database.
     * @param gameName name of the game.
     * @return game object with it's details.
     * @throws SQLException
     */
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

    /**
     * A method that adds a game to the database.
     * @param game game object.
     * @throws SQLException
     */
    @Override public void registerGame(Game game)
        throws SQLException
    {
        try(Connection connection = getConnection())
        {
            PreparedStatement statement = connection.prepareStatement( "INSERT INTO games(game_name, price, description, specifications, ign_rating, esrb_rating, photo_url, release_date) VALUES (?, ?, ?, ?, ?, ?, ?, ?);");
            statement.setString(1, game.getGameName());
            statement.setDouble(2, game.getPrice());
            statement.setString(3, game.getDescription());
            statement.setString(4, game.getSpecifications());
            statement.setInt(5, game.getIGNRating());
            statement.setString(6, game.getESRBRating());
            statement.setString(7, game.getPhotoURL());
            statement.setDate(8, java.sql.Date.valueOf(game.getReleaseDate()));

            statement.executeUpdate();
        }
    }

    /**
     * A method that takes and removes game product key from database.
     * @param gameID gamer ID.
     * @param username user's username.
     * @return bought game object with product key.
     * @throws SQLException
     */
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

    /**
     * A method that gets a product key of a game from database.
     * @param gameID game ID.
     * @return string product key.
     * @throws SQLException
     */
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

    /**
     * A method tyhat returns a game by ID.
     * @param id game ID.
     * @return game object.
     * @throws SQLException
     */
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

    /**
     * A method that gets all games from the database.
     * @return array list of all games.
     * @throws SQLException
     */
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

    /**
     * A method that searches games by given string.
     * @param gameName game that is being searched.
     * @return array list of found games.
     * @throws SQLException
     */
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

    /**
     *This method removes a game from shopping cart.
     * @param username username.
     * @param gameID game ID.
     * @return array list of games without game that has to be removed.
     * @throws SQLException
     */
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

    /**
     * A method that gets games from shopping cart.
     * @param username username.
     * @return arraylist of games from shopping cart.
     * @throws SQLException
     */
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

    /**
     * A method that adds a game to users library.
     * @param username username.
     * @param gameID game ID.
     * @param gameKey game product key.
     * @throws SQLException
     */
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

    /**
     * A method that gets games from library.
     * @param username username.
     * @return array list of games.
     * @throws SQLException
     */
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

    /**
     * A method that adds a game to shopping cart.
     * @param username username.
     * @param gameID game ID.
     * @throws SQLException
     */
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

    /**
     * A method that edits the game in the database.
     * @param game game, that has to be edited.
     * @throws SQLException
     */
    @Override public void editGame(Game game)
        throws SQLException
    {
        try(Connection connection = getConnection())
        {
            PreparedStatement statement = connection.prepareStatement("UPDATE games SET game_name = ?,price = ?, description = ?, specifications = ?, ign_rating = ?, esrb_rating = ?, photo_url = ?, release_date = ? WHERE game_id = ?;");
            statement.setString(1, game.getGameName());
            statement.setDouble(2, game.getPrice());
            statement.setString(3, game.getDescription());
            statement.setString(4, game.getSpecifications());
            statement.setInt(5, game.getIGNRating());
            statement.setString(6, game.getESRBRating());
            statement.setString(7, game.getPhotoURL());
            statement.setDate(8, java.sql.Date.valueOf(game.getReleaseDate()));
            statement.setInt(9, game.getGameId());
            statement.executeUpdate();
        }
    }

    /**
     * A method, that sorts games by date.
     * @return array list of games sorted by date.
     * @throws SQLException
     */
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

    /**
     * A method, that edits users information.
     * @param user edited user.
     * @throws SQLException
     */
    @Override public void editUserInfo(User user) throws SQLException
    {
        try(Connection connection = getConnection())
        {
            PreparedStatement statement = connection.prepareStatement("UPDATE Users SET username = ?, photo = ?, first_name = ?, last_name = ? WHERE id = ?");
            statement.setString(1, user.getUsername());
            statement.setString(2, user.getPhoto());
            statement.setString(3, user.getFirstName());
            statement.setString(4, user.getLastName());
            statement.setInt(5, user.getId());
            statement.executeUpdate();
        }
    }

    /**
     * A method that changes users password.
     * @param user user.
     * @throws SQLException
     */
    @Override public void changePassword(User user) throws SQLException
    {
        try(Connection connection = getConnection())
        {
            PreparedStatement statement = connection.prepareStatement("UPDATE Users SET password = ? WHERE username = ?");
            statement.setString(1, user.getPassword());
            statement.setString(2, user.getUsername());
            statement.executeUpdate();
        }
    }

    /**
     * A method, that add a game to the wish list.
     * @param username username.
     * @param gameID game ID.
     * @throws SQLException
     */
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

    /**
     * A method, that removes a game from users wish list.
     * @param username username.
     * @param gameID game ID.
     * @return array list of games from users wish list.
     * @throws SQLException
     */
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

    /**
     * A method, that gets user wishlist from database.
     * @param username username.
     * @return array list of games from wish list.
     * @throws SQLException
     */
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

    /**
     * A method, that establishes connection with database.
     * @return connection as an object.
     * @throws SQLException
     */
    private Connection getConnection() throws SQLException
    {
        String url = "jdbc:postgresql://ella.db.elephantsql.com:5432/zgckhgwi";
        String username = "zgckhgwi";
        String password = "S_S0QYXJm9u10Vi53oEXaHAJo0W5Q7vB";
        return DriverManager.getConnection(url, username, password);
    }
}
