using UcenjeCS.Z98KonzolnaApp;
using UcenjeCS.Z98KonzolnaApp.Gosti;

namespace UcenjeCS.Z98KonzolnaApp.Gosti
{
    internal class RadSaGostima
    {
        private static UnosGostiju unosGostiju = new UnosGostiju();
        public static void Odabrano()
        {
            Console.WriteLine("1. Pregledaj popis gostiju");
            Console.WriteLine("2. Unesi gosta");
            Console.WriteLine("3. Izbriši gosta");
            Console.WriteLine("4. Vrati na predhodnu stranicu");

            OdabirOpcijaGosta();
        }
        public static void OdabirOpcijaGosta()
        {
            switch (Pomocno2.UcitajInt("Unesi izbor: "))
            {
                case 1:
                    Console.WriteLine("*****Popis gostiju*****");
                    unosGostiju.PogledajGoste();
                    break;
                case 2:
                    Console.WriteLine("*****Unesi gosta*****");
                    unosGostiju.DodajNovogGosta();
                    break;
                case 3:
                    Console.WriteLine("*****Izbriši gosta*****");
                    unosGostiju.IzbrisiGosta();
                    break;
                case 4:
                    GlavniIzbornik.Izbornik();
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Krivi odabir");
                    Console.ResetColor();
                    Odabrano();
                    break;

            }
        }
    }
}