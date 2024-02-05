using System;
using System.Collections.Generic;

namespace UcenjeCS.Z98KonzolnaApp.Cjenik
{
    internal class RadSaCijenama
    {
        private static RadSaCijenama instance = new RadSaCijenama();
        public List<Cjenik> Cjenici;

        public RadSaCijenama()
        {
            Cjenici = GenerirajCjenikeOd1Do9Lipnja();
        }

        public static RadSaCijenama Instance
        {
            get { return instance; }
        }

        public List<Cjenik> GenerirajCjenikeOd1Do9Lipnja()
        {
            List<Cjenik> cjenici = new List<Cjenik>();
            DateTime pocetniDatum = new DateTime(2024, 1, 1);
            DateTime krajnjiDatum = new DateTime(2024, 12, 31);

            // Generiranje cjenika za svaki dan od 1.6. do 1.9.
            for (DateTime datum = pocetniDatum; datum < krajnjiDatum; datum = datum.AddDays(1))
            {
                cjenici.Add(new Cjenik
                {
                    id = cjenici.Count + 1, // Automatski dodijeli ID
                    datum = datum,
                    cijena = OdrediCijenuZaDatum(datum)
                });
            }

            return cjenici;
        }

        private decimal OdrediCijenuZaDatum(DateTime datum)
        {
            int day = datum.Day;
            int month = datum.Month;
            if (month == 6)
            {
                if (day <= 15)
                {
                    return 50;
                }
                else
                {
                    return 75;
                }
            }
            else if (month == 7)
            {
                if (day <= 15)
                {
                    return 85;
                }
                else
                {
                    return 90;
                }
            }
            else if (month == 8)
            {
                return 120;
            }
            else if (month == 9)
            {
                if (day <= 15)
                {
                    return 75;
                }
                else
                {
                    return 60;
                }
            }
            return 35;
        }

        public void OdabranoCjenik()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("1. Pregledaj cijene po danima");
            Console.WriteLine("2. Vrati na prethodnu stranicu");

            OdabirOpcijaCjenika();
        }

        public void OdabirOpcijaCjenika()
        {
            Console.WriteLine("*******************************");
            switch (Pomocno2.UcitajInt("Unesi izbor: "))
            {
                case 1:
                    Console.WriteLine("*****Cijene po danima*****");
                    PopisCjenika();
                    break;
                case 2:
                    Console.WriteLine("*****Glavni izbornik*****");
                    GlavniIzbornik.Izbornik();
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Krivi odabir");
                    Console.ResetColor();
                    OdabranoCjenik();
                    break;
            }
        }

        public void DodajNovuCijenu()
        {
            Cjenici.Add(new Cjenik()
            {
                id = Pomocno2.UcitajInt("Unesi id: "),
                datum = Pomocno2.UcitajDateTime("Unesi datum: "),
                cijena = Pomocno2.UcitajDecimal("Unesi cijenu u eur: ")
            });

            Console.WriteLine("**********************************");
            OdabranoCjenik();
        }

        public void PopisCjenika()
        {
            int i = 1;
            foreach (var cjenik in Cjenici)
            {
                Console.WriteLine($"{i}. Id: {cjenik.id}, Datum: {cjenik.datum}, Cijena: {cjenik.cijena}");
                i++;
            }
            Console.WriteLine("**********************************");
            OdabranoCjenik();
        }

        public void IzbrisiCijenu()
        {
            PopisCjenika();
            Cjenici.RemoveAt(Pomocno2.UcitajInt("Odaberi stavku koju zelis obrisati: ") - 1);
            OdabranoCjenik();
        }
    }
}
