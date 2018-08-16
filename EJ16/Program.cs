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
            //Se pide al usuario que ingrese una de las palabras a evaluar
            Console.WriteLine("Ingrese la primer palabra: ");
            Console.WriteLine("");
            string iPalabra1 = Console.ReadLine();

            //Se pide al usuario que ingrese la siguiente palabra a evaluar
            Console.WriteLine("Ingrese la segunda palabra: ");
            Console.WriteLine("");
            string iPalabra2 = Console.ReadLine();

            bool iAnagrama = false;

            int i = 0;

            if (iPalabra1.Length == iPalabra2.Length)
            {
                while ((i + 1) <= iPalabra1.Length)
                {
                    iAnagrama = false;

                    for (int j = 0; (j < iPalabra2.Length) && (iAnagrama == false); j++)
                    {
                        if (iPalabra1[i] == iPalabra2[j])
                        {
                            iPalabra1 = iPalabra1.Remove(i, 1);
                            iPalabra2 = iPalabra2.Remove(j, 1);
                            iAnagrama = true;
                        }
                        else
                        {
                            iAnagrama = false;
                        }
                    }

                    if (iAnagrama == false)
                    {
                        i++;
                    }
                }

                if ((iPalabra1.Length == 0) && (iAnagrama == true))
                {
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
                Console.WriteLine("Las palabras ingresadas no son anagramas.");
                Console.ReadLine();
            }
        }
    }
}
