using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsempeOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Csempe cs1 =new Csempe();
            Console.WriteLine("Add meg a szoba szélességét: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a szoba magasságát: ");
            b = float.Parse(Console.ReadLine());
            cs1.setA(a);
            cs1.setB(b);
            cs1.setT();
            cs1.setCS();
            cs1.setTT();
            Console.WriteLine("{0} csempére lesz szükség!", cs1.getTT());
            Console.ReadKey();
        }
    }
}
