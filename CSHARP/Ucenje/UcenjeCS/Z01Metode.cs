using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z01Metode
    {
        public static int CijeliDioZbroja(float a, float b)
        {
            return CijeliDioZbroja((double)a, (double)b);
        }public static int CijeliDioZbroja(double a, double b)
        {
            return (int)(a + b);
        }
    }


}
