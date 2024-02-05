using UcenjeCS.Z98KonzolnaApp.Gosti;

namespace UcenjeCS.Z98KonzolnaApp.Gosti
{
    public class UnosGostiju
    {
        public List<Gosti> Gost;

        public UnosGostiju()
        {
            Gost = new List<Gosti>();
        }
        public void DodajNovogGosta()
        {
            Gost.Add(new Gosti()
            {
                //id = Pomocno2.UcitajInt("Unesi id gosta: "),
                ime = Pomocno2.UcitajString("Unesi ime gosta: "),
                prezime = Pomocno2.UcitajString("Unesi prezime gosta: "),
                oib = Pomocno2.UcitajString("Unesi OIB gosta: ")
            });
        }
        public void PogledajGoste()
        {

            int i = 1;
            foreach (var gost in Gost)
            {
                Console.WriteLine(i + ". " + "Id: " + gost.id + ", Ime: " + gost.ime + ", Prezime: " + gost.prezime + ", OIB: " + gost.oib);
                i++;
            }
            Console.WriteLine("**********************************");
        }
        public void IzbrisiGosta()
        {
            PogledajGoste();
            Gost.RemoveAt(Pomocno2.UcitajInt("Odaberi gosta kojeg zelis obrisati: ") - 1);
            RadSaGostima.Odabrano();
        }
    }
}
