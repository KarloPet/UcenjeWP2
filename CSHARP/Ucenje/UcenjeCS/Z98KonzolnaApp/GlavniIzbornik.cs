using UcenjeCS.E15KonzolnaAplikacija;
using UcenjeCS.Z98KonzolnaApp.Cjenik;
using UcenjeCS.Z98KonzolnaApp.Gosti;
using UcenjeCS.Z98KonzolnaApp.Rezervacije;

namespace UcenjeCS.Z98KonzolnaApp
{
    internal class GlavniIzbornik
    {
        public static void Izbornik ()
        {
            Console.WriteLine("*****Izbornik*****");
            Console.WriteLine("1. Rad sa rezervacijama");
            Console.WriteLine("2. Rad sa cjenikom");
            Console.WriteLine("3. Izlaz iz programa");
            OdabirStavkePocetnogIzbornika();
        }

        private static void OdabirStavkePocetnogIzbornika()
        {
            RadSaCijenama radSaCijenama = RadSaCijenama.Instance;
            //var Izbor = Pomocno.UcitajInt("Unesi izbor: ");
            switch (Pomocno2.UcitajInt("Unesi izbor: "))

            {
                case 1:
                    Console.WriteLine("Rad sa rezervacijama");
                    RadSaRezervacijama.OdabranoRezervacija();
                    break;
                case 2:
                    Console.WriteLine("Rad sa cjenikom");
                    radSaCijenama.OdabranoCjenik();
                    break;
                case 3:
                    Console.WriteLine("Izlaz iz programa");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Krivi odabir");
                    Console.ResetColor();
                    Izbornik();
                    break;

            }
        }
    }
}