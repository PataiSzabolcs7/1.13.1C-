using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CímletezésOOP
{
    internal class Címletezés
    {
        static int[] Címletek = { 5, 10, 20, 50, 100, 200, 500, 1000, 2000, 5000, 10000, 20000 };
        private int Pénz;
        public Címletezés() { }
        public Címletezés(int Pénz)
        {
            this.Pénz = Pénz;
        }
        public void setPÉNZ(int Pénz)
        {
            this.Pénz = Pénz;
            int val= 0;
            for (int i = Címletek.Length - 1; i >= 0; i--)
            {

                while (Pénz >= Címletek[i])
                {
                    Pénz -= Címletek[i];
                    val++;
                    if (Pénz == 3 || Pénz == 8)
                    {
                        Pénz += 2;
                    }
                    else if (Pénz == 4 || Pénz == 9)
                    {
                        Pénz += 1;
                    }
                }
            }
            Console.WriteLine("Az összeg a lehető legkevesebb címletekből összeállítva: {0} db.", val);
        }
        public int getPENZ()
        {
            return this.Pénz;
        }
    }
}
