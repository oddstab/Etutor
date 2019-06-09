using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR67_易__隨意九九乘法
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] IP = Console.ReadLine().Split(' ');
                int[] P = new int[IP.Length];
                for (int i = 0; i < IP.Length; i++) P[i] = int.Parse(IP[i]);
                for (int i = 0; i < 6; i++)
                {
                    string str = "";
                    for (int j = 0; j < 6; j++)
                    {
                        int t = P[j] * P[i];
                        //三元
                        //str += (t < 10 ? "00" + t : (t < 100) ? "0" + t : "" + t) + (j == 5 ? "" : " ");
                        str += t.ToString().PadLeft(3, '0') + "X"; 
                    }
                    //padleft
                    Console.WriteLine(str.TrimEnd('X'));
                }
            }
        }
    }
}
