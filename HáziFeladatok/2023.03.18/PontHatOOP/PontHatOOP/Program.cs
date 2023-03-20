using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontHatOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PontHat h1 = new PontHat();
            Console.WriteLine("Addja meg a Pontszámot:");
            int a = int.Parse(Console.ReadLine());
            h1.setA(a);
            Console.WriteLine(h1.getA());
            Console.ReadKey();
        }
    }
}
