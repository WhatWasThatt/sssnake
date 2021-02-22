using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sssnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(6, 7, '&');
            p3.Draw();

            Point p4 = new Point(2, 4, '.');
            p4.Draw();

            Point p5 = new Point(7, 3, '/');
            p5.Draw();

            //List<int> numList = new List<int>();
            //numList.Add(0);
            //numList.Add(1);
            //numList.Add(2);

            //int first = numList[0];
            //int second = numList[1];
            //int third = numList[2];

            //foreach(int i in numList)
            //{
            //    Console.WriteLine(i);
            //}

            //numList.RemoveAt(0);


            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            pList.Add(p5);

            Console.ReadLine();
        }
    }
}
