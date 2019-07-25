using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_03
{
    class Ejercicio01_03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el valor de w: ");
            double ValorW = double.Parse(Console.ReadLine());
            Console.WriteLine("Dame el valor de d: ");
            double Dgrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Dame el valor de x: ");
            double ValorX = double.Parse(Console.ReadLine());

            double d = Dgrados * (Math.PI / 180.0);

            double ValorZ = (Math.Sin(d) * ValorW);
            Console.Write("El Lado z es: ");
            Console.WriteLine(ValorZ);

            Console.WriteLine("y = tan(d) * z - x: ");

            double ValorY = ((ValorZ / Math.Tan(d)) - ValorX);
            Console.Write("El Lado Y es: ");
            Console.WriteLine(ValorY);
        }
    }
}
