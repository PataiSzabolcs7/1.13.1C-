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
            int a;
            Console.WriteLine("Add meg a víz hőmérsékletét:");
            a = int.Parse(Console.ReadLine());
            if (a < 0) 
            {
                Console.WriteLine("A víz szilárd halmazú");
            }
            else if (a > 100) 
            {
                Console.WriteLine("Gőz halmaz állapotú");

            }
            else 
            {
                Console.WriteLine("A víz halmaz állapotú");
            }
        }
    }
}
