using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR032_易__旋轉與鏡射棋盤
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                string[,] Mirror = new string[n, n];
                int len = Mirror.GetLength(0);
                string str = "";

                for (int i = 0, ASCII = 65; i < n; i++, ASCII++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Mirror[i, j] = (char)ASCII + (j + 1).ToString();
                    }
                }

                //1
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < len; j++) str += Mirror[i, j] + " ";
                    str = str.TrimEnd(' ') + "\n";
                }
                Display(ref str);

                //2
                for (int i = 0; i < len; i++)
                {
                    for (int j = len - 1; j >= 0; j--) str += Mirror[j, i] + " ";
                    str = str.TrimEnd(' ') + "\n";
                }
                Display(ref str);

                //3
                for (int i = len - 1; i >= 0; i--)
                {
                    for (int j = len - 1; j >= 0; j--) str += Mirror[i, j] + " ";
                    str = str.TrimEnd(' ') + "\n";
                }
                Display(ref str);

                //4
                for (int i = len - 1; i >= 0; i--)
                {
                    for (int j = 0; j < len; j++) str += Mirror[j, i] + " ";
                    str = str.TrimEnd(' ') + "\n";
                }
                Display(ref str);

                //5
                for (int i = 0; i < len; i++)
                {
                    for (int j = len - 1; j >= 0; j--) str += Mirror[i, j] + " ";
                    str = str.TrimEnd(' ') + "\n";
                }
                Display(ref str);

                //6
                for (int i = len - 1; i >= 0; i--)
                {
                    for (int j = len - 1; j >= 0; j--) str += Mirror[j, i] + " ";
                    str = str.TrimEnd(' ') + "\n";
                }
                Display(ref str);

                //7
                for (int i = len - 1; i >= 0; i--)
                {
                    for (int j = 0; j < len; j++) str += Mirror[i, j] + " ";
                    str = str.TrimEnd(' ') + "\n";
                }
                Display(ref str);

                //8
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < len; j++) str += Mirror[j, i] + " ";
                    str = str.TrimEnd(' ') + "\n";
                }
                Console.Write(str);
            }

        }
        static void Display(ref string str)
        {
            Console.WriteLine(str);
            str = "";
        }
    }
}
