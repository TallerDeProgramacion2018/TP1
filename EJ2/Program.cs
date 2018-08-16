using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-PROGRAMA RECONOCEDOR- ");
            Console.Write("Ingresar un valor: ");

            string valorIngresado = Console.ReadLine();
            int numero = Convert.ToInt32(valorIngresado);   // Leo el valor ingresado y lo convierto a tipo entero.

            Console.WriteLine();

            switch (numero)  // Evalúo el número ingresado con estructura switch y imprimo en pantalla acorde a lo ingresado.
            {
                case 1: Console.Write(" UNO"); break;
                case 2: Console.Write(" DOS"); break;
                case 3: Console.Write(" TRES"); break;
                case 4: Console.Write(" CUATRO"); break;
                case 5: Console.Write(" CINCO"); break;
                case 6: Console.Write(" SEIS"); break;
                case 7: Console.Write(" SIETE"); break;
                case 8: Console.Write(" OCHO"); break;
                case 9: Console.Write(" NUEVE"); break;
                default: Console.Write(" OTRO"); break;
            }
            Console.WriteLine();
            Console.Write("Presione cualquier tecla para cerrar... ");
            Console.ReadKey();
        }
    }
}
