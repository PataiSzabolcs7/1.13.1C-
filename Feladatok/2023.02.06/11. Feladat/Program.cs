using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            Console.WriteLine("Adj meg két számot:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Random random = new Random();
            c = random.Next(a, b);     
            for (int i = 0; i < 3; i++) 
            {
                c = random.Next(a, b);
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
