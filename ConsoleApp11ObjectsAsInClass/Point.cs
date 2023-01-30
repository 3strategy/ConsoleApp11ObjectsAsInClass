using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11ObjectsAsInClass
{
  public class Point
  {
    protected int x, y;
    private string name;
    private static char currentLetter = 'A';

    public Point(int x, int y)
    {
      this.x = x;
      this.y = y;
      name = "" + currentLetter;
      currentLetter++;
    }
    public Point(int xCoor, int y, string pointName)
    {
      x = xCoor;
      name = pointName;
      this.y = y;
    }

    public int GetX()
    {
      return x;
    }
    public int GetY() => y;

    public void SetX(int value)
    {
      x = value;
    }
    public void SetY(int value)
    {
      y = value;
    }
    public void SetName(string value)
    {
      name = value;
    }
    public override string ToString() => $"{name}({x},{y})";

    public int Quarter()
    {
      if (x > 0 && y > 0)
        return 1;
      else if (x < 0 && y > 0)
        return 2;
      else if (y < 0 && x < 0)
        return 3;
      else if (x > 0 && y < 0)
        return 4;
      return 0;
    }
    public double Distance(Point other)
    {
      return Math.Sqrt(Math.Pow(x - other.x, 2) + Math.Pow(y - other.y, 2));

    }

    public void Draw()
    {
      Console.SetCursorPosition(x + 20, -y + 20);
      Console.WriteLine(this);
    }

  }
}
