using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Átlaghő
{
    internal class Program
    {
        static void Main(string[] args)
        {
            atlaghoszamitas h2o = new atlaghoszamitas();
            h2o.randombehozas();
            h2o.szamitas();
            h2o.honapszamitas();

            Console.ReadKey();
        }
    }
}