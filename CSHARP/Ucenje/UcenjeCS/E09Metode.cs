using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E09Metode
    {
        public static void Izvedi()
        {
            Tip1();
            Tip2(3, 23);
            var Ime = ImeRacunala();
            Console.WriteLine(Ime);
            Console.WriteLine(ImeRacunala());

            Console.WriteLine(IsPrimBroj(7) ? "PRIM" : "NIJE");

            SviPrimBrojevi(27, 99);
        }

        private static void SviPrimBrojevi(int Od, int Do)
        {
            for (int i = Od;i<=Do;i++)
            {
                if (IsPrimBroj(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Tip1()
        {
            Console.WriteLine("Hello iz tip 1");
        }
    

        static void Tip2(int Od, int Do)
        {
            for (int i = Od; i <= Do; i++)
            {
                if (i%2!=0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        static string ImeRacunala()
        {
            return System.Net.Dns.GetHostName();
        }

        static bool IsPrimBroj(int Broj)
        {


            for (int i = 2; i <= Broj; i++)
            {
                if (Broj % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


    }
}
