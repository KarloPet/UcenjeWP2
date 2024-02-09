using System;
using System.Collections.Generic;
using UcenjeCS.Z98KonzolnaApp.Gosti;

namespace UcenjeCS.Z98KonzolnaApp.Rezervacije
{
    internal class Rezervacije
    {
        public List<Gosti.Gosti> Gosti { get; set; }

        private static int _counter = 0;
        public int id { get; set; }
        public decimal cijena { get; }
        public DateTime datum_od { get; set; }
        public DateTime datum_do { get; set; }
        public Rezervacije()
        {
            _counter++;
            id = _counter;
        }
    }
}
