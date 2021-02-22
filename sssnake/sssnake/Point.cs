using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sssnake
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;

        public Point()
        {
        }

        public Point(int _x, int _y, char _symbol)
        {
            x = _x;
            y = _y;
            symbol = _symbol;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symbol = p.symbol;
        }

        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                x = x + offset;
            }
            else if (direction == Direction.DOWN)
            {
                x = x - offset;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        public void Clear()
        {
            symbol = ' ';
            Draw();
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + symbol;
        }
    }
}
