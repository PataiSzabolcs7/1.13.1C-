using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int islandCount, maxIslandLength, i, tmp;
            Random r = new Random();
            int[] data = new int[50];
            for (i = 0; i < 50; ++i)
            {
                data[i] = r.Next(2);
                Console.WriteLine(data[i]);
            }

            islandCount = 0;
            maxIslandLength = 0;
            i = 0;

            while (i < 50)
            {
                if (data[i] == '1')
                {
                    ++islandCount;
                    tmp = 0;
                    while (i < 50 && data[i] == '1')
                    {
                        ++i; ++tmp;
                    }
                    if (tmp > maxIslandLength)
                    {
                        maxIslandLength = tmp;
                    }

                }
                else
                {
                    ++i;
                }
            }
            Console.WriteLine("A leghosszabb egybefüggő szárazföld hossza: {0}", maxIslandLength);
            Console.WriteLine("Szigetek száma: {0}", islandCount);
            Console.ReadKey();
        }
    }
}
