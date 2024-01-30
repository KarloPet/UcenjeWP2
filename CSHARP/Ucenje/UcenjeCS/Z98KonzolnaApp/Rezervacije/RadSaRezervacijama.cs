using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using UcenjeCS.Z98KonzolnaApp.Gosti;

namespace UcenjeCS.Z98KonzolnaApp.Rezervacije
{
    internal class RadSaRezervacijama
    {
        private static RadSaRezervacijama instance = new RadSaRezervacijama();
        private List<Rezervacije> Rezervacija;

        private RadSaRezervacijama()
        {
            Rezervacija = new List<Rezervacije>();
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
                    Console.WriteLine("*****Krivi odabir*****");
                    OdabranoRezervacija();
                    break;
            }
        }

        public void DodajNovuRezervaciju()
        {
            Rezervacija.Add(new Rezervacije()
            {
                id = Pomocno2.UcitajInt("Unesi id rezervacije: "),
                cijena = Pomocno2.UcitajDecimal("Unesi cijenu: "),
                datum_od = Pomocno2.UcitajDateTime("Unesi pocetni datum rezervacije: "),
                datum_do = Pomocno2.UcitajDateTime("Unesi zavrsni datum rzervacije: ")
            }); ;
            Console.WriteLine("**********************************");
            OdabranoRezervacija();
        }

        public void PogledajRezervacije()
        {
            int i = 1;
            foreach (var rezervacija in Rezervacija)
            {
                Console.WriteLine(i + ". " + "Id: " + rezervacija.id + ", Cijena: " + rezervacija.cijena + ", Datum od: " + rezervacija.datum_od + ", Datum do: " + rezervacija.datum_do);
                i++;
            }
            Console.WriteLine("**********************************");
        }
        public void IzbrisiRezervaciju()
        {
            PogledajRezervacije();
            Rezervacija.RemoveAt(Pomocno2.UcitajInt("Odaberi rezervaciju koju zelis obrisati: ") - 1);
            RadSaRezervacijama.OdabranoRezervacija();
        }
    }
}
