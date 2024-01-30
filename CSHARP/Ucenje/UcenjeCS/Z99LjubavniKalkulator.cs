using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using UcenjeCS.E12KlasaObjekt;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UcenjeCS
{
    internal class Z99LjubavniKalkulator
    {


        //        try
        //        {
        //            Izracun();
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine($"Došlo je do pogreške pri izvođenu programa: {e}");
        //        }
        //    }
        //public static void Izracun() 
        //{
        //    Console.Write("Unesite svoje ime: ");
        //    string Ime1 = Console.ReadLine().ToLower();
        //    Console.Write("Unesite ime svoje simpatije: ");
        //    string Ime2 = Console.ReadLine().ToLower();

        //    string UkupniUnos = Ime1 + Ime2;
        //    int[] Slova = new int[Ime1.Length + Ime2.Length];
        //    int Index = 0;
        //    int Ukupno;

        //    Ukupno = 0;
        //    foreach (char c in UkupniUnos)
        //    {
        //        if (c == c)
        //        {
        //            Ukupno++;
        //        }
        //    }
        //    Slova[Index++] = Ukupno;

        //    Console.WriteLine(string.Join(",", Slova));

        //    char[] JedinstvenaSlova = new char[UkupniUnos.Length]; // ne treba mi toliko prostora, njaveći nedostatak nizova je taj što se na početku mora reći koliko ima elemenata
        //    bool Postoji;
        //    Index = 0;
        //    foreach (char c in UkupniUnos)
        //    {
        //        Postoji = false;
        //        foreach (char cc in JedinstvenaSlova)
        //        {
        //            if (c == cc)
        //            {
        //                Postoji = true;
        //                break;
        //            }
        //        }
        //        if (!Postoji)
        //        {
        //            JedinstvenaSlova[Index++] = c;
        //        }
        //        Console.WriteLine(string.Join(",", JedinstvenaSlova));

        //        foreach (char d in JedinstvenaSlova)
        //        {
        //            Console.Write(c + " ");
        //            Index = 0;

        //            foreach (char cc in UkupniUnos)
        //            {
        //                if (c == cc)
        //                {
        //                    Console.WriteLine(Slova[Index]);
        //                    break;
        //                }
        //                Index++;
        //            }
        //        }

        //}
        //    }
    }

    }
    //    public static void Izvedi()
    //    {
    //        try
    //        {
    //            Izracun();
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine($"Došlo je do pogreške: {e}");
    //        }
    //    }
    //    private static bool SadrziLiListaSlovo(char Slovo, char[] Lista)
    //    {
    //        foreach (char c in Lista)
    //        {
    //            if (c == Slovo)
    //            {
    //                return true;
    //            }
    //        }
    //        return false;
    //    }
    //    private static int StvarnaDuljinaCharListe(char[] Lista)
    //    {
    //        int index = 0;
    //        foreach (char c in Lista)
    //        {
    //            if (c == (char)0)
    //            {
    //                return index;
    //            } else
    //            {
    //                index++;
    //            }
    //        }
    //        return index;
    //    }

    //    private static int IndexSlova(char c, char[] Lista)
    //    {
    //        int index = 0;
    //        foreach (char s in Lista)
    //        {
    //            if (s == c)
    //            {
    //                return index;
    //            }
    //            else
    //            {
    //                index++;
    //            }
    //        }
    //        return index;
    //    }


    //    static void Izracun()
    //    {
    //        Console.Write("Unesite svoje ime: ");
    //        string Ime1 = Console.ReadLine().ToLower();
    //        Console.Write("Unesite ime svoje simpatije: ");
    //        string Ime2 = Console.ReadLine().ToLower();

    //        char[] JedinstvenaSlova = new char[Ime1.Length + Ime2.Length];
    //        int[] BrojPonavljanja = new int[Ime1.Length + Ime2.Length];

    //        foreach(char c in Ime1+Ime2)
    //        {
    //            if (SadrziLiListaSlovo (c, JedinstvenaSlova)) 
    //            {
    //                  int i = IndexSlova(c, JedinstvenaSlova);
    //                BrojPonavljanja[i] += 1;

    //            } else
    //            {
    //                int index = StvarnaDuljinaCharListe(JedinstvenaSlova);
    //                JedinstvenaSlova[index] = c;
    //                BrojPonavljanja[index] = 1;
    //            } 
    //        }
    //        Console.WriteLine(JedinstvenaSlova);
    //        Console.WriteLine(System.String.Join(", ", BrojPonavljanja));
    //    }
    //    }
    //}
