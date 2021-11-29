package Sockets.Packages;

import Sockets.Models.Game;

import java.io.Serializable;

public class GamePackage implements Serializable
{
  private static final long serialVersionUID = -1969032664524354115L;

  private Game game;
  private String type;

  public GamePackage(Game game, String type)
  {
    this.game = game;
    this.type = type;
  }

  public Game getGame()
  {
    return game;
  }

  public String getType()
  {
    return type;
  }
}
