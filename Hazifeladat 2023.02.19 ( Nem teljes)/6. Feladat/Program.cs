using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(50); // StringBuilder  helyet  foglal  ötven  karakter  számára

            for (char ch = 'a'; ch <= 'z'; ++ch) // egyszerű for cikulus ami ki írja a-tól z-ig a betűket
            { sb.Append(ch); }

            Console.WriteLine(sb);

            Console.ReadKey();
        }
    }
}
