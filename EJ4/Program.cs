using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese limite inferior: ");
            string numeroIngresado1 = Console.ReadLine();
            int limiteInferior = Convert.ToInt32(numeroIngresado1); Console.WriteLine(" ");

            Console.Write("Ingrese limite superior: ");
            string numeroIngresado2 = Console.ReadLine();
            int limiteSuperior = Convert.ToInt32(numeroIngresado2); Console.WriteLine(" ");

            decimal promedio = (decimal)(limiteInferior + limiteSuperior) / (decimal)2;

            int suma = 0;

            while (limiteInferior <= limiteSuperior)
            {
                suma += limiteInferior;
                limiteInferior++;
            }

            Console.WriteLine("Resultado de la suma: " + suma + " y el promedio es: " + promedio);
            Console.WriteLine(" ");
            Console.Write("Presione ENTER para continuar");
            Console.ReadLine();
        }
    }
}
