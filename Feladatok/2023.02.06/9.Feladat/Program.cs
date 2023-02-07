using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a,b,c;
            Console.WriteLine("Ad meg a C2 és az O2");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = (a / b);
            Console.WriteLine(c);
            if (0.8 < c) 
            {
                Console.WriteLine("Szénhidrátokból nyeri");
            }
            else if (0.8 > c) 
            {
                Console.WriteLine("Zsírból nyeri");
            }
            else
                Console.WriteLine("Tökéletes");
            Console.ReadKey();
        }  
    }
}
