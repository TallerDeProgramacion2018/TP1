using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Los años bisiestos comprendidos entre 1900 y 2015 son:");
            for (int a= 1900; a <= 2015; a++)
            {
                if ((a % 4 == 0) && ((a % 100 != 0) || (a % 400 == 0)))
                {
                    Console.WriteLine(a);             
                }
            }

            Console.Read();
        }
    }
}
