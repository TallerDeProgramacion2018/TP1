using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Ingrese un número entero positivo: ");

            string num = Console.ReadLine();
            int numconv = Convert.ToInt32(num);     // Leo el número ingresado por pantalla y lo convierto a tipo entero.

            Console.WriteLine();

            int factorial = 1;

            if (numconv == 0)       // Por definición, el factorial de 0 es 1.
            {
                Console.WriteLine($"El resultado del factorial es: {factorial}");
                Console.ReadKey();
            }
            else
            {
                for (; numconv > 0; numconv--)  // Calculo el factorial mediante multiplicaciones sucesivas.
                {
                    factorial *= numconv;
                }
                Console.WriteLine($"El resultado del factorial es: {factorial}");
                Console.ReadKey();
            }
        }
    }
}
