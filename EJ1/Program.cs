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

            Console.WriteLine("-PROGRAMA RECONOCEDOR- ");
            Console.Write(" Ingresar un valor: ");

            string valorIngresado = Console.ReadLine();
            int numero = Convert.ToInt32(valorIngresado); // Leo el valor ingresado y lo convierto a tipo entero.

            Console.WriteLine();
            Console.Write("Se reconoció: ");

            if (numero == 1)  // Evalúo el número ingresado con estructura if-else y imprimo en pantalla acorde a lo ingresado.
            {
                Console.Write("UNO");
            }
            else if (numero == 2)
            {
                Console.Write("DOS");
            }
            else if (numero == 3)
            {
                Console.Write("TRES");
            }
            else if (numero == 4)
            {
                Console.Write("CUATRO");
            }
            else if (numero == 5)
            {
                Console.Write("CINCO");
            }
            else if (numero == 6)
            {
                Console.Write("SEIS");
            }
            else if (numero == 7)
            {
                Console.Write("SIETE");
            }
            else if (numero == 8)
            {
                Console.Write("OCHO");
            }
            else if (numero == 9)
            {
                Console.Write("NUEVE");
            }
            else
            {
                Console.Write("OTRO");
            }

            Console.WriteLine();

            Console.WriteLine("Presione un botón para salir.");
            Console.ReadKey();
        }
    }
}
