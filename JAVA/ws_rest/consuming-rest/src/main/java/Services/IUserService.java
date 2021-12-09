package Services;

import Sockets.Models.User;

import java.io.IOException;

public interface IUserService {

    //Test for getting a receipt for a specific user
    User GetUser(String username)
            throws IOException, ClassNotFoundException;
    User ValidateLogin(String username, String password)
        throws IOException, ClassNotFoundException;

    User ValidateRegister(User user)
        throws IOException, ClassNotFoundException;

    User editUser(User user);

    User changePassword(User user);
}
