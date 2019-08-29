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
            int[] puntos = { 0, 0, 0, 0, 0, 0 };
            int[] participantes = { 0, 1, 2, 3, 4, 5 };
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
                    puntos[jugador] = suma;
                }

                Console.WriteLine("Jugador " + jugador + ", tu total es de: " + suma);

            }

            for(int i = 1; i <= 5; i++)
            {
                for(int j = i + 1; j <= 5; j++)
                {
                    if(puntos[i] < puntos[j])
                    {
                        int punto = puntos[i];
                        puntos[i] = puntos[j];
                        puntos[j] = punto;
                        int participante = participantes[i];
                        participantes[i] = participantes[j];
                        participantes[j] = participante;

                    }
                }
            }
            Console.WriteLine("\r\nResultados");
            Console.WriteLine("----------");
            for (int i = 1; i <= 5; i++)
            {
                if(puntos[i] <= 21 && puntos[i] > 0)
                {
                    if(ganador == 0)
                    {

                        Console.WriteLine("Ha ganado el jugador " + participantes[i] + " con un total de: " + puntos[i]);
                        ganador++;
                    }
                    else
                    {
                        Console.WriteLine("El segundo puesto fue ocupado por el jugador " + participantes[i] + " con un total de: " + puntos[i]);
                        break;
                    }

                }
            }
            if(ganador == 0)
            {
                Console.WriteLine("Todos los jugadores perdieron...");
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("¡Gracias por jugar!");
            Console.WriteLine("-------------------\r\n");
            Console.ReadLine();
        }
    }
}
