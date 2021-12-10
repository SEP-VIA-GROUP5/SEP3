package Sockets.Models;

import java.io.Serializable;
/**
 * Used to store Game product Keys
 */
public class GameKey implements Serializable {
    private String GameKey;
    private String username;
    private static final long serialVersionUID = 7329218667231354436L;

    public GameKey(String GameKey, String username)
    {
        this.GameKey = GameKey;
        this.username = username;
    }

    public GameKey(String GameKey)
    {
        this.GameKey = GameKey;
        this.username = null;
    }

    public String getGameKey() {
        return GameKey;
    }

    public void setGameKey(String gameKey) {
        GameKey = gameKey;
    }
}
