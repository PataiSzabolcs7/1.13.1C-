using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HofokOOP
{
    struct Napiadat
    {
        public string honap; //Hónap neve
        public int nap;      //Nap sorszáma
        public int hofok;    //Napi hőmérséklet
    }
    struct Haviadat
    {
        public string honap; //Hónap neve
        public int hofok;    //Havi átlaghőmérséklet
    }
    internal class Hofokszamitas
    {
        //Osztályváltozók
        private int[,] adat = null;                 //Hőfokok tárolása
        private int[] haviAtlag = new int[12];      //Havi átlaghőfokok
        private Napiadat napiMax, napiMin;          //Legmagasabb és legalacsonyabb hőmérsékletű nap adatai
        private Haviadat haviMax, haviMin;          //Legmagasabb és legalacsonyabb átlaghőmérsékletű hónap adatai
        private Napiadat[]otMinusz=new Napiadat[5]; //Az öt minusz nap tömbje
        static string[] honapok = { "Január", "Február", "Március", "Április", "Május", "Június", "Július", "Augusztus", "Szeptember", "Október", "November", "December" };

        //Konstruktorok
        public Hofokszamitas(int[,] p) 
        {
            this.adat = p;
        }
        //Eredményeket átadó metódusok
        public Napiadat getnapiMin() 
        {
            return napiMin;
        }
        public Napiadat getnapiMax() 
        {
            return napiMax;
        }
        public Haviadat gethaviMin()
        {
            return haviMin;
        }
        public Haviadat gethaviMax() 
        {
            return haviMax;
        }
        public Napiadat[] getotMinusz()
        {
            return otMinusz;
        }

        //Számítások
        public void szamitas()
        {
            //Leghidegebb és legmelegebb napok kiszámítása
            setNapiMaxMin();

            //Leghidegebb és legmelegebb átlaghőmérsékletű hónap kiszámítása
            setHaviAtlag();
            setHavimaxmin();
        }

        private void setHaviAtlag()
        {
            int osszeg = 0;                                //Gyűjtés
            for (int i = 0; i < adat.GetLength(0); i++)    //A hónapok ciklusa
            {
                osszeg = 0;
                for(int j = 0; j < adat.GetLength(1); j++) //A napok ciklusa
                {
                    osszeg += adat[i, j];
                }
                this.haviAtlag[i]=osszeg/adat.GetLength(1);
            }
        }

        public void setOtminusz()
        {
            int mDb = 0;                                //Ezzel számolom, hogy hanyadik mínuszos napon tartunk
            for (int i=0; i<adat.GetLength(0); i++)     //Hónap ciklusa
            {
                for (int j=0; j<adat.GetLength(1); j++) //Napok ciklusa
                {
                    if (this.adat[i, j] < 0 && mDb<=6)
                    {
                        this.otMinusz[mDb].honap = honapok[i];
                        this.otMinusz[mDb].nap = j + 1;
                        this.otMinusz[mDb].hofok = this.adat[i,j];
                        mDb++;
                    }
                    else
                    {
                        for (int k = 0; k < mDb+1; k++)
                        {
                            this.otMinusz[k].honap = String.Empty;
                            this.otMinusz[k].nap = 0;
                            this.otMinusz[k].hofok = 0;
                        }
                        mDb = 0;
                    }
                }
            }
        }

        private void setHavimaxmin()
        {
            int max = int.MinValue;
            int maxIndex = 0;
            int min = int.MaxValue;
            int minIndex = 0;
            for (int i=0; i < this.haviAtlag.Length; i++)
            {
                if (this.haviAtlag[i] > max)
                {
                    max = this.haviAtlag[i];
                    maxIndex = i;
                }
                else if (this.haviAtlag[i] < min)
                {
                    min = this.haviAtlag[i];
                    minIndex = i;
                }
            }

            //Eredmények tárolása
            this.haviMax.hofok = max;
            this.haviMax.honap = honapok[maxIndex];
            this.haviMin.hofok = min;
            this.haviMin.honap = honapok[minIndex];
        }

        private void setNapiMaxMin()
        {
            int max = int.MinValue;
            int maxI = 0;
            int maxJ = 0;
            int min = int.MaxValue;
            int minI = 0;
            int minJ = 0;
            for (int i = 0; i < adat.GetLength(0); i++)     //Hónapok ciklusa
            {
                for (int j = 0; j < adat.GetLength(1); j++) //Napok ciklusa
                {
                    if (this.adat[i, j] > max)
                    {
                        max=this.adat[i, j];
                        maxI=i;
                        maxJ=j;
                    }
                    if (this.adat[i, j] < min)
                    {
                        min = this.adat[i, j];
                        minI = i;
                        minJ = j;
                    }
                }
            }
            //Eredmény átadása a tömbnek
            this.napiMax.honap = honapok[maxI];
            this.napiMax.nap = maxJ+1;           //Mivel 0. nap nincs a hónapokban, ezért növelem
            this.napiMax.hofok = max;
            this.napiMin.honap = honapok[minI];
            this.napiMin.nap = minJ + 1;         //Mivel 0. nap nincs a hónapokban, ezért növelem
            this.napiMin.hofok = min;

        }
    }
}
