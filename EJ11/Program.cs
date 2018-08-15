using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iingrese el radio del circulo: ");
            string num = Console.ReadLine();
            double radio = Convert.ToDouble(num);

            double area = (Math.PI) * (Math.Pow(radio,2));
            double perimetro = 2 * (Math.PI) * (radio);

            Console.WriteLine($"El area es: {area:0.00}");
            Console.WriteLine($"El perimetro es: {perimetro:0.00}");

            Console.Read();

        }
    }
}
