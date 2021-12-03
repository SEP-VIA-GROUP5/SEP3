package Sockets.Packages;

import Sockets.Models.Game;

import java.util.ArrayList;

public class CartPackage {
    String userName;
    int gameId;
    ArrayList<Game> games;

    public CartPackage(String type, String userName, int gameId, ArrayList<Game> games){
        this.gameId = gameId;
        this.userName = userName;
        this.games = games;
    }
    public CartPackage(String type, String userName, int gameId){
        this.gameId = gameId;
        this.userName = userName;
        //this.games = games;
    }

    public CartPackage(String type, String userName){
        //this.gameId = gameId;
        this.userName = userName;
        //this.games = games;
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
}
