using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadenas invertidas y ordenadas de forma de forma descendente:");
            Console.WriteLine();

            string palabraInvertida = "";
            string[] invertidas = new string[args.Length];
            int size = 0;

            for (int i = 0; i <= (args.Length - 1); i++)            // Se recorre el array que contiene las palabras ingresadas 
            {                                                       // en los parametros de la aplicacion.
                size = args[i].Length - 1;
                palabraInvertida = "";

                for (; size >= 0 ; size--)                          // Se recorre la palabra que contiene la posicion del arreglo 
                {                                                   // de forma inversa y se concatena cada caracter.
                    palabraInvertida += args[i].Substring(size, 1);
                }

                invertidas[i] = palabraInvertida;
            }

            
            for (int i = 0; i < invertidas.Length - 1; i++)     // Ordeno el vector mediante el método burbuja.
            {
                for (int j = 0; j < invertidas.Length -1 - i; j++)
                {
                    if (invertidas[j].CompareTo (invertidas[j + 1]) == 1)
                    {
                        string auxiliar = invertidas[j];
                        invertidas[j] = invertidas[j + 1];
                        invertidas[j + 1] = auxiliar; 
                    }
                }
            }

            for (int i = invertidas.Length - 1; i >= 0; i--)    // Se muestra cada elemento del vector, pero se recorre de
            {                                                   // de forma inversa para mostrar los elementos de forma descendente.
                Console.WriteLine(invertidas[i]);               
            }

            Console.ReadLine();
        }
    }
}
