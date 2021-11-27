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

    @GetMapping("/register")
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
}
