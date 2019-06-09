using System;
using System.Text.RegularExpressions;

namespace _2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    bool s = true;
                    string IP = Console.ReadLine();
                    string[] Y = IP.Split(' ');
                    for (int i = 0; i < Y.Length; i++)
                    {
                        if (Regex.Matches(IP, Y[i]).Count > Y.Length / 2)
                        {
                            Console.WriteLine(Y[i]);
                            s = false;
                            break;
                        }
                    }
                    if (s) Console.WriteLine("n/a");
                }
                catch 
                {
                    break;
                }
            }

        }
    }
}
