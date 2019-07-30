using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio04_01
{
    class Desafio04_01
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su salario: ");
            double salario = double.Parse(Console.ReadLine());

            if (0 <= salario && salario <= 1656232)
            {
                Console.WriteLine("Usted pertenece a la tarifa A");   
            }
            else if (1656232  <= salario && salario <= 3312464)
            {
                Console.WriteLine("Usted pertenece a la tarifa B");
            }
            else
            {
                Console.WriteLine("Usted pertenece a la tarifa C");
            }
        }
    }
}
