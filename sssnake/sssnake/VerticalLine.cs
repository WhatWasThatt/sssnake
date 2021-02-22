using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sssnake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yLeft, int yRight, int x, char symbol)
        {
            pList = new List<Point>();
            for (int y = yLeft; y <= yRight; ++y)
            {
                Point p = new Point(x, y, symbol);
                pList.Add(p);
            }
        }
    }
}
