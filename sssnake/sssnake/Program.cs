using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sssnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 18);
            Console.SetBufferSize(40, 18);

            HorizontalLine upLine = new HorizontalLine(0, 38, 0, '*');
            HorizontalLine downLine = new HorizontalLine(0, 38, 17, '*');
            VerticalLine leftLine = new VerticalLine(1, 17, 0, '*');
            VerticalLine rightLine = new VerticalLine(1, 17, 38, '*');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            Console.CursorVisible = false;

            while (true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(200);
                snake.Move();
            }

            Console.ReadLine();
        }
    }
}
