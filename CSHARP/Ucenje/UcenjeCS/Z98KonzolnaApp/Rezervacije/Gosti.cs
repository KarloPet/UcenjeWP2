using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.Z98KonzolnaApp.Gosti
{
    public class Gosti
    {
        private static int _counter = 0;
        public int id { get; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string oib { get; set; }

        public Gosti()
        {
            _counter++;
            id = _counter;
        }
    }
}
