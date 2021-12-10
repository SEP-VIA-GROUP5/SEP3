package Sockets.Models;

import java.io.Serializable;
/**
 * Used to store Game product Keys
 */
public class GameKey implements Serializable {
    private String GameKey;
    private static final long serialVersionUID = 7329218667231354436L;

    public GameKey(String GameKey)
    {
        this.GameKey = GameKey;
    }

    public String getGameKey() {
        return GameKey;
    }

    public void setGameKey(String gameKey) {
        GameKey = gameKey;
    }
}
