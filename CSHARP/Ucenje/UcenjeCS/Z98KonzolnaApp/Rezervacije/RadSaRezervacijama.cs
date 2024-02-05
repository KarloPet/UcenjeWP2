using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using UcenjeCS.Z98KonzolnaApp.Cjenik;
using UcenjeCS.Z98KonzolnaApp.Gosti;

namespace UcenjeCS.Z98KonzolnaApp.Rezervacije
{

    internal class RadSaRezervacijama
    {
        private RadSaCijenama radSaCijenama = RadSaCijenama.Instance;
        private static RadSaRezervacijama instance = new RadSaRezervacijama();
        private List<Rezervacije> Rezervacije;
        private List<Gosti.Gosti> Gost;
        //private UnosGostiju unosGostiju;
        private RadSaRezervacijama()
        {
            Rezervacije = new List<Rezervacije>();
            Gost = new List<Gosti.Gosti>();
        }

        public static void OdabranoRezervacija()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("1. Pregledaj popis rezervacija");
            Console.WriteLine("2. Unesi rezervaciju");
            Console.WriteLine("3. Izbriši rezervaciju");
            Console.WriteLine("4. Vrati na predhodnu stranicu");

            instance.OdabirOpcijaRezervacija();
        }

        public void OdabirOpcijaRezervacija()
        {
            Console.WriteLine("*******************************");
            switch (Pomocno2.UcitajInt("Unesi izbor: "))
            {
                case 1:
                    Console.WriteLine("*****Popis rezervacija*****");
                    PogledajRezervacije();
                    break;
                case 2:
                    Console.WriteLine("*****Unesi rezervaciju*****");
                    DodajNovuRezervaciju();
                    break;
                case 3:
                    Console.WriteLine("*****Izbriši rezervaciju*****");
                    IzbrisiRezervaciju();
                    break;
                case 4:
                    GlavniIzbornik.Izbornik();
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Krivi odabir");
                    Console.ResetColor();
                    OdabranoRezervacija();
                    break;
            }
        }


        public void DodajNovuRezervaciju()
        {
            int BrojGostiju = Pomocno2.UcitajInt("Unesi broj Gostiju na rezervaciji: ");
            Rezervacije novaRezervacija = new Rezervacije();
            novaRezervacija.Gosti = new List<Gosti.Gosti>(); // Inicijalizacija liste gostiju za novu rezervaciju

            for (int i = 0; i < BrojGostiju; i++)
            {
                Gosti.Gosti gost = new Gosti.Gosti();
                bool ispravanOIB = false;

                    gost.ime = Pomocno2.UcitajString("Unesi ime gosta: ");
                    gost.prezime = Pomocno2.UcitajString("Unesi prezime gosta: ");

                while (!ispravanOIB)
                {
                    gost.oib = Pomocno2.UcitajString("Unesi OIB gosta: ");

                    // Provjera ispravnosti OIB-a
                    if (!ProvjeriOIB(gost.oib))
                    {
                        Console.WriteLine("Neispravan OIB. Molimo unesite ispravan OIB.");
                    }
                    else
                    {
                        ispravanOIB = true;
                    }
                }


                novaRezervacija.Gosti.Add(gost);
            }

            novaRezervacija.datum_od = Pomocno2.UcitajDateTime("Unesi pocetni datum rezervacije: ");
            novaRezervacija.datum_do = Pomocno2.UcitajDateTime("Unesi zavrsni datum rezervacije: ");

            Rezervacije.Add(novaRezervacija);

            Console.WriteLine("**********************************");
            OdabranoRezervacija();
        }

        public void PogledajRezervacije()
        {
            int i = 1;
            foreach (var rezervacija in Rezervacije)
            {
                decimal ukupnaCijena = IzracunajUkupnuCijenuRezervacije(rezervacija);
                Console.WriteLine(i + ". ID rezervacije: " + rezervacija.id + ", Cijena: " + ukupnaCijena + ", Datum od: " + rezervacija.datum_od + ", Datum do: " + rezervacija.datum_do);

                int y = 1;
                foreach (var gost in rezervacija.Gosti)
                {
                    Console.WriteLine(y + ". ID gosta: " + gost.id + ", Ime: " + gost.ime + ", Prezime: " + gost.prezime + ", OIB: " + gost.oib);
                    y++;
                }

                i++;
            }
            Console.WriteLine("**********************************");
        }

        public decimal IzracunajUkupnuCijenuRezervacije(Rezervacije rezervacija)
        {
            decimal ukupnaCijena = 0;
            DateTime datumOd = rezervacija.datum_od;
            DateTime datumDo = rezervacija.datum_do;

            foreach (var cjenik in radSaCijenama.Cjenici)
            {
                // Provjeravamo je li trenutni datum cjenika unutar raspona datuma rezervacije
                if (cjenik.datum >= datumOd && cjenik.datum <= datumDo)
                {
                    ukupnaCijena += cjenik.cijena;
                }
            }

            return ukupnaCijena;
        }

        public void IzbrisiRezervaciju()
        {
            PogledajRezervacije(); // Prikazuje popis rezervacija radi odabira koju rezervaciju želite obrisati
            int odabranaRezervacijaIndex = Pomocno2.UcitajInt("Odaberi redni broj rezervacije koju želiš obrisati: ") - 1;

            if (odabranaRezervacijaIndex >= 0 && odabranaRezervacijaIndex < Rezervacije.Count)
            {
                // Dohvaćanje rezervacije koju želimo obrisati
                Rezervacije rezervacijaZaBrisanje = Rezervacije[odabranaRezervacijaIndex];

                // Brisanje svih gostiju koji se nalaze u rezervaciji
                foreach (var gost in rezervacijaZaBrisanje.Gosti.ToList())
                {
                    rezervacijaZaBrisanje.Gosti.Remove(gost);
                }

                // Brisanje same rezervacije
                Rezervacije.RemoveAt(odabranaRezervacijaIndex);
                Console.WriteLine("Rezervacija i gosti uspješno obrisani.");
            }
            else
            {
                Console.WriteLine("Pogrešan odabir rezervacije.");
            }
            OdabranoRezervacija();
        }
        public bool ProvjeriOIB(string oib)
        {
            if (oib.Length != 11)
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("OIB mora imati 11 znamenki.");
                return false;
            }

            long b;
            if (!long.TryParse(oib, out b))
            {
                Console.WriteLine("**********************************");

                Console.WriteLine("OIB mora sadržavati samo brojeve.");
                return false;
            }

            int a = 10;
            for (int i = 0; i < 10; i++)
            {
                a = a + int.Parse(oib.Substring(i, 1));
                a = a % 10;
                if (a == 0)
                {
                    a = 10;
                }
                a *= 2;
                a = a % 11;
            }

            int kontrolniBroj = 11 - a;
            if (kontrolniBroj == 10) kontrolniBroj = 0;

            return kontrolniBroj == int.Parse(oib.Substring(10, 1));
        }

    }
}
