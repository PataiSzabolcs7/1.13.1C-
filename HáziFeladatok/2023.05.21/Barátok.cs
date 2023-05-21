using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BarátokOOP
{
    struct Szemely
    {
        public string nev;
        public DateTime szido;
        public char neme;
        public int hajlam;
    }
    internal class Barátok
    {
        private static string path = "..\\..\\";
        private static string inpfile= "Viccesnevek.csv";
        private static string outfile = "barat.csv";
        private List<Szemely> list = new List<Szemely>();
        #region Konstruktorok
        public Barátok() { }

        #endregion Konstruktorok
        #region Metódusok
        #region Beolvasás
        public void Beolvas()
        {
            FileStream fs = new FileStream(path + inpfile, FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                while (!sr.EndOfStream)
                {
                    this.list.Add(convert(sr.ReadLine().Split(';')));
                }
            }
        }
        #region Hozzáadás
        public void InsertBarat(string[] line)
        {
            this.list.Add(convert(line));
        }
        #endregion Hozzáadás
        #region Személy
        private Szemely convert(string[] line)
        {
            Szemely szemely=new Szemely();
            szemely.nev = line[0];
            szemely.szido = Convert.ToDateTime(line[1]);
            szemely.neme = Convert.ToChar(line[2]);
            szemely.hajlam = Convert.ToInt32(line[3]);
            return szemely;
        }
        #endregion Személy
        #endregion Bolvasás
        #region Törlés
        public void delete(string nev)
        {
            this.list.Remove(this.list.Find(list => list.nev == nev));
        }
        #endregion Törlés
        #region Keresés
        public bool keres(string nev)
        {
            bool b = false;
            Szemely vane = new Szemely();
            vane=this.list.Find(list => list.nev == nev);
            if (vane.nev == nev)
            {
                b = true;
            }
            return b;
        }
        #endregion Keresés
        #region Kiiratás
        public void kiir()
        {
            using(StreamWriter sw=new StreamWriter(new FileStream(path+outfile, FileMode.Create, FileAccess.Write),Encoding.UTF8))
            {
                foreach (Szemely item in this.list)
                {
                    sw.WriteLine(item.nev,";" ,item.szido, ";", item.neme, ";", item.hajlam);
                }
            }
        }
        #endregion Kiiratás
        #endregion Metódusok

    }
}
