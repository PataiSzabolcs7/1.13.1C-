using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f, g, h, vég;
            Console.WriteLine("Add meg az órát: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a percet: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a másodpercet: ");
            c = int.Parse(Console.ReadLine());
            d = a * 3600 + b * 60 + c;
            Console.WriteLine("Add meg az órát megint: ");
            e = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a percet megint: ");
            f = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a másodpercet megint: ");
            g = int.Parse(Console.ReadLine());
            h = e * 3600 + f * 60 + g;
            if (d > h)
            {
                vég = d - h;
                Console.WriteLine(vég);
            }
            else 
            {
                vég = h - d;
                Console.WriteLine(vég);
            }
            Console.ReadKey();
        }
    }
}
