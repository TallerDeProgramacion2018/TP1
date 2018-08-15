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
            double[] vectorDeNumeros = new double[30];
            Random random = new Random();
            double promedio = 0;
            double suma = 0;
            double max = vectorDeNumeros[0];
            double min = vectorDeNumeros[0];

            for (int pos = 0; pos < vectorDeNumeros.Length; pos++)
            {
                vectorDeNumeros[pos] = random.NextDouble();
            }

            for (int pos = 0; pos < vectorDeNumeros.Length; pos++)
            {
                if (vectorDeNumeros[pos] > max)
                {
                    max = vectorDeNumeros[pos];
                }
            }

            for (int pos = 0; pos < vectorDeNumeros.Length; pos++)
            {
                if (vectorDeNumeros[pos] < min)
                {
                    min = vectorDeNumeros[pos];
                }
            }

            for (int pos = 0; pos < vectorDeNumeros.Length; pos++)
            {
                suma += vectorDeNumeros[pos]; 
            }

            promedio = suma / vectorDeNumeros.Length;

            Console.WriteLine("El maximo es: " + max);
            Console.WriteLine("El minimo es: " + min);
            Console.WriteLine("El promedio es: " + promedio);

            Console.ReadLine();
        }
    }
}
