using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halmazállapot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Add meg a víz hőmérsékletét: ");
            a=int.Parse(Console.ReadLine());
            Halmazállapot h1 = new Halmazállapot();
            h1.setHalmaz(a);
            Console.ReadKey();
        }
    }
}
