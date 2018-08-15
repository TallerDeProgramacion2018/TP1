using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumaDeImpares = 0;

            for (int i = 0; i <= 100; i++)
            {
                if ((i % 2) == 0)
                {
                    sumaDeImpares += i;
                }
            }

            decimal promedio = (decimal) (1 + 100) / (decimal) 2;
            Console.WriteLine("La suma es: " + sumaDeImpares + " y el promedio es: " + promedio);
            Console.WriteLine(" ");
            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadLine();
        }
    }
}
