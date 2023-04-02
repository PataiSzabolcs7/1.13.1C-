using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortOOP
{
    internal class Tort
    {
        private double n, sz, c;
        public Tort() { }

        public void setN(double n)
        {
            this.n = n;
        }
        public void setSZ(double sz)
        {
            this.sz = sz;
        }
        public void setC()
        {
            this.c = (1 / this.n) * this.sz;
        }
        public double getC() { return this.c; }
    }
}
