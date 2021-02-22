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
            Console.SetWindowSize(60, 25);
            Console.SetBufferSize(60, 25);

            HorizontalLine upLine = new HorizontalLine(0, 58, 0, '_');
            HorizontalLine downLine = new HorizontalLine(0, 58, 24, '_');
            VerticalLine leftLine = new VerticalLine(1, 24, 0, '|');
            VerticalLine rightLine = new VerticalLine(1, 24, 58, '|');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();

            Console.ReadLine();
        }
    }
}
