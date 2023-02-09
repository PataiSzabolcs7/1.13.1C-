using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a szög tipusát!: (Háromszög (3), Négyszög (4), Ötszög (5), Hatszög(6)");
            int valasztas = int.Parse(Console.ReadLine());
            switch (valasztas)
            {
                case 3:
                    Console.WriteLine("Adja meg a háromszög oldalainak hosszát:");
                    double oldal1 = double.Parse(Console.ReadLine());
                    double oldal2 = double.Parse(Console.ReadLine());
                    double oldal3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("A háromszög sugara:" + haromszog(oldal1, oldal2, oldal3));
                    break;
                case 4:
                    Console.WriteLine("Adja meg a négyszög oldalainak számát:");
                    double oldal4 = double.Parse(Console.ReadLine());
                    double oldal5 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Adja meg a négyszög magasságát:");
                    double magassag = double.Parse(Console.ReadLine());
                    Console.WriteLine("A négyszög sugara:" + negyszog(oldal4, oldal5, magassag));
                    break;
                case 5:
                    Console.WriteLine("Az ötszög átlóinak hossza nem kiszámítható.");
                    break;
                case 6:
                    Console.WriteLine("Adja meg a hatszög sugara hosszát:");
                    double oldal6 = double.Parse(Console.ReadLine());
                    Console.WriteLine("A hatszögnek átlóinak hossza:" + hatszog(oldal6));
                    break;
                default:
                    Console.WriteLine("Nem megfelelő szög!");
                    break;
            }
            Console.ReadLine();
            double haromszog(double oldal1, double oldal2, double oldal3)
            {
                double s = (oldal1 + oldal2 + oldal3) / 2;
                double area = Math.Sqrt(s * (s - oldal1) * (s - oldal2) * (s - oldal3));
                return (2 * area / oldal3) / 2;

            }

            double negyszog(double oldal4, double oldal5, double magassag)
            {
                return Math.Sqrt(oldal4 * oldal4 + oldal5 * oldal5 + 2 * magassag * magassag) / 2;
            }

            double hatszog(double oldal6)
            {
                return (oldal6 * Math.Sqrt(3) / 2);
            }
        }
    }
}