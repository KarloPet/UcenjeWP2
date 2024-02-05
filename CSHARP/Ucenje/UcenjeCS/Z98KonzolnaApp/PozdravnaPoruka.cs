using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.Z98KonzolnaApp
{
    internal class PozdravnaPoruka
    {
        public static void Poruka()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("██████╗░░█████╗░░█████╗░██╗░░██╗██╗███╗░░██╗░██████╗░  ░█████╗░██████╗░██████╗░");
            Console.WriteLine("██╔══██╗██╔══██╗██╔══██╗██║░██╔╝██║████╗░██║██╔════╝░  ██╔══██╗██╔══██╗██╔══██╗");
            Console.WriteLine("██████╦╝██║░░██║██║░░██║█████═╝░██║██╔██╗██║██║░░██╗░  ███████║██████╔╝██████╔╝");
            Console.WriteLine("██╔══██╗██║░░██║██║░░██║██╔═██╗░██║██║╚████║██║░░╚██╗  ██╔══██║██╔═══╝░██╔═══╝░");
            Console.WriteLine("██████╦╝╚█████╔╝╚█████╔╝██║░╚██╗██║██║░╚███║╚██████╔╝  ██║░░██║██║░░░░░██║░░░░░");
            Console.WriteLine("╚═════╝░░╚════╝░░╚════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝░╚═════╝░  ╚═╝░░╚═╝╚═╝░░░░░╚═╝░░░░░");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*********************** BOOKING KONZOLNA APLIKACIJA V1 ************************");
            Console.WriteLine("***********************     MADE BY: Karlo Peterfaj    ************************");
            Console.WriteLine("*******************************************************************************");
            Console.ResetColor();


            GlavniIzbornik.Izbornik();

        }
    }
}
