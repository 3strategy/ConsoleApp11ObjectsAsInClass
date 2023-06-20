using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11ObjectsAsInClass
{
    public class Brick
    {
        BrickSprite[] squares = new BrickSprite[4];
        public Brick() { }
        public Brick(BrickSprite[] squares)
        {
            this.squares = squares;
        }
        //relative rows and cols

        public static Brick MakeLine() 
        {
            Brick b = new Brick();
            b.squares[0] = new BrickSprite(-2, 0);
            b.squares[1] = new BrickSprite(-1, 0);
            b.squares[2] = new BrickSprite(0, 0);
            b.squares[3] = new BrickSprite(1, 0);
            return b;
        }
        static Random rand = new Random();
        public static Brick MakeBrick() => MakeBrick(rand.Next(6)); 
        private static Brick MakeBrick(int i) 
        {
            Brick b = new Brick();
            //plus basic shape
            b.squares[0] = new BrickSprite(0, -1);
            b.squares[1] = new BrickSprite(-1, 0);
            b.squares[2] = new BrickSprite(0, 0);
            b.squares[3] = new BrickSprite(1, 0);
            //simple one square variations:
            if (i == 1) //line
                b.squares[0] = new BrickSprite(-2, 0);
            else if(i== 2) //right angle
                b.squares[0] = new BrickSprite(1, 1);
            else if (i== 3) //left angle
                b.squares[0] = new BrickSprite(-1, 1);
            else if (i == 4) //right snake
            {
                b.squares[1] = new BrickSprite(-1, -1);
                b.squares[3] = new BrickSprite(1, 0);
            }
            else if (i == 5) //left snake
            {
                b.squares[1] = new BrickSprite(1, -1);
                b.squares[3] = new BrickSprite(-1, 0);
            }

            return b;
        }
        public void Move()
        {
            foreach (var b in squares)
                b.Move();
        }
        public void RotateRight()
        {
            foreach (var b in squares)
                b.RotateRight();
        }

        public void RotateLeft()
        {
            foreach (var b in squares)
                b.RotateLeft();
        }

    }
}
