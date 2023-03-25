using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pontok_távolsága
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Adj meg 4 számot: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            Pontok_távolsága P1 = new Pontok_távolsága();
            P1.setPont1(a);
            P1.setPont2(b);
            P1.setPont3(c);
            P1.setPont4(d);
            P1.setKeplet();
            Console.WriteLine("A koordináta: {0}", P1.getKeplet());

            Console.ReadKey();
        }
    }
}