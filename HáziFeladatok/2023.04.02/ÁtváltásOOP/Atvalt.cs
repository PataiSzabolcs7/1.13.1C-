using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvaltOOP
{
    internal class Atvalt
    {
        int a, b, c, d;
        public Atvalt() { }
        public void setB(int b)
        {
            this.b = b;
        }
        public void setC(int c)
        {
            this.c = c;
        }
        public void setD(int d)
        {
            this.d = d;
        }
        public void setA(int a)
        {
            this.a = a;
            while (this.a > 0)
            {
                this.d = this.a % 10;
                this.a = this.a / 10;
                this.b += this.d * this.c;
                this.c = this.c * 2;
            }
        }
        public int getC() { return this.c; }
    }
}
