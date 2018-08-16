using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeros 50 elementos de la serie de Fibonacci:");
            Console.WriteLine();

            long pri = 0;
            long seg = 1;

            Console.WriteLine(pri);
            Console.WriteLine(seg);

            for (int i = 0; i < 49; i++)    // Con una estructura for calculamos la serie.
            {
                Console.WriteLine(pri + seg);
                seg = pri + seg;
                pri = seg - pri;
            }

            Console.ReadKey();
        }
    }
}
