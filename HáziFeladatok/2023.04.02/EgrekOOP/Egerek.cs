using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgerekOOP
{
    internal class Egerek
    {
        double u, v, l, tal, t;

        public Egerek() { }
        public void setU(double u)
        {
            this.u = u;
        }
        public void setV(double v)
        {
            this.v = v;
        }
        public void setL(double l)
        {
            this.l = l;
        }
        public void setT(double t)
        {
            this.t = t;
        }
        public void setTAL()
        {
            if (this.u > this.v)
            {
                this.tal = Math.Sqrt((this.u / this.v) * this.t);
            }
            else
            {
                this.tal = Math.Sqrt((this.v / this.u) * this.t);
            }
        }
        public double getTAL()
        {
            return this.tal;
        }
    }
}
