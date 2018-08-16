using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03
{
    class Program
    {

        public const int INFERIOR = 5;
        public const int SUPERIOR = 100;    // Defino los límites como constantes.

        static void Main(string[] args)
        {

            Console.WriteLine($"Las constantes son {INFERIOR} y {SUPERIOR}");
            Console.WriteLine();

            Decimal promedio = (decimal)(INFERIOR + SUPERIOR) / (decimal)2;     // Calculo el promedio.

            int suma = 0;

            for (int cont = INFERIOR; cont <= SUPERIOR; cont++)    // Sumo los elementos.
            {
                suma += cont;
            }

            Console.WriteLine($"La suma es: {suma}");
            Console.WriteLine($"El promedio es: {promedio:0.00}");      // Imprimo en pantalla los resultados.
            Console.Write("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
