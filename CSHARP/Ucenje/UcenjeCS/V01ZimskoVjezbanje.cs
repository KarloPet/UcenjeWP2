using System;

namespace UcenjeCS
{
    internal class V01ZimskoVjezbanje
    {
        public static void Izvedi()
        {
            //////////
            Console.WriteLine(" ");
            Console.WriteLine("****************************** zadatak 1");


            for (int broj = 0; broj <= 99; broj++)
            {
                Console.Write(broj+1 + " ");
            }

        Console.WriteLine(" ");
        Console.WriteLine("****************************** zadatak 2");
            //////////zad2

            for (int broj = 99;broj >= 0; broj--)
            {
                Console.Write(broj+1 + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("****************************** zadatak 3");
            //////////zad3
            
            for (int i = 1; i<=100;i++)
            {
                if (i%7 ==0)
                {
                    Console.Write(i+ " ");
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("****************************** zadatak 4");
            //////////zad4
            int brojacPokusaja = 0;

            for (int i=1;i<=100;i++)
            {
                brojacPokusaja++;
            }
            Console.WriteLine("Brojanje je završeno, ukupno pokušaja unosa: " + brojacPokusaja);


            Console.WriteLine("******************************");





        }
    }
}
