using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ15
{
    class Program
    {

        public const int INFERIOR = 20;
        public const int SUPERIOR = 100;


        static void Main(string[] args)
        {
            Console.WriteLine($"Números entre {INFERIOR} y {SUPERIOR} en forma ascendente:");
            int[] arreglo = new int[10];
            Random random = new Random();

            for (int pos = 0; pos < arreglo.Length; pos++)  // Completamos el arreglo con números aleatorios.
            {
                arreglo[pos] = random.Next(0, 200);
            }

            int aux;    // Ordenamos el arreglo mediante metodo burbuja para devolver la solucion de forma ascendente.
            for (int a = 1; a < arreglo.Length; a++)
                for (int b = arreglo.Length - 1; b >= a; b--)
                {
                    if (arreglo[b - 1] > arreglo[b])
                    {
                        aux = arreglo[b - 1];
                        arreglo[b - 1] = arreglo[b];
                        arreglo[b] = aux;
                    }
                }

            Console.WriteLine();

            for (int i = 0; i < arreglo.Length; i++)  // Recorremos el vector imprimiendo los que se encuentran entre los límites. 
            {
                if ((arreglo[i] >= INFERIOR) && (arreglo[i] <= SUPERIOR))
                {
                    Console.WriteLine(arreglo[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
