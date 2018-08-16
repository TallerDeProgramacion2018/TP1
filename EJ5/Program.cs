using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ05
{
    class Program
    {
        public const int INFERIOR = 5;
        public const int SUPERIOR = 100;    // Defino los límites como constantes.

        static void Main(string[] args)
        {
            Console.WriteLine($"Las constantes son {INFERIOR} y {SUPERIOR}");
            Console.WriteLine();

            Decimal prom = (decimal)(INFERIOR + SUPERIOR) / (decimal)2;     // Calculamos un promedio haciendo un casting de las variables para que las tome como números reales.

            int suma = 0;
            int cont = INFERIOR;

            // Calculo la suma con la estructura do-while.
            do
            {
                suma += cont;
                ++cont;
            } while (cont <= SUPERIOR);

            Console.WriteLine($"La suma es: {suma}");
            Console.WriteLine($"El promedio es: {prom:0.00}");
            Console.Write("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
