using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ04
{
    class Program
    {
        public const int INFERIOR = 5;
        public const int SUPERIOR = 100;    // Defino los límites como constantes.

        static void Main(string[] args)
        {
            Console.WriteLine($"Las constantes son {INFERIOR} y {SUPERIOR}");
            Console.WriteLine();

            Decimal prom = (decimal)(INFERIOR + SUPERIOR) / 2; // Calculamos un promedio haciendo un casting de las variables para que las tome como números reales.

            int suma = 0;
            int cont = INFERIOR;

            while (cont <= SUPERIOR)    // Calculo la suma con un contador auxiliar.
            {
                suma += cont;
                ++cont;
            }

            Console.WriteLine($"La suma es: {suma}");
            Console.WriteLine($"El promedio es: {prom:0.00}");
            Console.Write("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
