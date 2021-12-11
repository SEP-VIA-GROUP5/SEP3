package Services;

import Sockets.Models.Game;
import Sockets.Models.GameCluster;
import Sockets.Models.GameKey;
import Sockets.Models.User;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.function.Executable;

import java.io.IOException;
import java.security.InvalidParameterException;
import java.util.ArrayList;

import static org.junit.jupiter.api.Assertions.*;

class IGameServiceTest {

    private IGameService gameService;

    @BeforeEach
    void setUp() throws IOException {
        gameService = new GameService();

        System.out.println("---> Set up interface");
    }

    @AfterEach
    void tearDown() {
        System.out.println("<--- Test completed");
    }

    @Test
    void getGame() throws IOException, ClassNotFoundException {
        Game game = new Game(-1,"CS:GO",23.00, "Counter Strike: Global Offensive", "Pc does not matter", 8, "Mature", "csgo.photo", "2021-12-11");
        gameService.addGame(game);
        Game gameReturned = gameService.getGame("CS:GO");
        assertEquals(game.getGameName(), gameReturned.getGameName());
        assertEquals(game.getPrice(), gameReturned.getPrice());
        assertEquals(game.getDescription(), gameReturned.getDescription());
        assertEquals(game.getSpecifications(), gameReturned.getSpecifications());
        assertEquals(game.getIGNRating(), gameReturned.getIGNRating());
        assertEquals(game.getESRBRating(), gameReturned.getESRBRating());
        assertEquals(game.getPhotoURL(), gameReturned.getPhotoURL());
        assertEquals(game.getReleaseDate(), gameReturned.getReleaseDate());
    }

    @Test
    void getGameCluster() throws IOException, ClassNotFoundException {
        //this method has to get just 5 games per list.
        GameCluster gameCluster = gameService.getGameCluster(0);
        assertEquals(5, gameCluster.getGameStack().size());
    }

    @Test
    void getProductKey() throws IOException, ClassNotFoundException {
        GameKey gameKey = gameService.getProductKey(1,"Testing");
        assertNotNull(gameKey.getGameKey());
    }

    @Test
    void addGame() throws IOException, ClassNotFoundException {
        Game game = new Game(-1,"CS:GO",23.00, "Counter Strike: Global Offensive", "Pc does not matter", 8, "Mature", "csgo.photo", "2021-12-11");
        gameService.addGame(game);
        Game gameReturned = gameService.getGame("CS:GO");
        assertEquals(game.getGameName(), gameReturned.getGameName());
        assertNotNull(game.getGameName());
        assertEquals(game.getPrice(), gameReturned.getPrice());
        assertEquals(game.getDescription(), gameReturned.getDescription());
        assertNotNull(game.getDescription());
        assertEquals(game.getSpecifications(), gameReturned.getSpecifications());
        assertNotNull(game.getSpecifications());
        assertEquals(game.getIGNRating(), gameReturned.getIGNRating());
        assertEquals(game.getESRBRating(), gameReturned.getESRBRating());
        assertNotNull(game.getESRBRating());
        assertEquals(game.getPhotoURL(), gameReturned.getPhotoURL());
        assertEquals(game.getReleaseDate(), gameReturned.getReleaseDate());
        assertNotNull(game.getReleaseDate());
    }

    @Test
    void getSearch() throws IOException, ClassNotFoundException {
        GameCluster gameCluster = gameService.getSearch("no game with this name");
        assertNotNull(gameCluster);
        gameCluster = gameService.getSearch("GO");
        assertNotNull(gameCluster);
    }

    @Test
    void addGameToShoppingCart() throws IOException, ClassNotFoundException {
        Game game = gameService.getGame("CS:GO");
        gameService.addGameToShoppingCart("Testing",5);
        GameCluster gameCluster = gameService.getShoppingCart("Testing");
        assertNotNull(gameCluster);
    }

    @Test
    void removeGameFromShoppingCart() throws IOException, ClassNotFoundException {
        assertDoesNotThrow(() -> gameService.removeGameFromShoppingCart("Testing",132114), "Don't throw any exception if gameid is not found");
    }

    @Test
    void getShoppingCart() throws IOException, ClassNotFoundException {
        GameCluster gameCluster = gameService.getShoppingCart("Testing");
        assertNotNull(gameCluster);
    }

    @Test
    void getLibrary() throws IOException, ClassNotFoundException {
        GameCluster gameCluster = gameService.getLibrary("Testing");
        assertNotNull(gameCluster);
        for(Game game : gameCluster.getGameStack())
        {
            assertNotNull(game.getGameKey());
        }
    }

    @Test
    void editGame() {
        Game game = new Game(7,"no name",23.00, "Counter Strike: Global Offensive", "Pc does not matter", 8, "Mature", "csgo.photo", "2021-12-11");
        assertDoesNotThrow(() -> gameService.editGame(game), "Don't throw any exception if game is not found");
    }

    @Test
    void sortByDate() throws IOException, ClassNotFoundException {
        GameCluster gameCluster = gameService.sortByDate();
        assertNotNull(gameCluster,"Game cluster could not be found");
    }

    @Test
    void addGameToWishlist() {
        assertDoesNotThrow(() -> gameService.addGameToWishlist("Testing",12314), "Don't throw any exception if gameid is not found");
    }

    @Test
    void removeGameFromWishlist() {
        assertDoesNotThrow(() -> gameService.removeGameFromWishlist("Testing",12314), "Don't throw any exception if gameid is not found");
    }

    @Test
    void getWishlist() throws IOException, ClassNotFoundException {
        GameCluster gameCluster = gameService.getWishlist("Testing");
        assertNotNull(gameCluster,"Game cluster could not be found");
    }
}