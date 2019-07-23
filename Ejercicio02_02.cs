using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoTriangulo2
{
    class Ejercicio02_02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el valor de t: ");
            double ValorT = double.Parse(Console.ReadLine());
            Console.WriteLine("Dame el valor de a: ");
            double ValorA = double.Parse(Console.ReadLine());

            double A = ValorA * (Math.PI / 180.0);

            double c = (90 - ValorA);
            Console.Write("El angulo c es: ");
            Console.WriteLine(c);

            double Y = Math.Sin(A) * ValorT;
            Console.Write("El lado Y es: ");
            Console.WriteLine(Y);

            double Z = (Math.Cos(A) * ValorT);
            Console.Write("El lado Z es: ");
            Console.WriteLine(Z);
        }
    }
}
