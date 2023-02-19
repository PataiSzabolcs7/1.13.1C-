using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "egyik"; // definináljuk a változot string tipusá
            string b = "másik"; // definináljuk a változot string tipusá

            int x = String.Compare(a, b); // össze hasonlítjuk őket és az x-et számként definináljuk

            if (x == 0) // ha x = 0-val akkor :
                { Console.WriteLine("A két string egyenlő"); }
            else if(x < 0) // ha x < 0 akkor :
                { Console.WriteLine("Az 'a' a kisebb"); }
            else // ha x > 0  akkor :
                { Console.WriteLine("A 'b' a kisebb"); }

            Console.ReadKey();
        }
    }
}
