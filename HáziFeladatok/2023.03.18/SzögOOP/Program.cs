using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzögOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, szög;
            Szög sz1 = new Szög();
            Console.WriteLine("Add meg hány szögű a szabályos alakzatod (3,4,5,6): ");
            szög = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az oldal hosszát (cm): ");
            a = double.Parse(Console.ReadLine());
            sz1.setA(a);
            sz1.setSZÖG(szög);
            sz1.setÁTLÓ();
            Console.ReadKey();
        }
    }
}
