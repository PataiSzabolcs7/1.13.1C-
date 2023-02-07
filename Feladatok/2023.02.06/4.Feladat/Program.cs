using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a,b;
            Console.WriteLine("Add meg a testsúlyodat: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a testmagasságod: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine(a / Math.Pow (b,2));
            bool v = (a / (Math.Pow(b, 2)) <= 26.6);
            if (v) 
            {
                Console.WriteLine("A testtömeg indexed: Átlag");
            }
             else
            {
                Console.WriteLine("A testtömeg indexed: Dagadt");
            }
            Console.ReadKey();  
        }
    }
}
