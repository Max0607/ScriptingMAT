using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hace usted parte del regimen subsidiado (SISBEN)?: ");
            string Sisben = Console.ReadLine();

            if(Sisben.ToUpper() == "SI")
            {
                Console.WriteLine("Al ser parte del regimen subsidiado usted no paga cuota moderadora");
            }
            else
            {
                Console.Write("Ingrese su salario: ");
                double salario = double.Parse(Console.ReadLine());

                if (0 <= salario && salario <= 1656231 )
                {
                    Console.WriteLine("Usted debe pagar una cuota moderadora de 3.200 pesos (Tarifa A)");
                }
                else if (1656231 <= salario && salario <= 4140580)
                {
                    Console.WriteLine("Usted debe pagar una cuota moderadora de 12.700 pesos (Tarifa B)");
                }
                else 
                {
                    Console.WriteLine("Usted debe pagar una cuota moderadora de 33.500 pesos (Tarifa C)");
                }
            }
        }

    }
}
