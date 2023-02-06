using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allatok
{
    internal class Program
    {
        enum Animal { Macska = 3,Kutya = 5,Tigris,Egér };
        static void Main(string[] args)
        {
            Animal a = Animal.Tigris;
            Animal b = Animal.Egér;
            
            // Értéktípusú változok nulla értéke
            int c = 0;
            string s = "";

            // Nullázható érték tipusú változó deklarálása
            int? x = null;

           if ( a!=b )
            {
                Console.WriteLine("Az Egér nem Tigris");
               
            }
            Console.WriteLine("Macska indexe:{0}", (int)Animal.Macska);
            Console.WriteLine("Kutya indexe:{0}", (int)Animal.Kutya);
            Console.WriteLine("Egér indexe:{0}", (int)Animal.Egér);
            Console.ReadKey();
        }
         
    }
}
