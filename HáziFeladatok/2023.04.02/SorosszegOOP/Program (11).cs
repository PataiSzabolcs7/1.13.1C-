using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorosszegOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n, k;
            Sorosszeg s1 = new Sorosszeg();
            Console.WriteLine("Add meg az N értékét: ");
            n = double.Parse(Console.ReadLine());
            s1.setN(n);
            s1.setK();
            Console.WriteLine("Végeredmény: {0}", s1.getK());
            Console.ReadKey();
        }
    }
}
