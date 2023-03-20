using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontHatOOP
{
    internal class PontHat
    {
        private int a;

        public PontHat() { }
        public PontHat(int a) 
        {
            this.a = a;
        }
        public void setA(int a)
        {
            this.a = a;
        }
        public int getA() 
        {   
            if(this.a > 100 && this.a<0)
            {
                Console.WriteLine("Hibás pontszám!");
            }
            else if (this.a < 50)
            {
                Console.WriteLine("Egyes, a pont száma:{0}",this.a );
            }
            else if (this.a >= 50 && this.a < 65)
            {
                Console.WriteLine("Kettes, a pont száma:{0}", this.a);
            }
            else if (this.a >= 65 && this.a < 80)
            {
                Console.WriteLine("Hármas, a pont száma:{0}", this.a);
            }
            else if (this.a >= 80 && this.a < 90)
            {
                Console.WriteLine("Négyes, a pont száma:{0}", this.a);
            }
            else if (this.a >= 90)
            {
                Console.WriteLine("Öttös, a pont száma:{0}", this.a);
            }
            
        }
    }
}
