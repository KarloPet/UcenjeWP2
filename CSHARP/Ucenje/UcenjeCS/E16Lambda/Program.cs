using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace UcenjeCS.E16Lambda
{
    internal class Program
    {
        public Program()
        {
            Console.WriteLine(KlasicnaMetoda(3));
            var Kvadrat = (int b) => b * b;
            Console.WriteLine(Kvadrat(3));

            var alogoritam = (int x, int y) =>
            {
                var t = x++ - y;
                return x + y + t;
            };
            Console.WriteLine(alogoritam(2,3));

            var lista = new List<Smjer>()
            {
                new Smjer() {Naziv="Prvi"},
                new Smjer() {Naziv="Drugi"}
            };

            lista.ForEach(s =>
            {
                Console.WriteLine(s.Naziv);
            });

            lista.ForEach(Console.WriteLine);



        }

        private int KlasicnaMetoda(int b)
        {
            return b * b;
        }
        

    
    
    
    }
}
