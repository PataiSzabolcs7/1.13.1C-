using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HofokOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hőmérsékletek tömbje
            int[,] data = new int[12, 30];

            //Hőmérséklet tömb feltöltése adatokkal
            setMatrix(data);

            //Kiíratom a tömb adatait
            kiirMatrix(data);

            //Példányosítom az osztályt
            Hofokszamitas afok = new Hofokszamitas(data);

            //Elvégeztetem vele a számításokat
            afok.szamitas();

            //Kiratom a legmelegebb napot
            prLegmelegebbNap(afok);
            //Kiratom a leghidegebb napot
            prLeghidegebbNap(afok);
            //Kiratom a legmelegebb hónapot
            prLegmelegebbHónap(afok);
            //Kiratom a leghidegebb hónapot
            prLeghidegebbHónap(afok);


            Console.ReadKey();
        }

        private static void prLeghidegebbHónap(Hofokszamitas afok)
        {
            Console.WriteLine("Az év leghidegebb hónapja: {0}: {1} fok", afok.gethaviMin().honap, afok.gethaviMin().hofok);
        }

        private static void prLegmelegebbHónap(Hofokszamitas afok)
        {
            Haviadat adat=new Haviadat();
            adat = afok.gethaviMax();
            Console.WriteLine("Az év legmelegebb hónapja: {0}: {1} fok", adat.honap, adat.hofok);
        }

        private static void prLeghidegebbNap(Hofokszamitas afok)
        {
            Console.WriteLine("Az év leghidegebb napja: {0} {1}: {2} fok", afok.getnapiMin().honap, afok.getnapiMin().nap, afok.getnapiMin().hofok);
        }

        private static void prLegmelegebbNap(Hofokszamitas afok)
        {
            Napiadat adat=new Napiadat();
            adat=afok.getnapiMax();
            Console.WriteLine("Az év legmelegebb napja: {0} {1}: {2} fok", adat.honap, adat.nap, adat.hofok);
        }
        private static void prOtMinusz(Hofokszamitas p)
        {

            Napiadat[] napiadat = new Napiadat[5];

            napiadat=p.getotMinusz();
            if (napiadat[0].hofok < 0)
            {
                Console.WriteLine("Az öt összefüggő mínuszos nap a következő: ");
                for (int i = 0; i < napiadat.Length; i++)
                {
                    Console.WriteLine("{0} {1}: {2}", napiadat[i].honap, napiadat[i].nap, napiadat[i].hofok);
                }
            }
            else
            {
                Console.WriteLine("Nem volt 5 mínuszos összefüggő nap");
            }
        }
        private static void kiirMatrix(int[,] data)
        {
            Console.WriteLine("\n Az éves hőmérséklet adatok: ");
            for (int i = 0; i < data.GetLength(0); i++)
            {
                Console.Write("\n {0}. hónap: ", i+1);
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("{0}, " ,data[i,j]);
                }
            }
        }

        private static void setMatrix(int[,] data)
        {
            //Havi min és max hőmérséklet tömbje
            int[,] minmax =
            {
                {-20,5},
                {-12,5},
                {-7,14},
                {-2,17},
                {10,19},
                {18,32},
                {25,38},
                {25,30},
                {12,25},
                {5,17},
                {-7,18},
                {-10,5},
            };

            //Munkaváltozók
            int mn = 0; //Havi minimum hőmérséklet
            int mx = 0; //Havi maximum hőmérséklet
            Random rand = new Random();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = rand.Next(minmax[i,0], minmax[i,1]);
                }
            }
        }
    }
}
