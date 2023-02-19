using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int islandCount = 0;
            int maxIslandLength = 0;
            int i = 0;
            string data = "9";

            while (i < data.Length)
            {
                if (data[i] == '1')
                {
                    ++islandCount;
                    int j = i;
                    int tmp = 0;

                    while (j < data.Length && data[j] == '1')
                    {
                        j++;
                        tmp++;
                    }
                    i = j;

                    if (tmp > maxIslandLength) { maxIslandLength = tmp; }
                    
                }
                else
                {
                    ++i;
                }
            }
        }
    }
}
