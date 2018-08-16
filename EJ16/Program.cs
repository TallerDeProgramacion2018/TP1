using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se pide al usuario que ingrese una de las palabras a evaluar.
            Console.Write("Ingrese la primer palabra: ");
            string iPalabra1 = Console.ReadLine();

            //Se pide al usuario que ingrese la siguiente palabra a evaluar.
            Console.Write("Ingrese la segunda palabra: ");
            string iPalabra2 = Console.ReadLine();

            Console.WriteLine("");

            bool iCoincidencia = false;

            int i = 0;

            if (iPalabra1.Length == iPalabra2.Length)               // Primero nos fijamos si las palabras son del mismo size,             
            {                                                       // si no lo son, no son anagramas.
                while ((i + 1) <= iPalabra1.Length)                 
                {
                    iCoincidencia = false;                              

                    for (int j = 0; (j < iPalabra2.Length) && (iCoincidencia == false); j++)    // Utilizamos este ciclo for para
                    {                                                                           // la segunda cadena.
                        if (iPalabra1[i] == iPalabra2[j])           // Si hay coincidencia de letras en ambas palabras, se eliminan 
                        {                                           // de ambas cadenas.
                            iPalabra1 = iPalabra1.Remove(i, 1);
                            iPalabra2 = iPalabra2.Remove(j, 1);
                            iCoincidencia = true;                   // A la variable iCoincidencia se le asigna true para indicar 
                        }                                           // que se encontro la letra
                        else
                        {
                            iCoincidencia = false;                  // A la variable iCoincidencia se le asigna false para indicar 
                        }                                           // que no se encontro la letra de la primer palabra en la segunda.
                    }

                    if (iCoincidencia == false)
                    {
                        i++;                                        // Se incrementa el valor de i para pasar a la siguiente 
                    }                                               // posicion de la primer palabra.
                }

                if (iPalabra1.Length == 0)                          // Si se eliminaron todas las letras de la primer palabra 
                {                                                   // ingresada, significa que son anagramas.
                    Console.WriteLine("Las palabras ingresadas son anagramas.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Las palabras ingresadas no son anagramas.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Las palabras ingresadas no son anagramas.");     // Si las palabras no tienen el mismo size,
                Console.ReadLine();                                                 // se muestra en pantalla que no son anagramas.
            }
        }
    }
}
