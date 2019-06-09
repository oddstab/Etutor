using System;
using System.Collections.Generic;
using System.Linq;

namespace _C_AR021_易__成績統計
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> grade = new List<double>(new double[3]);
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < 3; j++)
                {
                    grade[j] += int.Parse(input[j]);
                }
            }
            Console.WriteLine(Round(grade.Sum() / (3 * n)) + ' ' + Round(grade[0] / n) + ' ' + Round(grade[1] / n) + ' ' + Round(grade[2] / n));
        }
        static string Round(double x)
        {
            return Math.Round(x, MidpointRounding.AwayFromZero).ToString("f1");
        }
    }
}