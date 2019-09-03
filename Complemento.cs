using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complemento_Conjuntos
{
    class Complemento
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 15, 6, 12, 3, 18, 12, 6, 9 };
            int[] B = { 4, 0, 18, 6, 16, 6, 10, 14, 2, 12, 8, 2 };
            int[] U = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            bool esta = false;

            Console.WriteLine("Complemento = Universal - union");

            List<int> Union = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                Union.Add(A[i]);
            }
            for (int i = 0; i < B.Length; i++)
            {
                Union.Add(B[i]);
            }

            Union.Sort();
            for (int i = 0; i < Union.Count - 1; i++)
            {
                if (Union[i] == Union[i + 1])
                {
                    Union.RemoveAt(i);
                    i = 0;
                }

            }
            Console.Write("Union: ");
            for (int i = 0; i < Union.Count; i++)
            {
                Console.Write(Union[i] + ",");
            }
            Console.WriteLine("");
            Console.Write("Universal: ");
            for (int i = 0; i < U.Length; i++)
            {
                Console.Write(U[i] + ",");
            }
            Console.WriteLine("");

            List<int> complemento = new List<int>();
            for (int i = 0; i < U.Length; i++)
            {
                esta = true;
                for (int j = 0; j < Union.Count; j++)
                {
                    if (U[i] == Union[j])
                    {
                        esta = false;
                        break;
                    }
                }
                if (esta == true)
                {
                    complemento.Add(U[i]);
                }
            }
            Console.Write("Complemento: ");
            for (int i = 0; i < complemento.Count; i++)
            {
                Console.Write(complemento[i] + ",");
            }


        }

    }
    
}
