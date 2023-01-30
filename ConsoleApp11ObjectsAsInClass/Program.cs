using System.Xml.Linq;

namespace ConsoleApp11ObjectsAsInClass
{
  public class Program
  {
    static int speed = 1000;
    static Sprite player = new Sprite(5, 5);
    static void Main(string[] args)
    {
      while (true)
      {
        while (!Console.KeyAvailable)
        {  
          player.Move();
          Thread.Sleep(speed);
        }
        var key = Console.ReadKey(true).Key; //key press handling
        if (key == ConsoleKey.Escape)
          break; //exit game
        else
          HandleKey(key);
      }

    }
    private static void HandleKey(ConsoleKey key)
    {
      //if (key == ConsoleKey.N)
      //  GameReInit();
      //control game speed.
      if (key == ConsoleKey.Add)
        speed = speed * 8 / 10;
      else if (key == ConsoleKey.Subtract)
        speed = speed * 10 / 8;
      else
      {
        //foreach (var player in players)
        //  player.HandleKeys(key);
        player.HandleKeys(key);
      }
    }
  }
}