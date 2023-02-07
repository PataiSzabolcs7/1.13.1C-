using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Hány pontott szereztél?:");
            a = int.Parse(Console.ReadLine());
            if (a < 50)
            {
                Console.WriteLine("A jegyed: 1");
            }
            else if (51 <= a && a < 65)
            {
                Console.WriteLine("A jegyed: 2");
            }
            else if (66 <= a && a < 80)
            {
                Console.WriteLine("A jegyed: 3");
            }
            else if (81 <= a && a < 90)
            {
                Console.WriteLine("A jegyed: 4");
            }
            else if (91 <= a && a < 100)
            {
                Console.WriteLine("A jegyed: 5");
            }
            else
            {
                Console.WriteLine("Hibás adat!");
            }
            Console.ReadKey();
        }
    }
}
