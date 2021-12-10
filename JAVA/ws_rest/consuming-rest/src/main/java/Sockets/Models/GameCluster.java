package Sockets.Models;

import java.io.Serializable;
import java.util.ArrayList;
/**
 * GameCluster is used to store multiple Game objects as an Arraylist
 */
public class GameCluster implements Serializable {
    private static final long serialVersionUID = 2381019971189522232L;
    public ArrayList<Game> gameStack;

    public GameCluster(){
        gameStack = new ArrayList<>();
    }

    public void addGameToCluster(Game game){
        gameStack.add(game);
    }

    public ArrayList<Game> getGameStack() {
        return gameStack;
    }

    public void setGameStack(ArrayList<Game> gameStack) {
        this.gameStack = gameStack;
    }
}
