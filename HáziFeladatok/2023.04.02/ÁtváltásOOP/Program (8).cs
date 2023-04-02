using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvaltOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b=0, c=1, d=0;
            Atvalt a1 = new Atvalt();
            Console.WriteLine("Adj meg egy bináris számot: ");
            a=int.Parse(Console.ReadLine());
            a1.setB(b);
            a1.setC(c);
            a1.setD(d);
            a1.setA(a);
            Console.WriteLine("A számod decimálisban: {0}", a1.getC()-1);
            Console.ReadKey();
        }
    }
}
