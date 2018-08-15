using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese valor: ");
            string numeroIngresado = Console.ReadLine();
            int numero = Convert.ToInt32(numeroIngresado);

            if (numero == 1)
            {
                Console.WriteLine("El numero ingresado fue UNO"); //esta mal
            }
            else if (numero == 2)
            {
                Console.WriteLine("El numero ingresado fue DOS",numero);
            }
            else if (numero == 3)
            {
                Console.Write("El numero ingresado fue TRES", numero);
            }
            else if (numero == 4)
            {
                Console.WriteLine("El numero ingresado fue CUATRO",numero);
            }
            else if (numero == 5)
            {
                Console.WriteLine("El numero ingresado fuE CINCO",numero);
            }
            else if (numero == 6)
            {
                Console.WriteLine("El numero ingresado fue SEIS",numero);
            }
            else if (numero == 7)
            {
                Console.WriteLine("El numero ingresado fue SIETE",numero);
            }
            else if (numero == 8)
            {
                Console.WriteLine("El numero ingresado fue OCHO",numero);
            }
            else if (numero == 9)
            {
                Console.WriteLine("El numero ingresado fue NUEVE",numero);
            }
            else
            {
                Console.WriteLine("El numero ingresado fue es mayor que 9");
            }
            Console.ReadLine();
        }
    }
}
