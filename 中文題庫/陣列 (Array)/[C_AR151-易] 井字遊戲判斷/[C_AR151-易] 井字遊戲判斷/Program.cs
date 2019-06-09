using System;

namespace _C_AR151_易__井字遊戲判斷
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isnot = true;
            string[,] ooxx = new string[3, 3];
            string ip = Console.ReadLine().TrimEnd();
            for (int i = 0; i < 3; i++)
            {
                string temp = Console.ReadLine();
                for (int j = 0; j < 3; j++)
                    ooxx[i, j] = temp.Split()[j];
            }
            for (int i = 0; i < 3; i++)
            {
                if (ooxx[i, 0] == ip && ooxx[i, 1] == ip && ooxx[i, 2] == ip)
                {
                    Console.WriteLine("All {0}'s on row {1}", ip, i); isnot = false;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (ooxx[0, i] == ip && ooxx[1, i] == ip && ooxx[2, i] == ip)
                {
                    Console.WriteLine("All {0}'s on column {1}", ip, i); isnot = false;
                }
            }                      
            if (ooxx[0, 0] == ip && ooxx[1, 1] == ip && ooxx[2, 2] == ip)
            {
                Console.WriteLine("All {0}'s on diagonal", ip); isnot = false;
            }
            if (ooxx[0, 2] == ip && ooxx[1, 1] == ip && ooxx[2, 0] == ip)
            {
                Console.WriteLine("All {0}'s on subdiagonal", ip); isnot = false;
            }
            if (isnot) Console.WriteLine("There is no line with all {0}", ip);
        }
    }
}