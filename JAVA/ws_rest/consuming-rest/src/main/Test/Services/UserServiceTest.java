package Services;

import Sockets.Models.User;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.io.IOException;

import static org.junit.jupiter.api.Assertions.*;

class UserServiceTest {

    private IUserService userService;

    @BeforeEach
    void setUp() throws IOException {
        userService = new UserService();

        System.out.println("---> Set up interface");
    }

    @AfterEach
    void tearDown() {
        System.out.println("<--- Test completed");
    }

    @Test
    void getUser() throws IOException, ClassNotFoundException {
        assertThrows(java.lang.NullPointerException.class, () -> {
            User user = userService.GetUser("No user with this name");
        });
        System.out.println("Second - valid user");
        assertDoesNotThrow(() -> userService.GetUser("Testing"),"Method does not throw error if user is found");
    }

    @Test
    void validateLogin() {
        //if both are invalid
        assertThrows(java.lang.NullPointerException.class, () -> {
            User user = userService.ValidateLogin("No user with this name","no pass");
        });
        //if just password is invalid
        assertThrows(java.lang.NullPointerException.class, () -> {
            User user = userService.ValidateLogin("Testing","no pass");
        });
        //if just username is invalid
        assertThrows(java.lang.NullPointerException.class, () -> {
            User user = userService.ValidateLogin("No user with this name","Tested");
        });
        //if both are valid
        assertDoesNotThrow(() -> userService.ValidateLogin("Testing","Tested"),"Method does not throw error if user is found");

    }

    @Test
    void validateRegister() throws IOException, ClassNotFoundException {
        User user = new User("RegisterTest","Register","Tested","Method");
        User returnedUser = userService.ValidateRegister(user);
        assertNotNull(returnedUser);
    }

    @Test
    void editUser() {
        //if id is invalid
        assertDoesNotThrow(() -> userService.editUser(new User("RegisterTest","passChanged","Tested","Method")),"Method does not throw error if user is found");
        User user = userService.editUser(new User(11,"Testing","Tested","pass","Tested"));
        assertNotNull(user);
    }

    @Test
    void changePassword() {
        assertDoesNotThrow(() -> userService.changePassword(new User("RegisterTest","passchanged","Tested","Method")),"Method does not throw error if user is found");
        User user = userService.changePassword(new User("Testing","changePass","Tested","Tested"));
        assertNotNull(user);
    }
}