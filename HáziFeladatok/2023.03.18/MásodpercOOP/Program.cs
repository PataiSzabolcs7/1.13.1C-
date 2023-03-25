using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MásodpercOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, e, f, g;
            Console.WriteLine("Add meg az órát: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a percet: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a másodpercet: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az órát megint: ");
            e = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a percet megint: ");
            f = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a másodpercet megint: ");
            g = int.Parse(Console.ReadLine());
            Másodperc m1 = new Másodperc();
            m1.setA(a);
            m1.setB(b);
            m1.setC(c);
            m1.setD();
            m1.setE(e);
            m1.setF(f);
            m1.setG(g);
            m1.setH();
            m1.setVÉG();
            Console.ReadKey();
        }
    }
}
