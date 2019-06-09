using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ST47_易__The_Simple_Calculator
{
    class Program
    {
        static string[] Split_ip;
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                for (int g = 0; g < n; g++)
                {
                    int sum = 0;
                    string ip = Console.ReadLine();

                    if (ip.Substring(0, 1) == "-")
                    {
                        ip = ip.TrimStart('-');
                        Split_ip = ip.TrimEnd('=').Split('+', '-');
                        sum = -int.Parse(Split_ip[0]);
                    }
                    else
                    {
                        Split_ip = ip.TrimEnd('=').Split('+', '-');
                        sum = int.Parse(Split_ip[0]);
                    }
                    for (int i = 0, t = 1; i < ip.Length; i++)
                    {
                        string sub = ip.Substring(i, 1);
                        if (sub == "+")
                        {
                            sum = sum + int.Parse(Split_ip[t]);
                            t++;
                        }
                        else if (sub == "-")
                        {
                            sum = sum - int.Parse(Split_ip[t]);
                            t++;
                        }
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }
}