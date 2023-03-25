using GyökOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MásodfokúOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, gyök;
            double gyök2, vég, vég2;
            Másodfokú m1 = new Másodfokú();
            Console.WriteLine("Add meg az A-t: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az B-t: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az C-t: ");
            c = int.Parse(Console.ReadLine());
            m1.setA(a);
            m1.setB(b);
            m1.setC(c);
            m1.setGYÖK();
            m1.setGYÖK2();
            m1.setVÉG();
            m1.setVÉG2();
            Console.ReadKey();
        }
    }
}
