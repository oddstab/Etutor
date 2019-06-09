using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR09_易__兩數差值
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] str = Console.ReadLine().Split(',');
                int[] Data = new int[str.Length];
                for (int i = 0; i < str.Length; i++) Data[i] = int.Parse(str[i]);

                //bubble sorting
                for (int i = 0; i < Data.Length - 1; i++)
                {
                    for (int j = i + 1; j < Data.Length; j++)
                    {
                        if (Data[i] > Data[j]) Swap(Data, j, i);
                    }
                }
                string Min = "", Max = "";

                //min
                for (int k = 0; k < Data.Length; k++) Min += Data[k];
                //max
                for (int j = Data.Length - 1; j >= 0; j--) Max += Data[j];
                Console.WriteLine(int.Parse(Max) - int.Parse(Min));
            }
        }
        static void Swap(int[] Arr, int sw1, int sw2)
        {
            int temp;
            temp = Arr[sw1];
            Arr[sw1] = Arr[sw2];
            Arr[sw2] = temp;
        }
    }
}
