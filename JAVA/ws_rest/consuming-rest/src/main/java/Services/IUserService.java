package Services;

import Sockets.Models.User;

import java.io.IOException;

public interface IUserService {

    User ValidateLogin(String username, String password)
        throws IOException, ClassNotFoundException;

    User ValidateRegister(String username, String password, String firstName, String lastName)
        throws IOException, ClassNotFoundException;
}
