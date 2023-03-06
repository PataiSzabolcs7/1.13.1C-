using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szigetek
{
    internal class Szigetszamolas
    {
        // Osztályváltozó
        int islandcount = 0,
            maxIslandLength = 0,
            i = 0;
        string data = string.Empty;
        //Konstuktorok
        public Szigetszamolas() { }

        public Szigetszamolas(string data)
        {
            this.data = data;
        }
        //Metódusok

        public void setData(string data)
        {
            this.data = data;
        }
        public string getData() 
        { 
            return this.data;
        }
        public int getIslandCount()
        {
            return this.islandcount;
        }
        public int getMaxIslandLength()
        {
            return this.maxIslandLength;
        }
        public void Szamol()
        {
            while (i < data.Length)
            {
                if (this.data[i] == '1')
                {
                    ++this.islandcount;
                    int j = i;
                    int tmp = 0;
                    while (j < this.data.Length && data[j] == '1')
                    {
                        ++j; ++tmp;
                    }
                    i = j;
                    if (tmp > this.maxIslandLength)
                    {
                        this.maxIslandLength = tmp;
                    }
                }
                else
                {
                    ++i;
                }
            }
        }
    }
}
