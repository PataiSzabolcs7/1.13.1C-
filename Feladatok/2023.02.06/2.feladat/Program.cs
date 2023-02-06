using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Adj meg egy számot: ");
            x = int.Parse(Console.ReadLine());
            if (x % 3 == 0) 
            {
                Console.WriteLine("A Szám osztható 3-mal");
            }
            if (x % 4 == 0) 
            {
                Console.WriteLine("A szám osztható 4-el");
            }
            if (x % 9== 0) 
            {
                Console.WriteLine("A szám osztható 9-el");
            }
            Console.ReadKey();
        }   
    }
}
