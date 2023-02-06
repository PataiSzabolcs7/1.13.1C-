using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamologep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x,y;
            char op;

            if (args.Length == 0 ) 
            {
                Console.WriteLine("Az első szám:");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("A második szám:");
                y = int.Parse(Console.ReadLine());

                Console.WriteLine("A művelet(+, -, *, /): ");
                op = Convert.ToChar(Console.Read());
            }else
            {
                if (args.Length != 3)
                {
                    Console.WriteLine("Túl sok/kevés paraméter!");
                    return;
                }
                else
                {
                    x = int.Parse(args[0]);
                    y = int.Parse(args[1]);
                    op = Convert.ToChar(args[2]);
                }

            }
            int result = 0;

            switch (op)
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    result = x / y;
                    break;
            }
            Console.WriteLine("A művelet eredménye: {0}", result);
            Console.ReadKey();
        } 
    }
}
