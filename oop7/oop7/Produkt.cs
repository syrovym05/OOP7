using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop7
{
    internal class Produkt : Zbozi
    {
        bool lzezlevnit;

        public Produkt(string nazev, int cena, DateTime datumvyroby, int minimalnitrvanlivost, bool lzezlevnit) : base(nazev, cena,datumvyroby, minimalnitrvanlivost)
        {
            this.lzezlevnit = lzezlevnit;
        }

        public override double CenasDPH()
        {
            if (SplnujeMinTrvanlivost() == false && lzezlevnit == true ) return base.CenasDPH() * 0.6;
            else return base.CenasDPH();
        }
        

    }
}
