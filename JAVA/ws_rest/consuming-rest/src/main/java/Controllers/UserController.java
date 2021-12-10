package Controllers;

import Services.IUserService;
import Services.UserService;
import Sockets.Models.User;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.io.IOException;

@RestController
@CrossOrigin
@RequestMapping(value = "/user")
public class UserController {


    private IUserService userService;

    public UserController() throws IOException {
        userService = new UserService();
    }

    /**
     * Retrieves user from database
     * @param username user name
     * @return returns user object
     */
    @GetMapping("/getter")
    public ResponseEntity<User> GetUser(@RequestParam String username)
    {
        try{
            System.out.println(username);
            User user = userService.GetUser(username);

            if(user == null) {
                return ResponseEntity.notFound().build();
            }
            return ResponseEntity.ok(user);
        }
        catch (Exception e)
        {
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }

    /**
     * Validates user credentials
     * @param username user name
     * @param password password
     * @return returns user if credentials match
     */
    @GetMapping("/login")
    public ResponseEntity<User> ValidateLogin(@RequestParam String username, @RequestParam String password)
    {
        try{
            User user = userService.ValidateLogin(username,password);
            if(user == null) {
                return ResponseEntity.notFound().build();
            }
            return ResponseEntity.ok(user);
        }
        catch (Exception e)
        {
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }

    /**
     * Registers a new user
     * @param user User object
     * @return validation that user is registered
     */
    @PostMapping("/register")
    public ResponseEntity<User> ValidateRegister(@RequestBody User user)
    {
        try{
            System.out.println(user.toString());
            User userValidation = userService.ValidateRegister(user);

            if(userValidation == null) {
                return ResponseEntity.notFound().build();
            }
            return ResponseEntity.ok(userValidation);
        }
        catch (Exception e)
        {
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }

    /**
     * Registers a new user
     * @param user User object
     * @return validation that user is registered
     */
    @PutMapping("/edit")
    public ResponseEntity<User> EditUser(@RequestBody User user)
    {
        try{
            System.out.println(user.toString());
            User userValidation = userService.editUser(user);

            if(userValidation == null) {
                return ResponseEntity.notFound().build();
            }
            return ResponseEntity.ok(userValidation);
        }
        catch (Exception e)
        {
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }

    /**
     * Changes users password
     * @param user User object
     * @return validation that user password is changed
     */
    @PutMapping("/changePassword")
    public ResponseEntity<User> changePassword(@RequestBody User user)
    {
        try{
            User userValidation = userService.changePassword(user);

            if(userValidation == null) {
                return ResponseEntity.notFound().build();
            }
            return ResponseEntity.ok(userValidation);
        }
        catch (Exception e)
        {
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }
}
