using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorf
{
    class Ember
    {
        public string Nev { get; set; }
        private string bemut = "Üdvözlöm a nevem:";

        public Ember(string nev)
        {
            Nev = nev;
        }

        public string beszel()
        {
            return (bemut + Nev);
        }
    }

    class Ferfi : Ember
    {
        public int Kor { get; set; }
        public Ferfi(string nev, int kor) : base(nev)
        {
            Kor = kor;
        }
    }

    class Woman : Ember
    {
        public string SzemSzin { get; set; }
        public Woman(string nev,string szemszin) : base(nev) 
        {
            SzemSzin= szemszin;
        }
    }
    class haz
    {
        private List<Ember> lakok = new List<Ember>();

        public void hazajon(Ember obj)
        {
            this.lakok.Add(obj); 
        }
        public void csenget()
        {
            int i;
            Random rd = new Random();
            if(lakok.Count> 0) 
            {
                i = rd.Next (0, lakok.Count-1);
                Console.WriteLine(lakok[i].beszel());
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            haz otthon = new haz();

            Woman eva = new Woman("Éva", "zöld");
            Woman kati = new Woman("Kati", "barna");
            Woman sari = new Woman("Sári","kék");
            Woman zsuzsi = new Woman("Zsuzsi", "zöld");

            Ferfi adam = new Ferfi("Ádám", 26);
            Ferfi dani = new Ferfi("Dani", 26);
            Ferfi gergo = new Ferfi("Gergő", 26);
            Ferfi atti = new Ferfi("Attila", 26);

            if (eva is Ember) otthon.hazajon(eva as Ember);
                otthon.hazajon((Ember)kati);
                otthon.hazajon((Ember)sari);
                otthon.hazajon((Ember)zsuzsi);
                otthon.hazajon((Ember)adam);
                otthon.hazajon((Ember)dani);
                otthon.hazajon((Ember)gergo);
                otthon.hazajon((Ember)atti);

            bool tovabb = true;
            do
            {
                otthon.csenget();
                tovabb = (Console.ReadLine() == String.Empty?
                    false: true);
            }while (tovabb);
            Console.ReadKey();  
        }
    }
}
