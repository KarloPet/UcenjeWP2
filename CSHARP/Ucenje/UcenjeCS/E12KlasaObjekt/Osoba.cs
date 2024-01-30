using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E12KlasaObjekt
{
    //klasa je opisnik objekta - NAUCITI NAPAMET!!!!!!!!

    internal class Osoba
    {
        //svojstva koja opisuju klasu
        public string? Ime { get; set; }
        public string Prezime { get; set; }
        public Grad Grad { get; set; }

        public string ImePrezime()
        {
            return Ime + " " + Prezime; //ovo moze bolje
        }
    }
}
