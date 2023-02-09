using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, gyök;
            float gyök2, vég,vég2;
            Console.WriteLine("Add meg az A-t: ");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az B-t: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az C-t: ");
            c = int.Parse(Console.ReadLine());
            gyök =(int)(Math.Pow(b, 2) - (4 * a * c));
            if (gyök < 0) 
            {
                gyök = gyök - gyök -gyök;
            }
            gyök2 = (float)(Math.Sqrt(gyök));
            vég = (-b +gyök2) / (2 * a);
            vég2= (-b - gyök2) / (2 * a);
            Console.WriteLine("x1: {0}", vég);
            Console.WriteLine("x2: {0}", vég2);
            if (vég < 0 && vég2 < 0) 
            {
                Console.WriteLine("Nincs valós gyöke");
            }
            else if (vég > 0 && vég2 > 0)
            {
                Console.WriteLine("2 valós gyöke van");
            }
            else
            {
                Console.WriteLine("1 valós gyöke van");
            }
            Console.ReadKey();
        }
    }
}
