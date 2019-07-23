using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoTriangulo3
{
    class Ejercicio02_03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el valor de c: ");
            double ValorC = double.Parse(Console.ReadLine());
            Console.WriteLine("Dame el valor de z: ");
            double ValorZ = double.Parse(Console.ReadLine());

            double C = ValorC * (Math.PI / 180.0);

            double a = (90 - ValorC);
            Console.Write("El angulo a es: ");
            Console.WriteLine(a);

            double T = ValorZ / Math.Sin(C);
            Console.Write("La Hipotenusa es: ");
            Console.WriteLine(T);

            double Y = (Math.Cos(C) * T);
            Console.Write("El lado Y es: ");
            Console.WriteLine(Y);
        }
    }
}
