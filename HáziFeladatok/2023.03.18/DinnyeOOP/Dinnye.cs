using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnyeOOP
{
    internal class Dinnye
    {
        public double osszeg;
        public double d;
        public double db;

        public Dinnye() { }

        public Dinnye(double db, double d, double osszeg)
        {
            this.db = db;
            this.d = d;
            this.osszeg = osszeg;
        }
        public void setD(double d)
        {
            this.d = d;
        }
        public void setDB(double db)
        {
            this.db = db;
        }
        public double getDB()
        {
            return this.db;
        }
        public double getD()
        {
            return this.d;
        }
        public void setOsszeg()
        {
            this.osszeg = ((((this.d * Math.PI) * 2) + 60) * this.db) / 100;
        }
        public double getOsszeg()
        {
            return this.osszeg;
        }
    }
}
