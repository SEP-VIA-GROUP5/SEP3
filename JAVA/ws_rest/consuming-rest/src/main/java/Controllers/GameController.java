package Controllers;

import Services.GameService;
import Services.IGameService;
import Sockets.Models.Game;
import Sockets.Models.GameCluster;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.io.IOException;

@RestController
@CrossOrigin
@RequestMapping(value = "/game")

public class GameController {

    private IGameService gameService;

    public GameController() throws IOException{
        gameService = new GameService();
    }

    @GetMapping("/getGame")
    public ResponseEntity<Game> getGame(@RequestParam String gameName){
        try {
            Game game = gameService.getGame(gameName);
            if(game==null){
                return ResponseEntity.badRequest().build();
            }
            return ResponseEntity.ok(game);
        }
        catch (Exception e){
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }

    @GetMapping("/getCluster")
    public ResponseEntity<GameCluster> getGameCluster(@RequestParam int page){
        try {
            GameCluster gameCluster = gameService.getGameCluster(page);
            if(gameCluster==null){
                return ResponseEntity.badRequest().build();
            }
            return ResponseEntity.ok(gameCluster);
        }
        catch (Exception e){
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }

    @GetMapping("/readReceipt")
    public ResponseEntity<String> getReceipt(@RequestParam int userId, @RequestParam int gameId){
        try {
            String receipt = gameService.getReceipt(userId,gameId);
            if(receipt==null){
                return ResponseEntity.badRequest().build();
            }
            return ResponseEntity.ok(receipt);
        }
        catch (Exception e){
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }

    @GetMapping("/getProductKey")
    public ResponseEntity<String> getProductKey(@RequestParam int gameId){
        try {
            String productKey = gameService.getProductKey(gameId);
            if(productKey==null){
                return ResponseEntity.badRequest().build();
            }
            return ResponseEntity.ok(productKey);
        }
        catch (Exception e){
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }

    @GetMapping("/addGame")
    public ResponseEntity<Game> addGame(@RequestParam String gameName, @RequestParam double price, @RequestParam String photo, @RequestParam String esrb,
                                        @RequestParam String ign, @RequestParam String description, @RequestParam String specifications, @RequestParam String date){
        try {
            Game game = gameService.addGame(gameName,price,photo,esrb,ign,description,specifications,date);
            if(game==null){
                return ResponseEntity.badRequest().build();
            }
            return ResponseEntity.ok(game);
        }
        catch (Exception e){
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }

    @GetMapping("/addProductKey")
    public ResponseEntity<String> addProductKey(@RequestParam int gameId, @RequestParam String productKey){
        try {
            String productKey1 = gameService.addProductKey(gameId,productKey);
            if(productKey1==null){
                return ResponseEntity.badRequest().build();
            }
            return ResponseEntity.ok(productKey1);
        }
        catch (Exception e){
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }
}
