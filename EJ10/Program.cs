using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ10
{
    class Program
    {

        public const int PRIMERANIO = 1900;     // Defino las constantes.
        public const int SEGUNDOANIO = 2015;

        static void Main(string[] args)
        {
            Console.WriteLine($" - Años Bisiestos {PRIMERANIO}-{SEGUNDOANIO} -");
            Console.WriteLine();

            for (int i = 1900; i <= 2015; i++)      // Recorro los años con la sentencia for.
            {
                if ((i % 4 == 0) && (!(i % 100 == 0) || (i % 400 == 0)))    // Aplicando la formula lógica, evalúo si es bisiesto.
                {
                    Console.Write($"{i} ");       // Si lo es, lo imprimo en pantalla.
                }
            }

            Console.ReadKey();
        }
    }
}
