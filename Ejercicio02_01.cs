using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoTriangulo
{
    class Ejercicio02_01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el valor de Y: ");
            double ValorY = double.Parse(Console.ReadLine());
            Console.WriteLine("Dame el valor de Z: ");
            double ValorZ = double.Parse(Console.ReadLine());

            double Hipotenusa = Math.Sqrt(((ValorY) * (ValorY)) + ((ValorZ) * (ValorZ)));
            Console.Write("La hipotenusa es: ");
            Console.WriteLine(Hipotenusa);

            double Y = ValorY * (Math.PI / 180.0);
            double Z = ValorZ * (Math.PI / 180.0);



            double a = Math.Atan(ValorY / ValorZ) * (180.0 / Math.PI);
            Console.Write("El angulo a es: ");
            Console.WriteLine(a);

            double c = Math.Atan(ValorZ / ValorY) * (180.0 / Math.PI);
            Console.Write("El angulo c es: ");
            Console.WriteLine(c);

            Console.ReadLine();
        }
    }
}
