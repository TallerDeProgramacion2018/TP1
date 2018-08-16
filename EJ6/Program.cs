using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NUMEROS IMPARES:");

            int cant = 0;
            int sum = 0;

            for (int contador = 1; contador < 100; contador++)
            {
                if (contador % 2 != 0)     // Compruebo que el número es impar (si se cumple que su resto de la division entre dos no es cero).
                {
                    cant++;
                    sum += contador;
                }
            }

            decimal prom = (decimal)sum / (decimal)cant;    // Calculo usando un casting de las variables.

            Console.WriteLine($"La suma es: {sum}");
            Console.WriteLine($"El promeido es: {prom:0.00}");
            Console.Write("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
