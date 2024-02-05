using System;

namespace UcenjeCS.Z98KonzolnaApp
{
    internal class Pomocno2
    {
        public static int UcitajInt(string poruka)
        {
            for (; ; )
            {
                Console.Write(poruka);
                try
                {
                    return int.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Neispravan unos");
                    Console.ResetColor();

                }
            }
        }

        public static decimal UcitajDecimal(string poruka)
        {
            for (; ; )
            {
                Console.Write(poruka);
                try
                {
                    return decimal.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }
        }

        public static string UcitajString(string poruka)
        {
            string s;
            while (true)
            {
                Console.Write(poruka);
                s = Console.ReadLine();
                if (s.Trim().Length == 0)
                {
                    Console.WriteLine("Obavezan unos");
                    continue;
                }
                return s;
            }
        }

        public static DateTime UcitajDateTime(string poruka)
        {
            for (; ; )
            {
                Console.Write(poruka);
                try
                {
                    return DateTime.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }
        }
    }
}
