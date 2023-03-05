using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Haromszoghasab
{
    class Haromszog
    {
        //Osztályváltozók
        private double a;
        private double b;
        private double c;
        private double K;
        private double T;

        //Konstruktorok
        public Haromszog() { }

        public Haromszog(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
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
        public void setK()
        {
            this.K = this.a + this.b + this.c;
        }
        public double getK()
        {
            return this.K;
        }
        public void setT()
        {
            this.K = (this.a * this.c) / 2;
        }
        public double getT()
        {
            return this.T;
        }
    }

    class Hhasab : Haromszog
    {
        //Osztályváltozók
        private double n;
        private double m;
        private double A;
        private double V;

        //Konstruktorok
        public Hhasab() : base() { }

        public Hhasab(double m, double n, double a) : base(a)
        {
            this.m = m;
            this.n = n;
        }
        public void setM(double m)
        {
            this.m = m;
        }
        public void setN(double n)
        {
            this.n = n;
        }
        public void setHaromszog()
        {
            base.setK();
            base.setT();
        }
        public void setV()
        {
            this.V = base.getT() * this.m;
        }
        public double getV()
        {
            return this.V;
        }
        public void setA()
        {
            this.A = 2 * (base.getT()) + ((this.a * this.a) * this.a * this.m);
        }
        public double getA()
        {
            return this.A;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Haromszog h2 = new Haromszog(1, 2, 3);
            h2.setK();
            h2.setT();
            Console.WriteLine("Kerület:{0},Terület:{1}", h2.getK(), h2.getT());


            Hhasab h3 = new Hhasab(2, 3, 4);
            h3.setV();
            h3.setA();
            Console.WriteLine("Térfogat{0},Felszín{1}", h3.getV(), h3.getA());
            Console.ReadKey();
        }
    }
}