using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop7
{
    internal class Zbozi
    {
        string nazev;
        int cena;
        DateTime datumvyroby;
        int minimalnitrvanlivost;

        public Zbozi(string nazev, int cena, DateTime datumvyroby, int minimalnitrvanlivost)
        {
            this.nazev = nazev;
            this.cena = cena;
            this.datumvyroby = datumvyroby;
            this.minimalnitrvanlivost = minimalnitrvanlivost;
        }   
        
        public bool SplnujeMinTrvanlivost()
        {
            if ((DateTime.Today - datumvyroby).TotalDays < minimalnitrvanlivost) return true;
            else return false;
        }   

        public virtual double CenasDPH()
        {
            return cena * 1.21;
        }

        public override string ToString()
        {
            return String.Format("{0}\nDatum výroby: {1}\nMin. trvanlivost: {2} dni\nCena: {3} Kc\nCena s DPH: {4}Kc\n\nZbozi {5} prosle",
                nazev,datumvyroby,minimalnitrvanlivost, cena,CenasDPH(), SplnujeMinTrvanlivost() ? "neni" : "je");
        }
    }
}
