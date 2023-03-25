using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontHatOOP
{
    internal class PontHatOOP
    {
        private int Jegy;
        private int Pont;

        public PontHatOOP() { }
        public PontHatOOP(int Jegy, int Pont)
        {
            this.Jegy = Jegy;
            this.Pont = Pont;
        }
        public void setPont(int Pont)
        {
            this.Pont = Pont;
        }
        public void setJegy()
        {
            if (this.Pont >= 0 && this.Pont <= 49)
            {
                Console.WriteLine("Érdemjegyed: 1");
            }
            else if (this.Pont >= 50 && this.Pont <= 64)
            {
                Console.WriteLine("Érdemjegyed: 2");
            }
            else if (this.Pont >= 65 && this.Pont <= 79)
            {
                Console.WriteLine("Érdemjegyed: 3");
            }
            else if (this.Pont >= 80 && this.Pont <= 89)
            {
                Console.WriteLine("Érdemjegyed: 4");
            }
            else if (this.Pont >= 90 && this.Pont <= 100)
            {
                Console.WriteLine("Érdemjegyed: 5");
            }
            else
            {
                Console.WriteLine("Hibás adat!");
            }
        }
        public PontHatOOP(int Pont, string Jegy)
        {
            if (this.Pont <= 49)
            {
                Console.WriteLine("Érdemjegyed: 1");
            }
            else if (this.Pont <= 64)
            {
                Console.WriteLine("Érdemjegyed: 2");
            }
            else if (this.Pont <= 79)
            {
                Console.WriteLine("Érdemjegyed: 3");
            }
            else if (this.Pont <= 89)
            {
                Console.WriteLine("Érdemjegyed: 4");
            }
            else if (this.Pont <= 100)
            {
                Console.WriteLine("Érdemjegyed: 5");
            }
            else
            {
                Console.WriteLine("Hibás adat!");
            }
        }
        public double getJegy()
        {
            return this.Jegy;
        }
        public double getPont()
        {
            return this.Pont;
        }
    }
}
