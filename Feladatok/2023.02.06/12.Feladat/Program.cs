using System;

namespace CoinCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy összeget:");
            int a = Convert.ToInt32(Console.ReadLine());

            int c = 0;

            int[] b = new int[] { 10, 20, 50, 100, 200 };

            for (int i = b.Length - 1; i >= 0; i--)
            {
                while ( a >= b[i])
                {
                    a -= b[i];
                    c++;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
                }
            }

            Console.WriteLine("Az összeg a lehető legkevesebb pénzérméből összeállítva: " + c + " db.");
            Console.ReadLine();
        }
    }
}
