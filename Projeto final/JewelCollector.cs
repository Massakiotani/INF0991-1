//Alteração realizada por Willian Massaki Otani
//Outra alteração realizada por Willian Massaki Otani

using System;
using System.Collections.Generic;

public class JewelCollector {

  public static void Main() {
    ///////////////////////teste
    string[,] tabuleiro_teste = { 
    {"--","--","--","--","--","--","--","--","--","--"},
    {"--","--","--","--","--","--","--","--","--","--"},
    {"--","--","--","--","--","--","--","--","--","--"},
    {"--","--","--","--","--","--","--","--","--","--"},
    {"--","--","--","--","--","--","--","--","--","--"},
    {"--","--","--","--","--","--","--","--","--","--"},
    {"--","--","--","--","--","--","--","--","--","--"},
    {"--","--","--","--","--","--","--","--","--","--"},
    {"--","--","--","--","--","--","--","--","--","--"},
    {"--","--","--","--","--","--","--","--","--","--"}
    };
    
    
    //////////////////////teste
    Map stage = new Map(10);
    Robot player = new Robot(0,0, stage);
    bool running = true;
    stage.AddElement("##", 5, 5);
    stage.AddElement("##", 5, 4);
    stage.AddElement("##", 5, 3);
    stage.AddElement("##", 5, 2);

    stage.AddElement("$$", 7, 5);
    stage.AddElement("$$", 7, 4);
    stage.AddElement("$$", 7, 3);
    stage.AddElement("$$", 7, 2);

    stage.AddElement("JR", 2,3);
    stage.AddElement("JB", 3,2);
    stage.AddElement("JG", 4,4);
    stage.AddElement("JR", 1,1);
    stage.AddElement("JB", 2,2);
    stage.AddElement("JG", 1,4);
    stage.AddElement("JR", 6,3);
    stage.AddElement("JB", 7,8);
    stage.AddElement("JG", 1,8);
    
    do {
        //////////////////teste
        stage.Draw(player);
        player.JewelQuantity();
        player.JewelTotalValue();
        /////////////////////test
        Console.WriteLine("Enter the command: ");
        ConsoleKeyInfo command = Console.ReadKey();

        if (command.Key == ConsoleKey.Q) {
            running = false;
        } else if (command.Key == ConsoleKey.W) {
            player.Move("North");
        } else if (command.Key == ConsoleKey.A) {
            player.Move("West");
        } else if (command.Key == ConsoleKey.S) {
            player.Move("South");
        } else if (command.Key == ConsoleKey.D) {
            player.Move("East");
        } else if (command.Key == ConsoleKey.G) {
            player.Pick();
        }
        Console.WriteLine("player position: {0},{1}", player.X, player.Y);
    } while (running);
  }
}   