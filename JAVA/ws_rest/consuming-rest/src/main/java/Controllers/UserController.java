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

    //Test for getting a receipt for a specific user
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
