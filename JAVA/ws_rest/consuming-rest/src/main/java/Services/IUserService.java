package Services;

import Sockets.Models.User;

import java.io.IOException;

public interface IUserService {

    //Test for getting a receipt for a specific user
    User GetUser(String username)
            throws IOException, ClassNotFoundException;
    User ValidateLogin(String username, String password)
        throws IOException, ClassNotFoundException;

    User ValidateRegister(String username, String password, String firstName, String lastName)
        throws IOException, ClassNotFoundException;
}
