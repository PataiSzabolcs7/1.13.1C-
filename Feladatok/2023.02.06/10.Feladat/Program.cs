using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mennyi igazolatlan órája van a diáknak:");
            int c = int.Parse(Console.ReadLine());
            if (c < 10) 
            {
                if (c <= 2)
                {
                    Console.WriteLine("A tanuló magatartása:Kitűnő (5)");
                }
                else if (c >= 2 && c <= 4)
                {
                    Console.WriteLine("A tanuló magatartása:Jó (4)");
                }
                else if (c >= 4 && c <= 6)
                {
                    Console.WriteLine("A tanuló magatartása:Közepes (3)");
                }
                else if (c >= 6 && c <= 10) 
                {
                    Console.WriteLine("A tanuló magatartása:Eléséges (2)");
                }
                Console.ReadKey();
            }
            else 
            {
                Console.WriteLine("Adja meg a tanuló születési dátumát:(éééé/hh/nn)");
                string s = Console.ReadLine();
                Console.WriteLine(s);
                if (c > 10 && c <= 20)    
                {
                    Console.WriteLine("Figyelmeztetés! Igazolatlan órák száma: {0}", c);
                }
                else if (20 >= 10 && c <= 30) 
                {
                    Console.WriteLine("Osztályfönőki figyelmeztetés!  Igazolatlan órák száma: {0}", c); 
                }
                else if (30 >= c && c <= 40) 
                {
                    Console.WriteLine("Igazgatói megrovás!  Igazolatlan órák száma: {0}", c);
                }
                else if (40 >= c && c <= 50) 
                {
                    Console.WriteLine("Felfüggesztés!  Igazolatlan órák száma: {0}", c );
                }
                Console.ReadKey(); 
            }
        }
    }
}
