using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex("^[1-9][0-9]*");
            string s1 = "012345";
            string s2 = "112345";
            string s3 = "2";

            Console.WriteLine("{0} : {1}", s1, (pattern.IsMatch(s1) ?
                "természetes szám" : "nem természetes szám"));

            Console.WriteLine("{0} : {1}", s2, (pattern.IsMatch(s2) ?
                "természetes szám" : "nem természetes szám"));

            Console.WriteLine("{0} : {1}", s3, (pattern.IsMatch(s3) ?
                "természetes szám" : "nem természetes szám"));

            Console.ReadKey();
        }
    }
}
