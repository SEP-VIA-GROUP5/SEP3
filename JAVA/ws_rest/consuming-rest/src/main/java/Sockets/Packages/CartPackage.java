package Sockets.Packages;

import Sockets.Models.Game;

import java.io.Serializable;
import java.util.ArrayList;

public class CartPackage implements Serializable
{
    private static final long serialVersionUID = 8045768769829378877L;
    private String userName;
    private int gameId;
    private String type;
    private ArrayList<Game> games;

    public CartPackage(String type, String userName, int gameId, ArrayList<Game> games){
        this.gameId = gameId;
        this.userName = userName;
        this.games = games;
        this.type = type;
    }
    public CartPackage(String type, String userName, int gameId){
        this.gameId = gameId;
        this.userName = userName;
        this.type = type;
        this.games = new ArrayList<>();
    }

    public CartPackage(String type, String userName){
        this.userName = userName;
        this.type = type;
        this.gameId = 0;
        this.games = new ArrayList<>();
    }

    public CartPackage(ArrayList<Game> games)
    {
        this.games = games;
        this.gameId = 0;
        this.userName = null;
        this.type = null;
    }

    public String getUserName() {
        return userName;
    }

    public void setUserName(String userName) {
        this.userName = userName;
    }

    public int getGameId() {
        return gameId;
    }

    public void setGameId(int gameId) {
        this.gameId = gameId;
    }

    public ArrayList<Game> getGames() {
        return games;
    }

    public void setGames(ArrayList<Game> games) {
        this.games = games;
    }

    public String getType()
    {
        return type;
    }
}
