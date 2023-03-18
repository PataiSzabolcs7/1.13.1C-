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
            h1.setA(90);
            Console.WriteLine(h1.getA());
            Console.ReadKey();
        }
    }
}
