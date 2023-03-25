using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugárOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, szög;
            Sugár s1 = new Sugár();
            Console.WriteLine("Add meg hány szögű a szabályos alakzatod (3,4,5,6): ");
            szög = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az oldal hosszát (cm): ");
            a = double.Parse(Console.ReadLine());
            s1.setSZÖG(szög);
            s1.setA(a);
            s1.setÁTLÓ();
            s1.setRs();
            s1.setRa();
            Console.ReadKey();
        }
    }
}
