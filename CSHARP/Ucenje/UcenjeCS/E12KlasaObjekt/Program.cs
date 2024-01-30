using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E12KlasaObjekt
{
    internal class Program
    {
        public static void Izvedi()
        {
            //Console.Write("Unesi svoje ime: ");
            //string PrvoIme = Console.ReadLine();
            //Console.Write("Unesi ime svoje simpatije: ");
            //string DrugoIme = Console.ReadLine();

            //Console.WriteLine(SlovaUNiz(PrvoIme, DrugoIme));
        }
    }
}

//        public static void Izvedi()
//        {

//            Osoba o = new Osoba();
//            Grad g = new()
//            {
//                Naziv = "Osijek",
//                BrojStanovnika = 100000
//            };

//            o.Grad = g;

//            Console.WriteLine(o.Grad.Naziv);

//        }
//        private static void E04LjubavniPoziv()
//        {
//            Ljubav ljubav = new();
//            // Console.Write("Unesi ime prve osobe: ");
//            //ljubav.PrvoIme = Console.ReadLine();
//            ljubav.PrvoIme = unos("Unesi ime prve osobe: ");
//            ljubav.DrugoIme = unos("Unesi ime druge osobe: ");

//            Console.WriteLine(ljubav.Rezultat());

//            Console.WriteLine(new Ljubav(unos("PI"), unos("DI")).Rezultat());
//        }
//        private static string unos(string poruka)
//        {
//            string unos;
//            while (true)
//            {
//                Console.WriteLine(poruka);
//                unos = Console.ReadLine();
//                if (unos.Trim().Length == 0)
//                {
//                    Console.WriteLine("unos je obavezan");
//                    continue;
//                }
//                return unos;
//            }
//        }

//        private static void E03Najcesce()
//        {
//            //najcesci nacin deklaracije
//            Osoba osoba = new();

//            var pjevac = new Osoba();

//            //pjevac.Ime = "Mirko";
//            Console.WriteLine(pjevac.Ime?.Substring(0, 1));

//        }
//        private static void E02DrugaSintaksa()
//        {
//            Osoba o = new Osoba
//            {
//                Ime = Console.ReadLine(),
//                Prezime = Console.ReadLine()
//            };

//            Console.WriteLine(o.ImePrezime());
//        }

//        private static void E01OsnovnaSintaksa()
//        {
//            //objekt je pojavnost (instanca) klase
//            Osoba osoba = new Osoba();

//            osoba.Ime = "Pero";
//            osoba.Prezime = "Perić";

//            Console.WriteLine(osoba.Ime);
//        }

//    }
//}
