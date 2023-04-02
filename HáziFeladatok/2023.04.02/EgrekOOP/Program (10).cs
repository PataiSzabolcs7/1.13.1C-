using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgerekOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double u, v, l, tal, t;
            Egerek e1 = new Egerek();
            Console.WriteLine("Add meg a csatorna hosszát (Méter): ");
            l = double.Parse(Console.ReadLine());
            e1.setL(l);
            Console.WriteLine("Add meg a két egér sebességét (m/s): ");
            v = double.Parse(Console.ReadLine());
            u = double.Parse(Console.ReadLine());
            e1.setV(v);
            e1.setU(u);
            Console.WriteLine("Add meg a futamidőt (másodpercben) ");
            t = double.Parse(Console.ReadLine());
            e1.setT(t);
            e1.setTAL();
            Console.WriteLine("A két egér ennyiszer találkozott: {0}", Convert.ToInt32(e1.getTAL()));
            Console.ReadKey();
        }
    }
}
