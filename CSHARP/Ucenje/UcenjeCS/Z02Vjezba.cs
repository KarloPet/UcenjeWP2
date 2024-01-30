using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

// Program učitava brojeve sve dok se ne unese
// broj -1
//Program ispisuje:
// 1. Zbroj unesenih brojeva
// 2. Namjanji broj
// 3. Najveći broj
// 4. Prosjek svih unesenih brojeva

// KORISTITI METODE I OBRADU IZNIMKI

namespace UcenjeCS
{
    internal class Z02Vjezba
    {
        public static void Izvedi()
        {
            try
            {
                IzracunajStatistiku();
            }
            //catch (ExceptionFormat ex)
            //{
            //    Console.WriteLine($"Nepredviđena greška: {ex.Message}");
            //}
            catch (Exception ex)
            {
                Console.WriteLine($"Nepredviđena greška: {ex.Message}");
            }
        }
        private static void IzracunajStatistiku()
        {
            int Zbroj = 0;
            int Najmanji = int.MaxValue;
            int Najveci = int.MinValue;
            int Brojac = 0;

            while (true)
            {
                Console.Write("Unesite broj (za prekid unesite -1): ");
                string Unos = Console.ReadLine();
                if (Unos == "-1")
                    break;

                int Broj = Convert.ToInt32(Unos);

                Zbroj += Broj;
                Brojac++;

                Najmanji = Math.Min(Najmanji, Broj);
                Najveci = Math.Max(Najveci, Broj);
            }
            if (Brojac > 0)
            {
                double Prosjek = (double)Zbroj / Brojac;

                Console.WriteLine($"Zbroj unesenih brojeva: {Zbroj}");
                Console.WriteLine($"Najmanji broj: {Najmanji}");
                Console.WriteLine($"Najveći broj: {Najveci}");
                Console.WriteLine($"Prosjek svih unesenih brojeva: {Prosjek}");
            }
            else
            {
                Console.WriteLine("Niste unijeli nijedan broj.");
            }
        }
    }
}
