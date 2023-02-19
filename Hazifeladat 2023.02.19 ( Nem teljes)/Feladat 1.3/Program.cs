using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Átlaghőmérséklet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min, max;

            Random r = new Random();

            min = 40;
            max = -20;
            int[] tomb = new int[360];
            for (int i = 0; i < 360; ++i)
            {
                tomb[i] = r.Next(max, min);
            }
            for (int i = 1; i < 13; ++i)
            {
                for (int j = 1; j < 31; ++j)
                {
                    if (tomb[j] < min)
                    {
                        min = tomb[j];
                    }
                    else if (tomb[j] > max)
                    {
                        max = tomb[j];
                    }
                    Console.WriteLine("{0} hónap {1} napján a hőmérséklet: {2}", i, j, tomb[j]);
                }
            }
            Console.WriteLine("Az év leghidegebb napja: {0}.", min);
            Console.WriteLine("Az év legmelegebb napja: {0}.", max);
            Console.ReadKey();
        }
    }
}
