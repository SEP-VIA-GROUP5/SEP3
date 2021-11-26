package Services;

import Sockets.Handlers.ClientHandling;
import Sockets.Models.User;
import Sockets.Packages.UserPackage;
import com.google.gson.Gson;
import com.google.gson.JsonElement;

import java.io.IOException;

public class UserService implements IUserService {

    private ClientHandling clientHandling;
    private Gson gson;

    public UserService() throws IOException {
        clientHandling = new ClientHandling();
        gson = new Gson();
    }

    @Override
    public User ValidateLogin(String username, String password)
        throws IOException, ClassNotFoundException
    {
        //Sends user requested for validation from Client Blazor
        UserPackage userPackage = new UserPackage(new User(username,password), "validateLogin");
        clientHandling.sendToServer(userPackage);

        //Received back the confirmation and post it, such that it can be verified
        Object dataReceivedFromServer = clientHandling.receiveFromServer();
        userPackage = (UserPackage) dataReceivedFromServer;
        return userPackage.getUser();
    }

    @Override public User ValidateRegister(User user)
        throws IOException, ClassNotFoundException
    {
        //sends username and password to database for it to validate new user registration
        UserPackage userPackage = new UserPackage(user, "validateRegister");
        clientHandling.sendToServer(userPackage);

        //received back the validation result
        Object dataReceivedFromServer = clientHandling.receiveFromServer();
        userPackage = (UserPackage) dataReceivedFromServer;
        System.out.println("Register");
        return userPackage.getUser();
    }

}
