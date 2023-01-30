using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11ObjectsAsInClass
{
  public class Sprite : Point
  {
    public Sprite(int x, int y) : base(x, y)
    {

    }
    public void Draw()
    {
      Console.SetCursorPosition(x, y);
      Console.WriteLine("X");
    }

  }
}
