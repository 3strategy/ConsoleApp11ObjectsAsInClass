using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11ObjectsAsInClass
{
    public class Brick
    {
        Sprite[] squares = new Sprite[4];
        public Brick() { }
        public Brick(Sprite[] squares)
        {
            this.squares = squares;
        }
        //relative rows and cols
    }
}
