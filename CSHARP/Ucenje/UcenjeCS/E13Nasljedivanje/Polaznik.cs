using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13Nasljedivanje
{
    internal class Polaznik:Osoba //klasa polaznik nasljeduje sva javna i zasticena svojstva iz klase osoba
    {
        private int Vidim;
        public string BrojUgovora { get; set; }

        public Polaznik():base()//ovo i ne treba eksplicitno navesti
        {
            Console.WriteLine("Konstruktor polaznika");
        }

        public Polaznik(int sifra, string ime, string prezime, string oib,string email, string brojugovora)
            :base(sifra, ime, prezime, oib, email)
        {
            BrojUgovora = brojugovora;
        }

        public override string ToString()
        {
            return new StringBuilder(base.ToString()).Append(',').Append(BrojUgovora).ToString();
        }




        public void ProvjeraVidljivosti()
        {
            Vidim = 2;//ovo je u mojoj klasi
            base.Sifra = 2;
            base.Vidim = 7;//ovo je u mojoj klasi
            this.Vidim = 8;//ovo je u mojoj klasi
            //NeVidim se ne vidi
        }
    }
}
