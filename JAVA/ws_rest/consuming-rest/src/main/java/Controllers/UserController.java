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

    @GetMapping("/changePassword")
    public ResponseEntity<User> ValidateRegister(@RequestParam String username, @RequestParam String password, @RequestParam(value = "firstname") String firstName, @RequestParam(value = "lastname") String lastName)
    {
        try{
            System.out.println(username);
            User user = userService.ValidateRegister(username,password,firstName,lastName);

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
    @GetMapping("/edit")
    public ResponseEntity<User> EditUser(@RequestParam int ID,@RequestParam String username, @RequestParam String photo, @RequestParam(value = "firstname") String firstName, @RequestParam(value = "lastname") String lastName)
    {
        try{
            System.out.println(username);
            User user = userService.editUser(ID, username, photo, firstName, lastName);

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
    @GetMapping("/changePassword")
    public ResponseEntity<User> changePassword(@RequestParam String username, @RequestParam String password)
    {
        try{
            User user = userService.changePassword(username, password);

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
}
