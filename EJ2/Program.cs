using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese valor: ");
            string numeroIngresado = Console.ReadLine();
            int numero = Convert.ToInt32(numeroIngresado);

            switch (numero)
            {
                case 1:
                    Console.WriteLine("El numero ingresado fue UNO");
                    break;

                case 2:
                    Console.WriteLine("El numero ingresado fue DOS");
                    break;

                case 3:
                    Console.WriteLine("El numero ingresado fue TRES");
                    break;

                case 4:
                    Console.WriteLine("El numero ingresado fue CUATRO");
                    break;

                case 5:
                    Console.WriteLine("El numero ingresado fue CINCO");
                    break;

                case 6:
                    Console.WriteLine("El numero ingresado fue SEIS");
                    break;

                case 7:
                    Console.WriteLine("El numero ingresado fue SIETE");
                    break;

                case 8:
                    Console.WriteLine("El numero ingresado fue OCHO");
                    break;

                case 9:
                    Console.WriteLine("El numero ingresado fue NUEVE");
                    break;

                default:
                    Console.WriteLine("El numero ingresado es OTRO");
                    break;

            }
            Console.WriteLine(" ");
            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadLine();
            
        }
    }
}
