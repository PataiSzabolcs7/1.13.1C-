using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnyeOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Dinnye átmérő számítás***");
            Dinnye h1 = new Dinnye();
            Console.WriteLine("Add meg az átmérőt (CM) :");
            h1.setD(int.Parse(Console.ReadLine()));
            Console.WriteLine("Add meg a darabszámot:");
            h1.setDB(int.Parse(Console.ReadLine()));
            h1.setOsszeg();
            Console.WriteLine("A Dinnyékhez ennyi {0} méter szalagra lesz szükséged", h1.getOsszeg());
            Console.ReadKey();
        }
    }
}
