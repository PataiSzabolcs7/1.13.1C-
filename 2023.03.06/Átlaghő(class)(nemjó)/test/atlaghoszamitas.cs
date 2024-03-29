﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Átlaghő
{
    internal class atlaghoszamitas
    {
        private int honapok = 12;
        private int napok = 30;
        public static int[,] homerseklet = new int[honapok, napok];

        Random rand = new Random();
        public atlaghoszamitas() { }

        public void randombehozas()
        {
            int[,] homerseklet = new int[honapok, napok];

            for (int i = 0; i < honapok; i++)
            {
                for (int j = 0; j < napok; j++)
                {
                    homerseklet[i, j] = rand.Next(-20, 40);
                }
            }
        }
        public void szamitas()
        {
            int maxho = int.MinValue;
            int minho = int.MaxValue;
            int[,] homerseklet = new int[honapok, napok];

            for (int i = 0; i < honapok; i++)
            {
                for (int j = 0; j < napok; j++)
                {
                    if (homerseklet[i, j] > maxho)
                    {
                        maxho = homerseklet[i, j];
                    }
                    if (homerseklet[i, j] < minho)
                    {
                        minho = homerseklet[i, j];
                    }
                }
            }
            Console.WriteLine("A legmelegebb fok:{0}", maxho);
            Console.WriteLine("A leghidegebb fok:{0}", minho);

        }
        public void honapszamitas()
        {
            int[,] homerseklet = new int[honapok, napok];
            int[] honapho = new int[honapok];
            for (int i = 0; i < honapok; i++)
            {
                int sum = 0;
                for (int j = 0; j < napok; j++)
                {
                    sum += homerseklet[i, j];
                }
                honapho[i] = sum / napok;
            }
            int maxhonapho = int.MinValue;
            int minhonapho = int.MaxValue;
            int maxhonap = 0;
            int minhonap = 0;
            for (int i = 0; i < honapok; i++)
            {
                if (honapho[i] > maxhonapho)
                {
                    maxhonapho = honapho[i];
                    maxhonap = i + 1;
                }
                if (honapho[i] < minhonapho)
                {
                    minhonapho = honapho[i];
                    minhonap = i + 1;
                }
            }
            Console.WriteLine("A legmelegebb hónap:{0}-dik, az átlagoshőmérséklet:{1} fok", maxhonap, maxhonapho);
            Console.WriteLine("A leghidegebb hónap:{0}-dik, az átlagoshőmérséklet:{1} fok", minhonap, minhonapho);
        }

    }
}
