using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SugárOOP
{
    internal class Sugár
    {
        public double a, m, átló, szög, r, R;
        public Sugár() { }
        public Sugár(double a, double m, double átló, double szög, double r, double R)
        {
            this.a = a;
            this.m = m;
            this.átló = átló;
            this.szög = szög;
            this.r = r;
            this.R = R;
        }
        public void setSZÖG(double szög)
        {
            this.szög = szög;
        }
        public double getSZÖG() 
        {
            return this.szög;
        }
        public void setA(double a)
        {
            this.a = a;
        }

        public void setM(double m)
        {
            this.m = m;
        }
        public void setRs()
        {
            if (this.szög == 4)
            {
                this.r = this.a / 2;
                Console.WriteLine("A beírható kör sugara: {0}cm", this.r);
            }
            else if (this.szög == 5)
            {
                this.r = 5 / Math.Tan(36);
                Console.WriteLine("A beírható kör sugara: {0}cm", this.r);
            }
            else if (this.szög == 6)
            {
                r = (this.a * Math.Sqrt(3)) / 2;
                Console.WriteLine("A beírható kör sugara: {0}cm", this.r);
            }
        }
        public void setRa()
        {
            if (this.szög == 4)
            {
                this.R = (Math.Sqrt(2) * a) / 2;
                Console.WriteLine("A körülírt kör sugara: {0}cm", this.R);
            }
            else if (this.szög == 5)
            {
                this.R = 5 / Math.Sin(36);
                Console.WriteLine("A körülírt kör sugara: {0}cm", this.R);
            }
            else if (this.szög == 6)
            {
                this.R = this.a;
                Console.WriteLine("A körülírt kör sugara: {0}cm", this.R);
            }
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
            else if (this.szög == 5)
            {
                Console.WriteLine("Add meg a magasságot (cm): ");
                this.m = double.Parse(Console.ReadLine());
                this.átló = Math.Pow(a, 2) + Math.Pow(m, 2);
                Console.WriteLine("Az átló hossza: {0}cm", this.átló);
            }
            else if (szög == 6)
            {
                Console.WriteLine("Add meg a magasságot (cm): ");
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
