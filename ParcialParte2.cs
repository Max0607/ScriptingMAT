using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParte2
{
    class ParcialParte2
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, total = 0, vidas = 3, contador1 = 0, contador6 = 0;
            string continuar = "s";

            while(continuar == "s")
            {
                dado = aleatorio.Next(1, 7);
                Console.WriteLine("Dado: " + dado);
                if (dado == 6)
                {
                    contador6 += 1;
                    if (contador6 == 2 && vidas < 3)
                    {
                        Console.WriteLine("Sacaste dos 6 consecutivos por lo tanto ganas una vida");

                        vidas += 1;
                        contador1 = 0;
                    }
                    total += dado;
                }
                else 
                {
                    contador6 = 0;
                    if (dado == 1)
                    {                    
                        contador1 += 1;
                        if (contador1 == 2)
                        {
                            Console.WriteLine("Saco dos 1 por lo tanto pierde una vida");

                            vidas -= 1;
                            total -= 10;
                            contador1 = 0;

                            if (vidas <= 0)
                            {
                                Console.WriteLine("Se te han acabado las vidas, quedas eliminado");
                                break;
                            }
                            Console.WriteLine("Te quedan " + vidas + " vidas");
                        
                        }
                    }
                    else
                    {
                        total += dado;
                    }
                }

                Console.WriteLine("Tienes: " + vidas + " vidas");
                Console.WriteLine("Tu total es de: " + total);
                Console.Write("Desea Continuar? (s/n)");
                continuar = Console.ReadLine();
            }

            Console.WriteLine("Tu total fue: " + total);
            Console.WriteLine("Gracias por participar");

        }
    }
}
