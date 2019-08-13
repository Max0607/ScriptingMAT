using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Blackjack
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            int carta1 = aleatorio.Next(1,10);
            Console.Write("Su primera carta es: ");
            Console.WriteLine(carta1);
            int carta2 = aleatorio.Next(1,10);
            Console.Write("Su segunda carta es: ");
            Console.WriteLine(carta2);

            int suma = carta1 + carta2;
            int nuevaCarta = 0;
            Console.Write("Tu total es de: ");
            Console.WriteLine(suma);

            String continuar = "s";

            while(continuar == "s" && suma <= 21)
            {
                Console.WriteLine("\r\nDeseas pedir otra carta? (s/n)");
                continuar = Console.ReadLine();
                Console.WriteLine(""); 
                if (continuar == "s")
                {
                    nuevaCarta = aleatorio.Next(1, 10);
                    Console.Write("Tu nueva carta es: ");
                    Console.WriteLine(nuevaCarta);

                    suma = suma + nuevaCarta;
                    Console.WriteLine("Tu nuevo valor es: " + suma);

                    if (suma > 21)
                    {
                        Console.WriteLine("\r\nELIMINADO\r\n");
                        continuar = "n";
                    }
                }
            }

            Console.Write("Su total es de: ");
            Console.WriteLine(suma);
            Console.WriteLine("¡Gracias por jugar!");
        }
    }
}
