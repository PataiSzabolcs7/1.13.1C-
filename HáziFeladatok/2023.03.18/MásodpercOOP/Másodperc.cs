using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MásodpercOOP
{
    internal class Másodperc
    {
        public int a, b, c, d, e, f, g, h, vég;
        public Másodperc() { }
        public Másodperc(int a, int b, int c, int d, int e, int f, int g, int h, int vég)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            this.g = g;
            this.h = h;
            this.vég = vég;
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
        public void setD()
        {
            this.d = this.a * 3600 + this.b * 60 + this.c;
        }
        public void setE(int e)
        {
            this.e = e;
        }
        public void setF(int f)
        {
            this.f = f;
        }
        public void setG(int g)
        {
            this.g = g;
        }
        public void setH()
        {
            this.h = this.e * 3600 + this.f * 60 + this.g;
        }
        public void setVÉG()
        {
            if (this.d > this.h)
            {
                this.vég = this.d - this.h;
                Console.WriteLine(this.vég);
            }
            else
            {
                this.vég = this.h - this.d;
                Console.WriteLine(this.vég);
            }
        }
    }
}
