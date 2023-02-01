using System.Xml.Linq;

namespace ConsoleApp11ObjectsAsInClass
{
  public class Program
  {
    static int speed = 1000;
    static Sprite player = new Sprite(5, 5, ConsoleKey.RightArrow,
      ConsoleKey.LeftArrow, ConsoleKey.UpArrow, ConsoleKey.DownArrow);
    static Sprite player2 = new Sprite(9, 9, ConsoleKey.D,
      ConsoleKey.A, ConsoleKey.W, ConsoleKey.S);
    static void Main(string[] args)
    {
      while (true)
      {
        while (!Console.KeyAvailable) // לולאת המשחק רצה כל עוד לא נלחץ מקש
        {
          player.Move();
          player2.Move();
          Thread.Sleep(speed);
        }
        // כל מה שכאן קורה לאחר שנלחץ מקש
        var key = Console.ReadKey(true).Key; //key press handling
        if (key == ConsoleKey.Escape)
          break; //exit game
        else
          HandleKey(key);
        // ובסיום הטיפול חוזר ללולאה האינסופית ונכנס שוב ללולאת המשחק
      }

    }
    private static void HandleKey(ConsoleKey key)
    { // הטיפול ברוב המקשים הוא בהעברת נתוני המקש
      // לעצמים השונים שבמשחק 
      //if (key == ConsoleKey.N)
      //  GameReInit();
      //control game speed.
      if (key == ConsoleKey.Add)
        speed = speed * 8 / 10;
      else if (key == ConsoleKey.Subtract)
        speed = speed * 10 / 8;
      else
      { // היינו מעבירים את המקשים אל כולם sptires אילו היה לנו מערך או רשימת
        //foreach (var player in players)
        //  player.HandleKeys(key);
        player.HandleKeys(key);
        player2.HandleKeys(key);
      }
    }
  }
}