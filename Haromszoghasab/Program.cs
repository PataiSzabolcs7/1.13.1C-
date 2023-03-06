using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Haromszog
{
    class Haromszog
    {
        //Osztályváltozók
        private double a;
        private double b;
        private double c;
        private double S;
        private double T;
        private double K;

        //Konstruktorok
        public Haromszog() { }
        public Haromszog(double a, double b, double c,double S)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.S = (this.a + this.b + this.c) / 2;
        }

        //Metódusok
        public void setA(double a)
        {
            this.a = a;
        }
        public void setB(double b)
        {
            this.b = b;
        }
        public void setC(double c)
        {
            this.c = c;
        }
        public void setS()
        {
            this.S = (this.a + this.b + this.c) / 2;
        }

        public double getA()
        {
            return this.a;
        }
        public double getB()
        {
            return this.b;
        }
        public double getC()
        {
            return this.c;
        }
        public void setT()
        {
            this.T = Math.Sqrt(this.S * (this.S - this.a) * (this.S - this.b) * (this.S - this.c));
        }
        public double getT()
        {
            return this.T;
        }

        public void setK()
        {
            this.K = this.a + this.b + this.c;
        }
        public double getK()
        {
            return this.K;
        }
    }
    class Hasab : Haromszog
    {
        private double a;
        private double m;
        private double V;
        private double F;

        public Hasab() :base() { }
        public Hasab(double m,double a, double b, double c, double S) : base(a,b,c,S)
        {
            this.m= m;
        }
        public void setM(double m)
        {
            this.m = m;
        }
        public void setHaromszog()
        {
            base.setT();
            base.setK();
        }
        public void setV()
        {
            this.V = base.getT() * this.m;
        }
        public double getV()
        {
            return this.V;
        }
        public void setF()
        {
            this.F = 2*base.getT()+base.getK()*2;
        }
        public double getF()
        {
            return this.F;
        }

    }
    internal class Program
    {
        enum nyom
        {
            oldal, KT
        }
        static void Main(string[] args)
        {
            Haromszog h2 = new Haromszog(6, 5, 9, 4);
            h2.setT();
            h2.setK();
            Console.WriteLine("A háromszög kerülete: {0}, területe: {1}", h2.getK(), h2.getT());

            Hasab h3 = new Hasab();
            h3.setA(6);
            h3.setM(5);
            h3.setF();
            h3.setV();
            Console.WriteLine("A hasáb felszíne: {0}, térfogata: {1}", h3.getF(), h3.getV());
            Console.ReadKey();
        }
    }
}
