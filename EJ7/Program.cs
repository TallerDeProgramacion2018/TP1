using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cantidad de términos:");
            string cant = Console.ReadLine();
            int cantConvertida = Convert.ToInt32(cant);     // Leo la cadena ingresada por patnalla y la convierto a tipo entero.

            double result = 0;

            for (int i = 0; i <= cantConvertida; i++)    // Aplico la sumatoria.
            {
                result += ((double)(Math.Pow(-1, i)) / (double)(2 * i + 1));
            }
            result *= 4;

            Console.WriteLine($"La aproximación es: {result:0.000}");

            double porcentaje = (result / Math.PI) * 100;

            Console.Write($"Es un {porcentaje:0.00}");
            Console.WriteLine(" porciento de el valor de Pi.");
            Console.Write("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }   
    }
}
