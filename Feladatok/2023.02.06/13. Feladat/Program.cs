using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float osszeg;
            Console.WriteLine("Add meg a dinnye átmérőjét");
            float d = float.Parse(Console.ReadLine());
            Console.WriteLine("Hány dinnyét szeretnél?:");
            int db = int.Parse(Console.ReadLine());
            osszeg = (float) ((((d * Math.PI)*2)+60)*db)/100;
            Console.WriteLine("A dinnyinének ennyi méter szalagra lesz szüksége: {0}", osszeg);
            Console.ReadKey();
        }
    }
}
