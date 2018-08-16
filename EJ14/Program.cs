using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("En base a 30 números aleatorios determinaremos su maximo, mínimo y su promedio.");

            double[] vectorDeNumeros = new double[30];  // Inicializamos el arreglo y el objeto aleatorio.
            Random random = new Random();
            double promedio = 0;
            double suma = 0;
            double max = vectorDeNumeros[0];

            for (int pos = 0; pos < vectorDeNumeros.Length; pos++)  // Completamos el arreglo con números aleatorios.
            {
                vectorDeNumeros[pos] = random.NextDouble();
            }

            double min = vectorDeNumeros[0];

            for (int pos = 0; pos < vectorDeNumeros.Length; pos++) // Determinamos el máximo.
            {
                if (vectorDeNumeros[pos] > max)
                {
                    max = vectorDeNumeros[pos];
                }
            }

            for (int pos = 0; pos < vectorDeNumeros.Length; pos++) // Determinamos el mínimo.
            {
                if (vectorDeNumeros[pos] < min)
                {
                    min = vectorDeNumeros[pos];
                }
            }

            for (int pos = 0; pos < vectorDeNumeros.Length; pos++) // Determinamos la suma para calcular el promedio.
            {
                suma += vectorDeNumeros[pos];
            }

            promedio = suma / vectorDeNumeros.Length;

            Console.WriteLine($"El maximo es:  {max:0.000}");
            Console.WriteLine($"El minimo es:  {min:0.000}");
            Console.WriteLine($"El promedio es: {promedio:0.000}");

            Console.WriteLine();
            Console.Write("Presione cualquier tecla para contiunar...");
            Console.ReadLine();
        }
    }
}
