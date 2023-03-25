using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyökOOP
{
    internal class Másodfokú
    {
        int a, b, c, gyök;
        double gyök2, vég, vég2;
        public Másodfokú() { }
        public Másodfokú(int a, int b, int c, int gyök, double gyök2, double vég, double vég2)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.gyök = gyök;
            this.gyök2 = gyök2;
            this.vég = vég;
            this.vég2 = vég2;
        }
        public void setA(int a)
        {
            this.a = a;
        }
        public void setB(int b)
        {
            this.b = b;
        }
        public void setC(int c)
        {
            this.c = c;
        }
        public void setGYÖK()
        {
            this.gyök = (int)(Math.Pow(this.b, 2) - (4 * this.a * this.c));
            if (this.gyök < 0)
            {
                this.gyök = Math.Abs(this.gyök);
            }
        }
        public void setGYÖK2()
        {
            this.gyök2 = (float)(Math.Sqrt(this.gyök));
        }
        public void setVÉG()
        {
            this.vég = (-this.b + this.gyök2) / (2 * this.a);
            Console.WriteLine("x1: {0}", this.vég);
        }
        public void setVÉG2()
        {
            this.vég2 = (-this.b - this.gyök2) / (2 * this.a);
            Console.WriteLine("x1: {0}", this.vég2);

            if (this.vég < 0 && this.vég2 < 0)
            {
                Console.WriteLine("Nincs valós gyöke");
            }
            else if (this.vég > 0 && this.vég2 > 0)
            {
                Console.WriteLine("2 valós gyöke van");
            }
            else
            {
                Console.WriteLine("1 valós gyöke van");
            }
        }
    }
}
