using System;

namespace _C_MM084_易__尋找最佳商品問題
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] display = new string[n];
            string[] FCvalue = new string[n];
            for (int i = 0; i < n; i++)
            {
                string[] ip = Console.ReadLine().Split();
                display[i] = ip[0];
                double f = double.Parse(ip[1]);
                double c = double.Parse(ip[2]);
                FCvalue[i] = Math.Round(f / c, 4, MidpointRounding.AwayFromZero).ToString("f4");
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n - i; j++)
                {
                    if (double.Parse(FCvalue[j - 1]) < double.Parse(FCvalue[j]))
                    {
                        string temp = display[j];
                        display[j] = display[j - 1];
                        display[j - 1] = temp;

                        temp = FCvalue[j];
                        FCvalue[j] = FCvalue[j - 1];
                        FCvalue[j - 1] = temp;
                    }
                }
            }
            Console.WriteLine("The best production number is {0}\nFC is {1}", display[0], FCvalue[0]);
            for (int i = 0; i < n; i++)
                Console.WriteLine(display[i] + " " + FCvalue[i]);
        }
    }
}