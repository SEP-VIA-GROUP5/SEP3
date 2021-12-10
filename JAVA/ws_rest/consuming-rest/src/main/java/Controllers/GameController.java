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

    /**
     * This method is used to send the game back to the client when requester through this method
     * @param gameName  is given to search for the game from the client
     * @return Game  returns Game object. If the game is not found, returns code 400 (Bad request)
     */
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

    /**
     *  This method is used to send the GameCluster object to the client
     * @param page is given to get a set amount of games to display.
     * @return GameCluster returns GameCluster object. If the page is not filled then returns an empty GameCluster object
     */
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

    /**
     * This method is for searching the games throughout the store
     * @param search the string is given to match with the game names in the database
     * @return GameCluster returns GameCluster object with all the matching game names
     */
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

    /**
     * Method is used to generate the receipt after buying a game
     * @param userId the user id is given to the program to generate a receipt and link a purchase with user
     * @param gameId the game id is given to the program to generate a receipt and link a purchased game with the user
     * @return receipt returns the string that confirms the purchase
     */
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

    /**
     * The method is used to return the product key after a successful purchase
     * @param gameId is given to know what game product key to send back
     * @param userName is given to know for which user this product key belongs
     * @return productKey returns a string that contains product key for a game
     */
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

    /**
     * This method is used for a system administrator to add new game
     * @param game Game object
     * @return confirmation that the game is added
     */
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

    /**
     * Adds game to the shopping cart
     * @param userName user name
     * @param game Game object
     * @return confirmation that the game is added
     */
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

    /**
     * Removes game to the shopping cart
     * @param userName user name
     * @param gameId Game object
     * @return new GameCluster object without the removed game
     */
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

    /**
     * Gets the shopping cart
     * @param userName user name
     * @return returns game cluster object
     */
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

    /**
     * Gets users game library
     * @param userName user name
     * @return returns game cluster with purchased games and product keys
     */
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

    /**
     * Administrator can edit game
     * @param game Game object
     * @return Game object that confirms that game is edited
     */
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

    /**
     * Adds game to the wishlist
     * @param userName user name
     * @param game Game object
     * @return confirmation string
     */
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

    /**
     * Deletes game from wishlist
     * @param userName user name
     * @param gameId game id
     * @return returns new GameCluster object without removed game
     */
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

    /**
     * Gets a wishlist
     * @param userName user name
     * @return returns a GameCluster object
     */
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

    /**
     * Gets newly released games
     * @return returns by date sorted GameCluster object
     */
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
