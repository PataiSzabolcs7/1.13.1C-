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
            const int honapok = 12;
            const int napok = 30;
            double[,] homerseklet = new double[honapok, napok];

            Random rand = new Random();
            for (int i = 0; i < honapok; i++)
            {
                for (int j = 0; j < napok; j++)
                {
                    homerseklet[i, j] = rand.NextDouble() * 40 - 10;
                }
            }

            double maxhő = double.MinValue;
            double minhő = double.MaxValue;

            for (int i = 0; i < honapok; i++)
            {
                for (int j = 0; j < napok; j++)
                {
                    if (homerseklet[i, j] > maxhő)
                    {
                        maxhő = homerseklet[i, j];
                    }
                    if (homerseklet[i, j] < minhő)
                    {
                        minhő = homerseklet[i, j];
                    }
                }
            }
            Console.WriteLine("A legmelegebb fok:{0}", maxhő);
            Console.WriteLine("A leghidegebb fok:{0}", minhő);
            Console.ReadKey();

        }
    }
}
