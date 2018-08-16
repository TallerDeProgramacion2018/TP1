using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Ingrese un número real: ");
            string rea = Console.ReadLine();
            double radio = Convert.ToDouble(rea);       // Leo la cadena escrita y la transformo a un número real.

            Console.WriteLine();

            Console.WriteLine($" Siendo el radio de el circulo {radio:0.00}:");

            double area = Math.PI * Math.Pow(radio, 2);         // Calculo el área.

            Console.WriteLine($" El área del circulo es: {area:0.000}");

            double perimetro = 2 * Math.PI * radio;         // Calculo el perímetro

            Console.WriteLine($" El perimetro del circulo es: {perimetro:0.000}");

            Console.WriteLine();
            Console.Write(" Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
