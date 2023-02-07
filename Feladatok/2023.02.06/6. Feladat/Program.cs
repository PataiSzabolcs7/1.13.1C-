using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Adj meg 4 számot!:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(Math.Pow(b - a, 2) + Math.Pow(d-c,2)));
            Console.ReadKey();
        }
    }
}
