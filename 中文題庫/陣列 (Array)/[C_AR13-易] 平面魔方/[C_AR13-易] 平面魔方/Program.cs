using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR13_易__平面魔方
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string str = "";
            for (int G = 0; G < n; G++)
            {
                int m = int.Parse(Console.ReadLine());
                string RRNNLL = Console.ReadLine();
                int[,] Magicfan = new int[m, m];
                int j = 0;
                for (int i = 0; i < m; i++)
                {
                    for (int k = 0; k < m; j++, k++)
                    {
                        Magicfan[i, k] = j + 1;
                    }
                }

                for (int i = 0; RRNNLL.Length != 0;)
                {
                    switch (RRNNLL.Substring(i, 1))
                    {
                        case "R":
                            Magicfan = Right(Magicfan);
                            RRNNLL = RRNNLL.Substring(1, RRNNLL.Length - 1);
                            break;
                        case "N":
                            Magicfan = UPdown(Magicfan);
                            RRNNLL = RRNNLL.Substring(1, RRNNLL.Length - 1);
                            break;
                        case "L":
                            Magicfan = Left(Magicfan);
                            RRNNLL = RRNNLL.Substring(1, RRNNLL.Length - 1);
                            break;
                    }
                }
                for (int i = 0; i < m; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        str += Magicfan[i, j].ToString().PadLeft(5, ' ');
                    }
                    str = str + "\n";
                }
                str += "\n";
            }
            Console.Write(str.Substring(0, str.Length - 1));
        }

        static int[,] Right(int[,] m)
        {
            int[,] copy = m;
            int len = m.GetLength(0);
            m = new int[len, len];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    m[i, j] = copy[len - 1 - j, i];
                }
            }
            return m;
        }
        static int[,] Left(int[,] m)
        {
            int[,] copy = m;
            int len = m.GetLength(0);
            m = new int[len, len];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    m[i, j] = copy[j, len - 1 - i];
                }
            }
            return m;
        }
        static int[,] UPdown(int[,] m)
        {
            int[,] copy = m;
            int len = m.GetLength(0);
            m = new int[len, len];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    m[i, j] = copy[len - 1 - i, j];
                }
            }
            return m;
        }
    }
}