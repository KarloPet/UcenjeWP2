using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13Nasljedivanje
{
    internal class Program
    {
        public static void Izvedi()
        {
            var p = new Polaznik()
            {
                Sifra = 1,
                Ime = "Pero",
                Prezime = "Perić",
                BrojUgovora="2/2024"
            };



            Console.WriteLine(p.Sifra);

            var pr1 = new Predavac();
            pr1.Ime = "Mario";

            var pr2 = new Predavac();
            pr2.Ime = "Mario";

            Console.WriteLine((pr1==pr2) + ", " + pr1.GetHashCode() + " == " + pr2.GetHashCode());


            string a = "Osijek";
            Console.WriteLine("a na pocetku " + a.GetHashCode());
            a += " je super";
            Console.WriteLine("a nekon promjene " + a.GetHashCode());

            Console.WriteLine("pr1 na pocetku: " + pr1.GetHashCode());
            pr1.Prezime = "Perić";

            Console.WriteLine("pr1 nakon promjene: " + pr1.GetHashCode());

            //StringBuilder sb= new StringBuilder();
            //sb.AppendLine("Osijek");
            //Console.WriteLine("sb na pocetku " + sb.GetHashCode());
            //sb += " je super";
            //Console.WriteLine("a nekon promjene " + a.GetHashCode());

            Console.WriteLine(pr1);
            Console.WriteLine(p);


        }
    }
}
