using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Autonoma_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de votos para el partido A: ");
            int votantesA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de votos para el partido B: ");
            int votantesB = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de votos en blanco: ");
            int votoBlancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de votos anulados: ");
            int votoAnulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la poblacion del area: ");
            int poblacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcetaje de mayores de edad de dicha poblacion: ");
            double poblacionMayor = double.Parse(Console.ReadLine());


            int totalVotos = votantesA + votantesB + votoBlancos + votoAnulados;
            double votantes = (poblacion * poblacionMayor) / 100;

            bool A = totalVotos > poblacion;
            bool B = (votantesA - votantesB) < (totalVotos)* 0.1;
            bool C = votantes < (poblacion) * 0.3;

            if ((A || B) && (C))
            {
                Console.WriteLine("Desgraciadamente las elecciones tienen que repetirse");

            }
            else
            {
                if(votantesA > votantesB )
                {
                    Console.WriteLine("Ha ganado el candidato A, felicitaciones!");
                }
                else
                {
                    Console.WriteLine("Ha ganado el candidato B, felicitaciones!");
                }
            }
        }
    }
}