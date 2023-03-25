using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pontok_távolsága
{
    internal class Pontok_távolsága
    {
        private double Pont1;
        private double Pont2;
        private double Pont3;
        private double Pont4;
        private double Keplet;

        public Pontok_távolsága() { }
        public Pontok_távolsága(double Pont1, double Pont2, double Pont3, double Pont4)
        {
            this.Pont1 = Pont1;
            this.Pont2 = Pont2;
            this.Pont3 = Pont3;
            this.Pont4 = Pont4;
        }
        public void setPont1(double Pont1)
        {
            this.Pont1 = Pont1;
        }
        public void setPont2(double Pont2)
        {
            this.Pont2 = Pont2;
        }
        public void setPont3(double Pont3)
        {
            this.Pont4 = Pont3;
        }
        public void setPont4(double Pont4)
        {
            this.Pont4 = Pont4;
        }
        public double getPont1()
        {
            return this.Pont1;
        }
        public double getPont2()
        {
            return this.Pont2;
        }
        public double getPont3()
        {
            return this.Pont3;
        }
        public double getPont4()
        {
            return this.Pont4;
        }
        public void setKeplet()
        {
            this.Keplet = Math.Sqrt(Math.Pow(this.Pont2 - this.Pont1, 2) + Math.Pow(this.Pont4 - this.Pont3, 2));
        }
        public double getKeplet()
        {
            return this.Keplet;
        }
    }
}
