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

            /*List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);
            int first = numList[0];
            int second = numList[1];
            int third = numList[2];
            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }
            numList.RemoveAt(0); */

            HorizontalLine line = new HorizontalLine(5, 10, 8, '_');
            line.Draw();

            Console.ReadLine();
        }
    }
}
