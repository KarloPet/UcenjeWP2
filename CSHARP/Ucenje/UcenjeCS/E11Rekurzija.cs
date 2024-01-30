using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E11Rekurzija
    {
        public static void Izvedi()
        {
            //Izvedi();

            Console.WriteLine(Zbroj(100));
        }

        private static int Zbroj(int v)
        {
            if (v == 1)
            {
                return 1;
            }
            return v + Zbroj(v - 1);
        }
    }
}
