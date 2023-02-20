using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly
{   
    class kutya
    {
        //Properties / osztály változók / osztály tagjai
        private string nev;
        private int gender;
        public string Fajta { get; set; }
        // Konstruktorok

        public void setGender(string gender)
        {
            switch (gender)
            {
                case "Kan":
                    this.gender= 1; 
                    break;
                case "Szuka":
                    this.gender = 2;
                    break;
                default: 
                    this.gender = 3;
                    break;
            }
        }
        public string getGender()
        {
            switch(this.gender)
            {
                case 1:
                    return "Kan";
                case 2:
                    return "Szuka";
                default:
                    return "ismeretlen";
            }
        }
        public kutya(string nev) 
        {
            // a This ( Rámutatt arra az objektumra ahova írjuk)
            this.nev = nev;
        }

        public kutya() 
        {

        }

        public string getNev() => this.nev; // Lambda operátoros felírás

        public void setNev(string nev) 
        {
            this.nev = nev;
        }
    }
    internal class Program
    {   
        static void Main(string[] args)
        {
            kutya kutya1 = new kutya();
            kutya1.setNev("BODRI TE KUTYA");

            Console.WriteLine("A kutya neve: {0}", kutya1.getNev());

            kutya zeusz = new kutya("Zeusz");
            Console.WriteLine("A kutya neve: {0}", zeusz.getNev());

            zeusz.Fajta = "Német Juhász";
            Console.WriteLine("A Zeusz fajtája: {0}", zeusz.Fajta);

            Console.ReadKey();
        }
    }
}
