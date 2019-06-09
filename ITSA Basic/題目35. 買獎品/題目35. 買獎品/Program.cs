using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 題目35.買獎品
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                for (int g = 0; g < n; g++)
                {
                    string[] TMK = Console.ReadLine().Split(' ');
                    int t = int.Parse(TMK[0]);
                    int m = int.Parse(TMK[1]);
                    int k = int.Parse(TMK[2]);
                    int sum = 0;

                    string[] KString;
                    KString = Console.ReadLine().Split(' ');
                    int[] Kint = new int[KString.Length];
                    for (int i = 0; i < KString.Length; i++) Kint[i] = int.Parse(KString[i]);
                    bubble(Kint);
                    for (int i = 0; i < m; i++)
                    {
                        sum += Kint[i];
                    }
                    if (sum > t) Console.WriteLine("Impossible");
                    else Console.WriteLine(sum);
                }
            }
        }
        static void bubble(int[] Sort)
        {
            int temp = 0;
            for (int i = 0; i < Sort.Length; i++)
            {
                for (int j = 1; j < Sort.Length - i; j++)
                {
                    if (Sort[j - 1] > Sort[j])
                    {
                        temp =Sort[j] ;
                        Sort[j] = Sort[j - 1];
                        Sort[j - 1] = temp;
                    }
                }
            }
        }
    }
}