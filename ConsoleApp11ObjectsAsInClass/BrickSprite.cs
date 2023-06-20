using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11ObjectsAsInClass
{
    public class BrickSprite: Sprite
    {
        public BrickSprite(int x, int y):base(x,y)
        {
            
        }
        private int rrow, rcol;

        private bool alive;
        public bool GetAlive()
        {
            return alive;
        }
        public void SetAlive(bool value)
        {
            alive = value;
        }

        public void RotateRight()
        {
            rcol += 2 - rcol + (2 - rrow);
            rrow += 2 - rrow - (2 - rcol);
        }
        public void RotateLeft()
        {
            rcol += 2 - rcol - (2 - rrow);
            rrow += 2 - rrow + (2 - rcol);
        }
    }
}
