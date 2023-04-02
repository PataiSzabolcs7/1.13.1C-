using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorosszegOOP
{
    internal class Sorosszeg
    {
        double n, k;

        public Sorosszeg() { }
        public void setN(double n)
        {
            this.n = n;
        }
        public void setK()
        {
            this.k = this.n*(this.n-1);
        }
        public double getK()
        {
            return this.k;
        }
    }
}
