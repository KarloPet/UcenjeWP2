using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E12KlasaObjekt
{
    internal class Ljubav
    {
        public static void Izvedi()
        {
            //Console.Write("Unesi svoje ime: ");
            //string PrvoIme = Console.ReadLine();
            //Console.Write("Unesi ime svoje simpatije: ");
            //string DrugoIme = Console.ReadLine();

            //Console.WriteLine(SlovaUNiz(PrvoIme, DrugoIme));
        }

        public string PrvoIme { get; set; }
        public string DrugoIme { get; set; }

        // Ovo je konstruktor - 5. vrsta metoda
        public Ljubav()
        {
            // ovdje se dolazi kada se izvodi ključna riječ new
        }

        public Ljubav(string prvoIme, string drugoIme)
        {
            this.PrvoIme = prvoIme;
            this.DrugoIme = drugoIme;
        }

        //public string Rezultat()
        //{
        //    return Izracunaj(SlovaUNiz(PrvoIme + DrugoIme)) + " %";
        //}

        public int[] SlovaUNiz(string Ime1, string Ime2)
        {
            int[] Slova = new int[Ime1.Length + Ime2.Length];
            // fiksno
            return Slova;
        }

        private int Izracunaj(int[] Brojevi)
        {
            // ovo je sad fiksno, tu dolazi rekurzivni algoritam
            return 67;
        }

    }
}