using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR026_中__選擇排序法動態展示
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<int> Future = new List<int>();
                List<string> dis = new List<string>();
                while (true)
                {
                    try
                    {
                        Future.Add(int.Parse(Console.ReadLine()));
                    }
                    catch
                    {
                        break;
                    }

                }
                int[] A = Future.ToArray();
                string str = "";
                for (int d = 0; d < A.Length; d++)
                {
                    str += A[d];
                    if (d != A.Length - 1) str += ",";
                }
                dis.Add(str);
                for (int i = 0, minIndex; i < A.Length - 1; ++i)
                {
                    str = "";
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
                    for (int d = 0; d < A.Length; d++)
                    {
                        str += A[d];
                        if (d != A.Length - 1) str += ",";
                    }
                    if (!dis.Contains(str)) dis.Add(str);
                }
                foreach (string s in dis) Console.WriteLine(s);
            }           
        }
        static void Swap(int[] AR, int sw1, int sw2)
        {
            int temp = AR[sw1];
            AR[sw1] = AR[sw2];
            AR[sw2] = temp;
        }
    }
}