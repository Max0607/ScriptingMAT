using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_01
{
    class Ejercicio01_01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el valor de b: ");
            double Bgrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Dame el valor de z: ");
            double ValorZ = double.Parse(Console.ReadLine());
            Console.WriteLine("Dame el valor de y: ");
            double ValorY = double.Parse(Console.ReadLine());

            double b = Bgrados * (Math.PI / 180.0);

            double AnguloA = Math.Atan(ValorY / ValorZ) * (180.0 / Math.PI);
            Console.Write("El Angulo A es: ");
            Console.WriteLine(AnguloA);

            double a = AnguloA * (Math.PI / 180.0);

            Console.WriteLine("x = Tan(a + b) * z - y: ");

            double ValorX = ((Math.Tan(a + b)) * ValorZ) - ValorY;
            Console.Write("El Valor de X es: ");
            Console.WriteLine(ValorX);

            Console.ReadLine();

        }
    }
}
