using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "smallstring"; // string típusu változot hoztunk létre és adtunk neki értéket
            char[] chs = new char[] { 's', 'g' }; // új listátt hozunk létre char típusba és megtöltjük

            Console.WriteLine(s.Replace('s', 'l')); // lmallltring
            Console.WriteLine(s.Trim(chs)); // mallstrin
            Console.WriteLine(s.Insert(0, "one")); // onesmallstring
            Console.WriteLine(s.Remove(0, 2)); // allstring
            Console.WriteLine(s.Substring(0, 3)); // sma
            Console.WriteLine(s.ToUpper()); // SMALLSTRING
            Console.WriteLine(s.ToLower()); // smallstring

            Console.ReadLine();
        }
    }
}
