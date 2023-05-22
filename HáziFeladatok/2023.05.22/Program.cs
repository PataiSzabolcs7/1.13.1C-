using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230522
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hianyzas igazolatlan = new hianyzas();
            Console.WriteLine("*****Köszöntöm a hiányzás kezelőben*****");

            Console.WriteLine("Adja meg a Diák nevét!:");
            igazolatlan.setNev(Console.ReadLine());

            Console.WriteLine("Kérjük írdbe a születési dátumát!");
            igazolatlan.setf(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Addja meg az igazolt hiányzások számát!");
            igazolatlan.setB(int.Parse(Console.ReadLine()));

            Console.WriteLine("Add meg az igazolatlan hiányzások számát!");
            igazolatlan.setA(int.Parse(Console.ReadLine()));

            igazolatlan.setIgazolt();
            igazolatlan.setIgazolatlan();
            igazolatlan.setDolgok();
            igazolatlan.setJutalom();
            igazolatlan.setOsszegzes();


            Console.ReadKey();
        }
    }
}
