using System;
using System.Collections.Generic;

namespace UcenjeCS
{
    internal class Z99LjubavniKalkulator
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesi svoje ime: ");
            string Ime11 = Console.ReadLine();
            while (!ProvjeriLegitimnoIme(Ime11))
            {
                Console.WriteLine("Ponovno unesi svoje ime: ");
                Ime11 = Console.ReadLine();
            }

            Console.WriteLine("Unesi ime svoje simpatije");
            string Ime22 = Console.ReadLine();
            while (!ProvjeriLegitimnoIme(Ime22))
            {
                Console.WriteLine("Ponovno unesi ime svoje simpatije: ");
                Ime22 = Console.ReadLine();
            }

            ConsoleSpiner spin = new ConsoleSpiner();
            Console.WriteLine("Izračunavam postotak ljubavi....");
            DateTime startTime = DateTime.Now;
            while (DateTime.Now - startTime < TimeSpan.FromSeconds(3))
            {
                spin.Turn();
                Thread.Sleep(100);
            }
            Console.WriteLine("");


            string Ime1 = Ime11.ToLower();
            string Ime2 = Ime22.ToLower();
            string Unos = Ime1 + Ime2;

            int[] Slova = new int[Ime1.Length + Ime2.Length];
            int index = 0;
            int ukupno;
            foreach (char c in Unos)
            {
                ukupno = 0;
                foreach (char cc in Unos)
                {
                    if (c == cc)
                    {
                        ukupno++;
                    }
                }
                Slova[index++] = ukupno;
            }

            Console.WriteLine(string.Join(" ", Slova));
            List<int> listaZbrojeva = ZbrojiNiz(Slova);
            Console.WriteLine(string.Join(" ", listaZbrojeva));
            while (listaZbrojeva.Count > 2)
            {
                listaZbrojeva = ZbrojiNiz(listaZbrojeva.ToArray());
                Console.WriteLine(string.Join(" ", listaZbrojeva));          
            }
            Console.WriteLine("");
            Console.WriteLine("Ti " + Ime11 + " i tvoja simpatija " + Ime22 + " se volite: " + listaZbrojeva[0] + listaZbrojeva[1] + "%");
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("  ***   ***");
            Console.WriteLine(" ***** *****");
            Console.WriteLine("*************");
            Console.WriteLine(" *********** ");
            Console.WriteLine("  *********  ");
            Console.WriteLine("   *******   ");
            Console.WriteLine("    *****    ");
            Console.WriteLine("     ***     ");
            Console.WriteLine("      *      ");
            Console.ResetColor();



        }

        public static bool ProvjeriLegitimnoIme(string ime)
        {
            // Provjera je li ime prazno
            if (string.IsNullOrWhiteSpace(ime))
            {
                Console.WriteLine("Ime ne smije biti prazno.");
                return false;
            }

            // Provjera sadrži li ime brojeve ili znakove
            foreach (char c in ime)
            {
                if (char.IsDigit(c) || char.IsSymbol(c) || char.IsPunctuation(c))
                {
                    Console.WriteLine("Ime ne smije sadržavati brojeve, znakove ili interpunkcije.");
                    return false;
                }
            }

            return true;
        }

public class ConsoleSpiner
{
    int counter;
    public ConsoleSpiner()
    {
        counter = 0;
    }
    public void Turn()
    {
        counter++;        
        switch (counter % 4)
        {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow; // Boja za <
                        Console.Write("<");
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green; // Boja za ^
                        Console.Write("^");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue; // Boja za >
                        Console.Write(">");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Magenta; // Boja za v
                        Console.Write("v");
                        break;
                }
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Console.ResetColor();
            }
}

    static int ProvjeriDuljinuListe(List<int> lista)
        {
            return lista.Count;
        }

        static List<int> ZbrojiNiz(int[] niz)
        {
            List<int> listaZbrojeva = new List<int>();

            int pocetak = 0;
            int kraj = niz.Length - 1;

            while (pocetak <= kraj)
            {
                int zbroj = niz[pocetak] + niz[kraj];

                if (zbroj >= 10)
                {
                    listaZbrojeva.Add(zbroj / 10);
                    listaZbrojeva.Add(zbroj % 10);
                }
                else
                {
                    listaZbrojeva.Add(zbroj);
                }

                pocetak++;
                kraj--;

                if (pocetak == kraj)
                {
                    listaZbrojeva.Add(niz[pocetak]);
                    break;
                }
            }

            return listaZbrojeva;
        }
    }
}
