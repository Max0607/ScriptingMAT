using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Union_Conjuntos
{
    class Union
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 15, 6, 12, 3, 18, 12, 6, 9};
            int[] B = { 4, 0, 18, 6, 16, 6, 10, 14, 2, 12, 8, 2};

            List<int> Union = new List<int>();
            for(int i = 0; i < A.Length; i++)
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
                if(Union[i] == Union[i + 1])
                {
                    Union.RemoveAt(i);
                    i = 0;
                }
                
            }

            for(int i = 0; i < Union.Count; i++)
            {
                Console.Write(Union[i] + ",");
            }










        }
    }
}
