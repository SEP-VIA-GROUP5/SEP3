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
    gameService.editGame(4, "Biomutant", 29.99, "https://s2.gaming-cdn.com/images/products/2245/271x377/spil-steam-biomutant-cover.jpg",
        "Everyone", 6, "BIOMUTANT:registered: is an open-world, post-apocalyptic Kung-Fu fable RPG, with a unique martial arts styled combat system allowing you to mix melee, shooting and mutant ability action.\n"
            + "\n"
            + "A plague is ruining the land and the Tree-of-Life is bleeding death from its roots. The Tribes stand divided. Explore a world in turmoil and define its fate – will you be its saviour or lead it to an even darker destiny?", "MINIMUM:\n"
            + "Requires a 64-bit processor and operating system\n"
            + "OS: Windows 7/8.1/10 (64 bit)\n"
            + "Processor: AMD FX-8350 or Intel Core i5-4690K or newer running at 3.5 GHz or higher\n"
            + "Memory: 8 GB RAM\n"
            + "Graphics: 4 GB Direct3D 11 capable video card - GeForce GTX 960 or Radeon R9 380\n"
            + "DirectX: Version 11\n" + "Storage: 25 GB available space\n"
            + "Sound Card: Integrated or dedicated DirectX 9 compatible soundcard\n"
            + "Additional Notes: Keyboard, mouse and an internet connection for Steam.",
        "2021-05-25");
    System.out.println(gameService.getGame("Biomutant"));
  }
}
