using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11ObjectsAsInClass
{
  public class Sprite : Point  //ירושה מהמחלקה האם
  {
    private int dX;
    private int dY;

    public Sprite(int x, int y) : base(x, y) // חייבים בנאי אחד לפחות שמקבל פרמטרים 
    { // כמו הבנאי של המחלקה האם
      // השרשור :base(x,y)
      // שולח את הפרמטרים שהתקבלו לבנאי של המחלקה האם
    }
    public void Draw()
    {
      Console.SetCursorPosition(x, y);
      Console.WriteLine("X");
    }

    public void HandleKeys(ConsoleKey key)
    {
      if (key == ConsoleKey.RightArrow)
        dX++;
      else if (key == ConsoleKey.LeftArrow)
        dX--;
      else if (key == ConsoleKey.DownArrow)
        dY++;
      else if (key == ConsoleKey.UpArrow) dY--;

    }

    public void Erase()
    {
      Console.ForegroundColor = ConsoleColor.Black;
      Draw();
      Console.ForegroundColor = ConsoleColor.White;
    }
    public void Move()
    {
      Erase();
      x += dX;
      y += dY;
      Draw();
    }
  }
}
