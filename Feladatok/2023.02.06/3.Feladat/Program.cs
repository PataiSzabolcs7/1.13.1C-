using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Add meg a hőmérsékletet: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("celsius vagy fahrenheit (C/F): ");
            if (Console.ReadKey(true).KeyChar == 'C')
            if (Console.ReadKey(true).KeyChar == 'C')

                    Console.WriteLine("Át akarod váltani fahrenheitba? (i/n) ");
            if (Console.ReadKey(true).KeyChar == 'i')
            Console.WriteLine("Ennyi fahrenheitban: {0},", a * 1.8 + 32);
            Console.ReadKey();
        }
      
    }
}

