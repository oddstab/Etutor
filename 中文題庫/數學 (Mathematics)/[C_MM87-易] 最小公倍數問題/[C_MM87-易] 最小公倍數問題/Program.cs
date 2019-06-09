using System;
using System.Collections.Generic;

namespace _C_MM87_易__最小公倍數問題
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            string[] ip = Console.ReadLine().Split();
            for (int i = 0; i < ip.Length; i++)
                data.Add(int.Parse(ip[i]));
            data.Sort();
            for (int i = data[ip.Length - 1]; ; i++)
                if (LCM(data, i))
                {
                    Console.WriteLine("Lowest common multiple: "+i);
                    break;
                }
        }
        static bool LCM(List<int> data,int i)
        {
            for (int j = 0; j < data.Count; j++)
                if (i % data[j] != 0) return false;
            return true;
        }
    }
}