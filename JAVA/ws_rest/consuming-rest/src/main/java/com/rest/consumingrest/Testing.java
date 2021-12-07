package com.rest.consumingrest;

import Services.GameService;
import Services.IGameService;

import java.io.IOException;

public class Testing
{
  public static void main(String[] args)
      throws IOException, ClassNotFoundException
  {
    IGameService gameService = new GameService();
    System.out.println(gameService.getWishlist("admin").getGameStack().toString());
  }
}
