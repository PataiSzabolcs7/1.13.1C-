using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "verylonglongstring"; // string típusu változot hoztunk létre és adtunk neki értéket
            char[] chs = new char[] { 'y', 'z', 'o' }; // új listátt hozunk létre char típusba és megtöltjük
            Console.WriteLine(s.IndexOf('r')); // 2
            Console.WriteLine(s.IndexOfAny(chs)); // 3
            Console.WriteLine(s.LastIndexOf('n')); // 16
            Console.WriteLine(s.LastIndexOfAny(chs)); // 9
            Console.WriteLine(s.Contains("long")); // igaz

            Console.ReadLine();
        }
    }
}
