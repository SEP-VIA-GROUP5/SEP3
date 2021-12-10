package Sockets.Packages;

import Sockets.Models.Game;

import java.io.Serializable;
import java.util.ArrayList;
/**
 * Used to send games as a package
 */
public class GamePackage implements Serializable
{
  private static final long serialVersionUID = -1969032664524354115L;

  private Game game;
  private String type;
  private ArrayList<Game> games;
  private String username;

  public GamePackage(Game game, String type)
  {
    this.game = game;
    this.type = type;
    this.games = null;
  }

  public GamePackage(Game game, String type, String username)
  {
    this.game = game;
    this.type = type;
    this.games = null;
    this.username = username;
  }

  public GamePackage(String type)
  {
    this.game = null;
    this.type = type;
    this.games = null;
  }

  public GamePackage(String type, ArrayList<Game> games)
  {
    this.game = null;
    this.type = type;
    this.games = games;
  }


  public ArrayList<Game> getGames()
  {
    return games;
  }

  public Game getGame()
  {
    return game;
  }

  public String getType()
  {
    return type;
  }

  public String getUsername()
  {
    return username;
  }
}
