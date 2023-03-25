using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsempeOOP
{
    internal class Csempe
    {
        public double a, b, T, cs, TT;
        public Csempe() { }
        public Csempe(double a, double b, double T, double cs, double TT)
        {
            this.a = a;
            this.b = b;
            this.T = T;
            this.cs = cs;
            this.TT = TT;
        }
        public void setA(double a)
        {
            this.a = a;
        }
        public void setB(double b)
        {
            this.b = b;
        }
        public void setT()
        {
            this.T = this.a * this.b;
        }
        public void setCS()
        {
            this.cs = this.T / (0.2 * 0.2);
        }
        public void setTT()
        {
            this.TT = this.cs * 1.1;
        }
        public double getA() { return this.a; }
        public double getB() { return this.b; }
        public double getT() { return this.T; }
        public double getCS() { return this.cs; }
        public double getTT() { return this.TT; }
    }
}
