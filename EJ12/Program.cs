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
            Console.Write("Ingrese numero: ");          
            string numIngresado = Console.ReadLine();
            int num = Convert.ToInt32(numIngresado);

            int factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.Write(" ");
            Console.WriteLine("El factorial del numero ingresado es: "+factorial);
            Console.Read();
        }
    }
}
