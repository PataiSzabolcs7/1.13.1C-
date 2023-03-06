using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szigetek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Példa
            if (true) 
            { 
                string s = "001111111101110000001111110011110";
                Szigetszamolas sz1 = new Szigetszamolas();
                sz1.setData(s);
                sz1.Szamol();
                Console.WriteLine($"A szigetek száma:{sz1.getIslandCount()}, A leghosszabb sziget hossza:{sz1.getMaxIslandLength()}");
            }
            #endregion
            #region 2.Példa
            if (true)
            {
            string s2 = "11111111111110000000000001111111110000000000111111111110101010101000000000111111111111111111000000000111011111111111111100000001111010000011100011001000";
            Szigetszamolas sz2 = new Szigetszamolas();
            sz2.setData(s2);
            sz2.Szamol();
            Console.WriteLine($"A szigetek száma:{sz2.getIslandCount()}, A leghosszabb sziget hossza:{sz2.getMaxIslandLength()}");
            }
            #endregion
            Console.ReadKey();
        }
    }
}
