using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_02
{
    class Ejercicio01_02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el valor de d: ");
            double Dgrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Dame el valor de b: ");
            double Bgrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Dame el valor de y: ");
            double ValorY = double.Parse(Console.ReadLine());

            double b = Bgrados * (Math.PI / 180.0);
            double d = Dgrados * (Math.PI / 180.0);

            double AnguloA = (90.0 - Dgrados - Bgrados);
            Console.Write("El Angulo A es: ");
            Console.WriteLine(AnguloA);

            double a = AnguloA * (Math.PI / 180.0);

            Console.WriteLine("z = y / Tan(a): ");

            double ValorZ = (ValorY / Math.Tan(a));
            Console.Write("El Valor de Z es: ");
            Console.WriteLine(ValorZ);

            Console.ReadLine();
        }
    }
}
