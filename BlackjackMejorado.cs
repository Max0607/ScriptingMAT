using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class BlackjackMejorado
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int jugadores = 0;
            int jugador = 0;
            int puntos1 = 0, puntos2 = 0, puntos3 = 0, puntos4 = 0, puntos5 = 0, puntosGanador = 0;
            int ganador = 0;
            string totaljugadores = "";

            Console.WriteLine("Bienvenido a blackjack");
            Console.WriteLine("----------------------");
            Console.Write("Inserte el numero de jugadores (Minimo 2, Maximo 5): ");
            totaljugadores = Console.ReadLine();

            while (totaljugadores != "2" && totaljugadores != "3" && totaljugadores != "4" && totaljugadores != "5")
            {
                Console.Write("Por favor digite un numero entre 2 y 5: ");
                totaljugadores = Console.ReadLine();
            }
            jugadores = int.Parse(totaljugadores);

            while (jugadores < 2 || jugadores > 5)
            {
                Console.Write("No hay suficientes jugadores, inserte otra cantidad (Minimo 2, Maximo 5): ");

                jugadores = int.Parse(Console.ReadLine());
            }

            for (jugador = 1; jugador <= jugadores; jugador++)
            {
                Console.WriteLine("\r\nBienvenido jugador " + jugador);
                Console.WriteLine("--------------------");

                int carta1 = aleatorio.Next(1, 10);
                Console.Write("Jugador " + jugador + ", tu primera carta es: ");
                Console.WriteLine(carta1);
                int carta2 = aleatorio.Next(1, 10);
                Console.Write("Jugador " + jugador + ", tu segunda carta es: ");
                Console.WriteLine(carta2);


                int suma = carta1 + carta2;
                int nuevaCarta = 0;
                Console.Write("Jugador " + jugador + ", tu total es de: ");
                Console.WriteLine(suma);

                String continuar = "s";

                while (continuar == "s" && suma <= 21)
                {
                    Console.Write("Jugador " + jugador + ", deseas pedir otra carta? (s/n): ");
                    continuar = Console.ReadLine();

                    while (continuar != "s" && continuar != "n")
                    {
                        Console.Write("Respuesta incorrecta, digita s(si) o n(no) para continuar: ");
                        continuar = Console.ReadLine();
                    }
                    if (continuar == "s")
                    {
                        nuevaCarta = aleatorio.Next(1, 10);
                        Console.WriteLine("Jugador " + jugador + ", tu nueva carta es: " + nuevaCarta);

                        suma = suma + nuevaCarta;
                        Console.WriteLine("Jugador " + jugador + ", tu nuevo valor es: " + suma);

                        if (suma > 21)
                        {
                            Console.WriteLine("\r\nJugador " + jugador + ", has sido ELIMINADO\r\n");
                            continuar = "n";
                        }
                    }
                    switch(jugador)
                    {
                        case 1:
                            puntos1 = suma;
                            break;
                        case 2:
                            puntos2 = suma;
                            break;
                        case 3:
                            puntos3 = suma;
                            break;
                        case 4:
                            puntos4 = suma;
                            break;
                        case 5:
                            puntos5 = suma;
                            break;
                    }
                }

                Console.WriteLine("Jugador " + jugador + ", tu total es de: " + suma);
                Console.WriteLine("-------------------");
                Console.WriteLine("¡Gracias por jugar!");
                Console.WriteLine("-------------------\r\n");
            }
            if (puntos1 > puntosGanador && puntos1<=21)
            {
                puntosGanador = puntos1;
                ganador = 1;    
            }
            if (puntos2 > puntosGanador && puntos2 <= 21)
            {
                puntosGanador = puntos2;
                ganador = 2;
            }
            if (puntos3 > puntosGanador && puntos3 <= 21)
            {
                puntosGanador = puntos3;
                ganador = 3;
            }
            if (puntos4 > puntosGanador && puntos4 <= 21)
            {
                puntosGanador = puntos4;
                ganador = 4;
            }
            if (puntos5 > puntosGanador && puntos5 <= 21)
            {
                puntosGanador = puntos5;
                ganador = 5;
            }
            if (puntosGanador == 0)
            {
                Console.WriteLine("Todos han perdido...");
            }
            else 
            {
                Console.WriteLine("Gana el jugador " + ganador + "!  Felicitaciones");
            }


            Console.ReadLine();
        }
    }
}
