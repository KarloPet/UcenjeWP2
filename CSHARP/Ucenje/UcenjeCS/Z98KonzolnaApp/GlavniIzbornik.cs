using UcenjeCS.E15KonzolnaAplikacija;
using UcenjeCS.Z98KonzolnaApp.Gosti;
using UcenjeCS.Z98KonzolnaApp.Rezervacije;

namespace UcenjeCS.Z98KonzolnaApp
{
    internal class GlavniIzbornik
    {
        public static void Izbornik ()
        {
            Console.WriteLine("*****Izbornik*****");
            Console.WriteLine("1. Rad sa gostima");
            Console.WriteLine("2. Rad sa rezervacijama");
            Console.WriteLine("3. Rad sa cjenikom");
            Console.WriteLine("4. Izlaz iz programa");
            OdabirStavkePocetnogIzbornika();
        }

        private static void OdabirStavkePocetnogIzbornika()
        {
            //var Izbor = Pomocno.UcitajInt("Unesi izbor: ");
            switch (Pomocno2.UcitajInt("Unesi izbor: "))
            {
                case 1:
                    Console.WriteLine("*****Rad sa gostima*****");
                    RadSaGostima.Odabrano();
                    break;
                case 2:
                    Console.WriteLine("Rad sa rezervacijama");
                    RadSaRezervacijama.OdabranoRezervacija();
                    break;
                case 3:
                    Console.WriteLine("Rad sa cjenikom");
                    break;
                case 4:
                    Console.WriteLine("Izlaz iz programa");
                    break;
                default:
                    Console.WriteLine("Krivi odabir");
                    Izbornik();
                    break;

            }
        }
    }
}