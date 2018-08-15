using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca el numero de iteraciones que desea realizar: ");
            string cantidadDeDecimales = Console.ReadLine();
            int iteraciones = Convert.ToInt32(cantidadDeDecimales);

            double aproxPI = 0;
            
            for (int n = 0; n <= iteraciones; n++)
            {
                aproxPI += ((double) (Math.Pow(-1,n))) / ((double)(2 * n + 1));
            }

            aproxPI *= 4;
            double error = (((double) (aproxPI)) / ((double) (Math.PI))) * (double) 100;
            Console.WriteLine("El numero obtenido es: " + aproxPI);
            Console.WriteLine(" ");
            Console.WriteLine("El error es: " + error);
            Console.Read();
        }   
    }
}
