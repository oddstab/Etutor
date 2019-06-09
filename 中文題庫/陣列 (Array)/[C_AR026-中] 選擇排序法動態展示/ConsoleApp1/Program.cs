using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class InPlace
    {
        static void Main()
        {
            int[] array = new int[] { 4, 2, 1, 3, 5 };
            Sort(array);
        }
        public static void Sort(int[] A)
        {
            for (int i = 0, minIndex; i < A.Length - 1; ++i)
            {
                minIndex = i;
                for (int j = i + 1; j < A.Length; ++j)
                {
                    if (A[j] > A[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    Swap(A, minIndex, i);
                }
            }
        }

        private static void Swap(int[] array, int indexA, int indexB)
        {
            int tmp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = tmp;
        }
    }
}
