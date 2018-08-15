using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ9
{
    class Program
    {
        static void Main(string[] args)
        {
            long resultado = 0;
            bool estado;

            for (int n= 35; n <= 1977; n++)
            {
                estado = true;

                for (int anterior = 2; anterior < n; anterior++)
                {
                    if (n % anterior == 0)
                    {
                        estado = false;
                    }
                }
                
                if (estado)
                {
                    resultado += n; 
                } 
            }

            Console.WriteLine(resultado);
            Console.Read();
        }
    }
}
