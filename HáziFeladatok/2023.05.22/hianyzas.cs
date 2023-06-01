using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _20230522
{
    internal class hianyzas
    {
        //Változók
        double f;
        int a, b;
        string nev;
        public hianyzas() { }
        //Metódusok
        public void setA(int a)
        {
            this.a = a;
        }
        public int getA()
        {
            return this.a;
        }
        public void setNev(string nev)
        {
            this.nev = nev;
        }
        public void setB(int b)
        {
            this.b = b;
        }
        public int getB()
        {
            return this.b;
        }
        public void setf(double f)
        {
            this.f = f;
        }
        public double getf()
        {
            return this.f;
        }
        public void setIgazolt()
        {
            if (this.b > 0 && this.b < 250)
            {
                Console.WriteLine("{0} ennyi igazolt hiányzása van : {1} ", this.nev, this.b);
            }
            if(this.b >= 250)
            {
                Console.WriteLine("{0} elérte/átlépte a megengedett hiányzást!\n Hiányzott óraák száma: {1}\n",this.nev, this.b);
            }
            
        }
        public void setIgazolatlan()
        { 
            if(this.a >= 0 && this.a <= 2)
            {
                Console.WriteLine("{0} magatartás jegye: 5", this.nev);
            }
            else if (this.a >= 2 && this.a <= 4)
            {
                Console.WriteLine("{0} magatartás jegye: 4", this.nev);
            }
            else if (this.a >= 4 && this.a <= 6)
            {
                Console.WriteLine("{0} magatartás jegye: 3", this.nev);
            }
            else if (this.a >= 6 && this.a <= 8)
            {
                Console.WriteLine("{0} magatartás jegye: 2", this.nev);
            }
            else if (this.a >=  8 && this.a <= 10)
            {
                Console.WriteLine("{0} magatartás jegye: 1", this.nev);
            }
        }
        public void setDolgok()
        {
            if(this.a >= 10)
            {
                if (this.a > 10 && this.a < 20)
                {
                    Console.WriteLine("Ajánlott Büntetés:\nSzaktanári figyelmeztetés!");
                }
                else if (this.a >= 20 && this.a < 30)
                {
                    Console.WriteLine("Ajánlott Büntetés:\nOsztályfőnöki intő!");
                }
                else if (this.a >= 30 && this.a < 40)
                {
                    Console.WriteLine("Ajánlott Büntetés:\nIgazgatói megrovás!");
                }
                else if (this.a >= 40)
                {
                    Console.WriteLine("Ajánlott Büntetés:\nFelfüggesztés!");
                }
            }
        }
        public void setJutalom()
        {
            if (this.a == 0 && this.b == 0)
            {
                Console.WriteLine("\n Diáknak nincsen igazolt ésigazolatlan hiányzása!\n Ezért jutalomban részesül! ");
                
            }
        }
        public void setOsszegzes()
        {
            Console.WriteLine("\nDiák neve: {0} \nSzületési dátuma:{1} \nIgazolt hiányzása: {2} \nIgazolatlan hiányzása:{3}", this.nev, this.f, this.b, this.a);
        }
        
    }
}
