using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n, sz;

            Tort t1= new Tort();
            Console.WriteLine("Add meg a nevezőt: ");
            n = double.Parse(Console.ReadLine());
            t1.setN(n);
            Console.WriteLine("Add meg a számlálót: ");
            sz = double.Parse(Console.ReadLine());
            t1.setSZ(sz);
            t1.setC();

            Console.WriteLine("Az eredmény: {0}", Math.Round(t1.getC(), 4));
            Console.ReadKey();
        }
    }
}
