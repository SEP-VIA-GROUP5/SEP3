package Services;

import Sockets.Handlers.ClientHandling;
import Sockets.Models.User;
import Sockets.Packages.UserPackage;
import com.google.gson.Gson;
import com.google.gson.JsonElement;

import java.io.IOException;
/**
 * Sends information to tier 3 using sockets about Users
 */
public class UserService implements IUserService {

    private ClientHandling clientHandling;

    public UserService() throws IOException {
        clientHandling = new ClientHandling();
    }

    /**
     * Method used to get a user as an object by a username
     * <p>
     * @param  username  username of a user
     * @return a user object
     *
     */
    @Override
    public User GetUser(String username)
            throws IOException, ClassNotFoundException {
        UserPackage userPackage = new UserPackage(new User(username), "gettingUser");
        clientHandling.sendToServer(userPackage);

        //Received back the confirmation and post it, such that it can be verified
        Object dataReceivedFromServer = clientHandling.receiveFromServer();
        userPackage = (UserPackage) dataReceivedFromServer;
        return userPackage.getUser();
    }

    /**
     * Method used to validate login. Takes a username and password and sends it to
     * the database server to validate it.
     * <p>
     * @param  username username of a user
     * @param password password of a user
     * @return user if validated, otherwise user as null object
     *
     */
    @Override
    public User ValidateLogin(String username, String password)
            throws IOException, ClassNotFoundException {
        //Sends user requested for validation from Client Blazor
        UserPackage userPackage = new UserPackage(new User(username, password), "validateLogin");
        clientHandling.sendToServer(userPackage);

        //Received back the confirmation and post it, such that it can be verified
        Object dataReceivedFromServer = clientHandling.receiveFromServer();
        userPackage = (UserPackage) dataReceivedFromServer;
        return userPackage.getUser();
    }

    /**
     * Method used to register a user in the database. Take a user object with username,
     * password first name and last name.
     * <p>
     * @param  user  User object
     * @return User object that was registered
     *
     */
    @Override
    public User ValidateRegister(User user)
            throws IOException, ClassNotFoundException {
        //sends username and password to database for it to validate new user registration
        UserPackage userPackage = new UserPackage(user, "validateRegister");
        clientHandling.sendToServer(userPackage);

        //received back the validation result
        Object dataReceivedFromServer = clientHandling.receiveFromServer();
        userPackage = (UserPackage) dataReceivedFromServer;
        System.out.println("Register");
        return userPackage.getUser();
    }

    /**
     * Method used to edit users information. Takes a user object with updated
     * values for variables and sends it to the database to change the values
     * <p>
     * @param  user  User object
     * @return updated user object if updated, otherwise null
     *
     */
    @Override
    public User editUser(User user) {
        try {
            UserPackage userPackage = new UserPackage(user, "editUser");
            clientHandling.sendToServer(userPackage);
            return user;
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }

    }

    /**
     * Method used to change a password of a user. Takes a user object with a
     * changed value for a variable password.
     * <p>
     * @param  user object of User
     * @return user object with changed password if changed, otherwise null
     *
     */
    @Override
    public User changePassword(User user) {
        try {
            UserPackage userPackage = new UserPackage(user, "changePassword");
            clientHandling.sendToServer(userPackage);
            return user;
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }
}
