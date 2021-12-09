package Controllers;

import Services.GameService;
import Services.IGameService;
import Sockets.Models.Game;
import Sockets.Models.GameCluster;
import Sockets.Models.GameKey;
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

    @GetMapping("/getSearch")
    public ResponseEntity<GameCluster> getSearchGame(@RequestParam String search)
    {
        try{
            GameCluster gameCluster = gameService.getSearch(search);
            if(gameCluster == null)
            {
                return ResponseEntity.badRequest().build();
            }
            return ResponseEntity.ok(gameCluster);
        }
        catch (Exception e)
        {
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
    public ResponseEntity<GameKey> getProductKey(@RequestParam int gameId, @RequestParam String userName){
        try {
            GameKey productKey = gameService.getProductKey(gameId, userName);
            if(productKey==null){
                return ResponseEntity.badRequest().build();
            }
            System.out.println(productKey.getGameKey());
            return ResponseEntity.ok(productKey);
        }
        catch (Exception e){
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }

    @PostMapping("/addGame")
    public ResponseEntity<Game> addGame(@RequestBody Game game){
        try {
            Game gameValidation = gameService.addGame(game);
            if(gameValidation==null){
                return ResponseEntity.badRequest().build();
            }
            return ResponseEntity.ok(gameValidation);
        }
        catch (Exception e){
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }

    @PostMapping("/cart/add")
    public ResponseEntity<String> addGameToShoppingCart(@RequestParam String userName, @RequestBody Game game){
        try {
            String confirmation = gameService.addGameToShoppingCart(userName,game.getGameId());
            if(confirmation==null){
                return ResponseEntity.badRequest().build();
            }
            return ResponseEntity.ok(confirmation);
        }
        catch (Exception e){
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }

    @DeleteMapping("/cart/remove")
    public ResponseEntity<GameCluster> removeGameToShoppingCart(@RequestParam String userName, @RequestParam int gameId) {
        try {
            GameCluster newGameCluster = gameService.removeGameFromShoppingCart(userName, gameId);
            if (newGameCluster == null) {
                return ResponseEntity.badRequest().build();
            }
            return ResponseEntity.ok(newGameCluster);
        } catch (Exception e) {
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }

    @GetMapping("/cart/get")
    public ResponseEntity<GameCluster> getShoppingCart(@RequestParam String userName) {
        try {
            GameCluster newGameCluster = gameService.getShoppingCart(userName);
            if (newGameCluster == null) {
                return ResponseEntity.badRequest().build();
            }
            return ResponseEntity.ok(newGameCluster);
        } catch (Exception e) {
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }
    @GetMapping("/library/get")
    public ResponseEntity<GameCluster> getLibrary(@RequestParam String userName) {
        try {
            GameCluster newGameCluster = gameService.getLibrary(userName);
            if (newGameCluster == null) {
                return ResponseEntity.badRequest().build();
            }
            return ResponseEntity.ok(newGameCluster);
        } catch (Exception e) {
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }
    @PutMapping("/editGame")
    public ResponseEntity<Game> editGame(@RequestBody Game game) {
        try {
            Game gameValidation = gameService.editGame(game);

            if (gameValidation == null) {
                return ResponseEntity.badRequest().build();
            }
            return ResponseEntity.ok(gameValidation);
        } catch (Exception e) {
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }

    @PostMapping("/wishlist/add")
    public ResponseEntity<String> addGameToWishlist(@RequestParam String userName, @RequestBody Game game){
        try {
            String confirmation =gameService.addGameToWishlist(userName,game.getGameId());
            if(confirmation==null){
                return ResponseEntity.badRequest().build();
            }
            return ResponseEntity.ok(confirmation);
        }
        catch (Exception e){
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }

    @DeleteMapping("/wishlist/remove")
    public ResponseEntity<GameCluster> removeGameToWishlist(@RequestParam String userName, @RequestParam int gameId) {
        try {
            GameCluster newGameCluster = gameService.removeGameFromWishlist(userName, gameId);
            if (newGameCluster == null) {
                return ResponseEntity.badRequest().build();
            }
            return ResponseEntity.ok(newGameCluster);
        } catch (Exception e) {
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }

    @GetMapping("/wishlist/get")
    public ResponseEntity<GameCluster> getWishlist(@RequestParam String userName) {
        try {
            GameCluster newGameCluster = gameService.getWishlist(userName);
            if (newGameCluster == null) {
                return ResponseEntity.badRequest().build();
            }
            return ResponseEntity.ok(newGameCluster);
        } catch (Exception e) {
            System.out.println(e.getMessage());
            return ResponseEntity.badRequest().build();
        }
    }

    @GetMapping("/getNewRelease")
    public ResponseEntity<GameCluster> getGameCluster(){
        try {
            GameCluster gameCluster = gameService.sortByDate();
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


}
