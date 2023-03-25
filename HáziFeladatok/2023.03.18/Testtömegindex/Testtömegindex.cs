using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testtömegindex
{
    internal class Testtömegindex
    {
        private double TT;
        private double TM;
        private double Index;

        public Testtömegindex() { }
        public Testtömegindex(double TT, double TM, double Index)
        {
            this.TT = TT;
            this.TM = TM;
            this.Index = Index;
        }
        public void setTT(double TT)
        {
            this.TT=TT;
        }public void setTM(double TM)
        {
            this.TM=TM;
        }public void setIndex()
        {
            this.Index = this.TT / Math.Pow(this.TM,2);
            if (this.Index < 18)
            {
                Console.WriteLine("A testtömeg indexed: Sovány");
            }
            else if (this.Index >= 18 && this.Index <= 24.9)
            {
                Console.WriteLine("A testtömeg indexed: Normális");
            }
            else if(this.Index >= 25 && this.Index <= 29.9)
            {
                Console.WriteLine("A testtömeg indexed: Túlsúlyos");
            }
            else if(this.Index >= 30 && this.Index <= 34.9)
            {
                Console.WriteLine("A testtömeg indexed: Elhízott");
            }
            else if(this.Index > 35)
            {
                Console.WriteLine("A testtömeg indexed: Erősen elhízott");
            }
        }
        public double getTT()
        {
            return this.TT;
        }        
        public double getTM()
        {
            return this.TM;
        }        
        public double getIndex()
        {
            return this.Index;
        }
    }
}
