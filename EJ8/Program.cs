using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ8
{
    class Program
    {
        static void Main(string[] args)
        {
            long siguiente = 0;
            long primero = 0;
            long segundo = 1;

            Console.WriteLine(primero);
            Console.WriteLine(segundo);

            for (int i = 0; i <= 48 ; i++)
            {
                siguiente = primero + segundo;
                Console.WriteLine(siguiente);
                primero = segundo;
                segundo = siguiente;
            }

            Console.Read();
        }
    }
}
