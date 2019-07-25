using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_04
{
    class Ejercicio01_04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el valor de w: ");
            double ValorW = double.Parse(Console.ReadLine());
            Console.WriteLine("Dame el valor de t: ");
            double ValorT = double.Parse(Console.ReadLine());
            Console.WriteLine("Dame el valor de c: ");
            double Cgrados = double.Parse(Console.ReadLine());

            double c = Cgrados * (Math.PI / 180.0);

            double Agrados = (90 - Cgrados);
            Console.Write("El angulo a es: ");
            Console.WriteLine(Agrados);

            double a = Agrados * (Math.PI / 180.0);

            double ValorE = (180 - Cgrados);
            Console.Write("El angulo e es: ");
            Console.WriteLine(ValorE);

            Console.WriteLine("z = cos(a) * t: ");

            double ValorZ = (Math.Cos(a) * ValorT);
            Console.Write("El Lado z es: ");
            Console.WriteLine(ValorZ);

            Console.WriteLine("y = Sin(a) * t: ");

            double ValorY = (Math.Sin(a)* ValorT);
            Console.Write("El Lado y es: ");
            Console.WriteLine(ValorY);

            Console.WriteLine("a + b = ACos(z / w): ");

            double ab = (Math.Acos(ValorZ / ValorW));
            double ABgrados = ab * (180.0 / Math.PI);

            Console.Write("El angulo a + b es: ");
            Console.WriteLine(ABgrados);

            Console.WriteLine("x = (Sin(a + b) * w) - y: ");

            double ValorX = (Math.Sin(ab) * ValorW) - ValorY;
            Console.Write("El Lado x es: ");
            Console.WriteLine(ValorX);
        }
    }
}
