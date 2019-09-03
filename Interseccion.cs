using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interseccion_Conjuntos
{
    class Interseccion
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 15, 6, 12, 3, 18, 12, 6, 9 };
            int[] B = { 4, 0, 18, 6, 16, 6, 10, 14, 2, 12, 8, 2 };
            bool esta = false;

            List<int> interseccion = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if(A[i] == B[j])
                    {
                        esta = false;
                        for(int k = 0; k < interseccion.Count; k++)
                        {
                            if(A[i] == interseccion[k])
                            {
                                esta = true;

                            }
                        }
                        if(esta == false)
                        {
                            interseccion.Add(A[i]);
                        }
                    }
                }
            }
            for (int i = 0; i < interseccion.Count; i++)
            {
                Console.Write(interseccion[i] + ",");
            }
        }
    }
}
