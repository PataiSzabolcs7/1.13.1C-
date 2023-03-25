using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halmazállapot
{
    internal class Halmazállapot
    {
        private int Halmaz;

        public Halmazállapot() { }
        public Halmazállapot(int Halmaz)
        {
            this.Halmaz = Halmaz;
        }
        public void setHalmaz(int Halmaz)
        {
            this.Halmaz = Halmaz;

            if (this.Halmaz < 0)
            {
                Console.WriteLine("A víz halmazállapota: Szilárd");
            }
            else if (this.Halmaz >= 0 && this.Halmaz < 100)
            {
                Console.WriteLine("A víz halmazállapota: Folyékony");
            }
            else if (this.Halmaz >= 100 )
            {
                Console.WriteLine("A víz halmazállapota: Gőz");
            }
        }
        public double getHalmaz()
        {
            return this.Halmaz;
        }
    }
}
