using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primos entre 35 y 1977 incluídos:");

            bool primo;
            int suma = 0;

            for (int i = 35; i <= 1977; i++)  // Recorro los números con una sentencia for.
            {
                primo = true;
                for (int j = 2; ((primo) && (j < i)); j++)  // Para cada número 'i' evalua los divisores entre 2 y (i-1).
                {
                    if (i % j == 0)
                    {
                        primo = false;      // Si encuentra un numero que pueda dividir a 'i', sabemos que no es primo.
                    }
                }
                if (primo)
                {
                    suma += i;      // Acumulo los números primos.
                }
            }

            Console.WriteLine();
            Console.Write($"La suma de estos números es: {suma}");
            Console.ReadKey();
        }
    }
}
