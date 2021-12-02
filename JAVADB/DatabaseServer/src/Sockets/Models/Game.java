package Sockets.Models;

import java.io.Serializable;

public class Game implements Serializable
{
  private static final long serialVersionUID = 3246587559242606068L;
  private int gameId;
  private String gameName;
  private double price;
  private String description;
  private String specifications;
  private int IGNRating;
  private String ESRBRating;
  private  String photoURL;
  private String releaseDate;
  private GameKey gameKey;

  public Game()
  {

  }

  public Game(int gameId, String gameName, double price, String description, String specifications, int IGNRating, String ESRBRating, String photoURL, String releaseDate)
  {
    this.gameId = gameId;
    this.gameName = gameName;
    this.price = price;
    this.description = description;
    this.specifications = specifications;
    this.IGNRating = IGNRating;
    this.ESRBRating = ESRBRating;
    this.photoURL = photoURL;
    this.releaseDate = releaseDate;
  }

  public Game(int gameId, String gameName, double price, String description, String specifications, int IGNRating, String ESRBRating, String photoURL, String releaseDate, String gameKey)
  {
    this.gameId = gameId;
    this.gameName = gameName;
    this.price = price;
    this.description = description;
    this.specifications = specifications;
    this.IGNRating = IGNRating;
    this.ESRBRating = ESRBRating;
    this.photoURL = photoURL;
    this.releaseDate = releaseDate;
    this.gameKey = new GameKey(gameKey);
  }

  public Game(String gameName)
  {
    this.gameName = gameName;
  }

  public Game(int gameId)
  {
    this.gameId = gameId;
  }

  public int getGameId()
  {
    return gameId;
  }

  public String getGameName()
  {
    return gameName;
  }

  public double getPrice()
  {
    return price;
  }

  public String getDescription()
  {
    return description;
  }

  public String getSpecifications()
  {
    return specifications;
  }

  public int getIGNRating()
  {
    return IGNRating;
  }

  public String getESRBRating()
  {
    return ESRBRating;
  }

  public String getPhotoURL()
  {
    return photoURL;
  }

  public String getReleaseDate()
  {
    return releaseDate;
  }

  public GameKey getGameKey()
  {
    return gameKey;
  }

  public void setDescription(String description)
  {
    this.description = description;
  }

  public void setPrice(double price)
  {
    this.price = price;
  }

  public void setESRBRating(String ESRBRating)
  {
    this.ESRBRating = ESRBRating;
  }

  public void setGameId(int gameId)
  {
    this.gameId = gameId;
  }

  public void setGameName(String gameName)
  {
    this.gameName = gameName;
  }

  public void setGameKey(GameKey gameKey)
  {
    this.gameKey = gameKey;
  }

  public void setIGNRating(int IGNRating)
  {
    this.IGNRating = IGNRating;
  }

  public void setPhotoURL(String photoURL)
  {
    this.photoURL = photoURL;
  }

  public void setReleaseDate(String releaseDate)
  {
    this.releaseDate = releaseDate;
  }

  public void setSpecifications(String specifications)
  {
    this.specifications = specifications;
  }

  @Override public String toString()
  {
    return "Game{" + "gameId=" + gameId + ", gameName='" + gameName + '\''
        + ", price=" + price + ", description='" + description + '\''
        + ", specifications='" + specifications + '\'' + ", IGNRating="
        + IGNRating + ", ESRBRating='" + ESRBRating + '\'' + ", photoURL='"
        + photoURL + '\'' + ", releaseDate='" + releaseDate + '\''
        + ", gameKey='" + gameKey + '\'' + '}';
  }
}
