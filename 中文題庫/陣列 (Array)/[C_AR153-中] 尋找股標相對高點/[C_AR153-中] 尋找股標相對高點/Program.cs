using System;

namespace _C_AR153_中__尋找股標相對高點
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ip = Console.ReadLine().Split();
            string str = "";
            for (int i = 0; i < ip.Length; i++)
            {
                if (i == 0)
                {
                    if (int.Parse(ip[1]) < int.Parse(ip[0]))
                        str += i + " ";
                }
                else if (i == ip.Length - 1 )
                {
                    if (int.Parse(ip[ip.Length - 2]) < int.Parse(ip[ip.Length - 1]))
                        str += i + " ";
                }
                else
                {
                    int front = int.Parse(ip[i - 1]);
                    int behind = int.Parse(ip[i + 1]);
                    int now = int.Parse(ip[i]);
                    if (now > front && now > behind) str += i + " ";
                }
            }
            Console.WriteLine(str.TrimEnd());
        }
    }
}