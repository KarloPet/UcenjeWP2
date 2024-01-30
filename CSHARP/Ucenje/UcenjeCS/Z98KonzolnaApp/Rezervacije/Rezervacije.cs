using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.Z98KonzolnaApp.Rezervacije
{
    internal class Rezervacije
    {
        public int id { get; set; }
        public decimal cijena { get; set; }
        public DateTime datum_od { get; set; }
        public DateTime datum_do { get; set; }
    }
}
