using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_MM151_易__成績計算
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string[] IP = new string[5];
            while(true)
            {
                IP = Console.ReadLine().Split(',');
                if (IP[0] == "") break;
                double Score = bubble(IP);
                sum += Score;
            }
            Console.WriteLine((sum / 3d).ToString("f2"));
        }
        static double bubble(string[] x)
        {
            int[] bubble = new int[x.Length];
            for (int i = 0; i < x.Length; i++) bubble[i] = int.Parse(x[i]);
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x.Length - i - 1; j++)
                {
                    if (bubble[j] > bubble[j + 1])
                    {
                        int t = bubble[j];
                        bubble[j] = bubble[j + 1];
                        bubble[j + 1] = t;
                    }
                }
            }
            double maxscore = (bubble[2] + bubble[3] + bubble[4]) / 3d;
            return maxscore;
        }
    }
}