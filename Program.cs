using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, total = 0, dado2 = 0, pares = 0, totales = 0;
            string continuar = "s";
            double M6 = 0;

            while (continuar == "s" && pares < 3)
            {
                dado = aleatorio.Next(1, 7);
                dado2 = aleatorio.Next(1, 7);
                Console.WriteLine("Su primer dado es: " + dado);
                Console.WriteLine("Su segundo dado es: " + dado2);
                totales += 1;

                if (dado == 1 && dado2 == 1) 
                {
                    total = 0;
                    Console.WriteLine("ELIMINADO");
                    break;
                }
                else 
                {
                    total += dado + dado2;
                    Console.WriteLine("Total: " + total);
                    if(dado + dado2 > 6)
                    {
                        M6 += 1;
                    }

                    if(dado == dado2)
                    {
                        pares += 1;
                    }
                }

                if (total >= 100)
                {
                    Console.WriteLine("Has supreado los 100 puntos, felicitaciones! Ganaste!");
                    break;
                }
                else if (pares >= 3)
                {
                    Console.WriteLine("Has sacado tres pares consecutivos, feliciaciones! Ganaste!");
                    break;
                }
                else
                {
                    Console.Write("Desea continuar? (s/n): ");
                    continuar = Console.ReadLine();
                }
            }

            double m6 = (M6 / totales) * 100;
            Console.WriteLine("La cantidad de veces que sacaste mas de 6 fue: " + m6 + "%");


            Console.WriteLine("Su total fue de: " + total + " puntos");
            Console.WriteLine("Muchas  gracias por jugar");
        }
    }
}
