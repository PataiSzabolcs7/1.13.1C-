using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CímletezésOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Címletezés C1 = new Címletezés();
            Console.WriteLine("Add meg az összeget: ");
            a =int.Parse(Console.ReadLine());
            C1.setPÉNZ(a);
            Console.ReadLine();
        }
    }
}
