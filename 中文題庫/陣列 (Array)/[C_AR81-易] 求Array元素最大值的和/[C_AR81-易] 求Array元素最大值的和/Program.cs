using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR81_易__求Array元素最大值的和
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] Max3 = new int[9];
                for (int i = 0,a=0; i < 3; i++)
                {
                    string[] Ip = Console.ReadLine().Split(',');
                    for (int q = 0; q < 3; q++,a++) Max3[a] = int.Parse(Ip[q]);
                }
                Console.WriteLine(Max(Max3));
            }            
        }
        static int Max(int[] T)
        {
            int temp = 0;
            int len = T.Length;
            for(int i =0;i<len; i++)
            {
                for(int j =1;j<len-i; j++)
                {
                    if (T[j - 1] > T[j])
                    {
                        temp = T[j];
                        T[j] = T[j - 1];
                        T[j - 1] = temp;
                    }
                }
            }
            return T[len-1]+T[len-2]+T[len-3];
        }
    }
}
