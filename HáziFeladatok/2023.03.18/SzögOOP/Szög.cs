using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzögOOP
{
    internal class Szög
    {
        public double a, m, átló, szög;
        public Szög() { }
        public Szög(double a, double m, double átló, double szög)
        {
            this.a = a;
            this.m = m;
            this.átló = átló;
            this.szög = szög;
        }
        public void setA(double a)
        {
            this.a = a;
        }
        public void setSZÖG(double szög)
        {
            this.szög = szög;
        }
        public void setM(double m)
        {
            this.m = m;
        }
        public void setÁTLÓ()
        {
            if (this.szög == 3)
            {
                Console.WriteLine("Az átló hossza: {0}cm", this.a);
            }
            else if (this.szög == 4)
            {
                this.átló = this.a * Math.Sqrt(2);
                Console.WriteLine("Az átló hossza: {0}cm", this.átló);
            }
            else if (this.szög >= 5)
            {
                Console.WriteLine("Add meg a magasságot: ");
                this.m = double.Parse(Console.ReadLine());
                this.átló = Math.Pow(a, 2) + Math.Pow(m, 2);
                Console.WriteLine("Az átló hossza: {0}cm", this.átló);
            }
            else
            {
                Console.WriteLine("Nincs ilyen alakzat!");
            }
        }
    }
}
