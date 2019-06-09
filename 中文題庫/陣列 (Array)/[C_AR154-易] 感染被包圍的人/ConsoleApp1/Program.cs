using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,,] arr = new string[7, 7, 2];
            for (int i = 0; i < 7; i++)
            {
                string[] ip = Console.ReadLine().Split();
                for (int j = 0; j < 7; j++)
                {
                    arr[i, j, 0] = ip[j];
                    arr[i, j, 1] = "0";
                    if (i == 0 || i == 6)
                    {
                        if (arr[i, j, 0] == "0")
                            arr[i, j, 1] = "1";
                    }
                }
                if (arr[i, 0, 0] == "0") arr[i, 0, 1] = "1";
                if (arr[i, 6, 0] == "0") arr[i, 6, 1] = "1";
            }
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    if ((j != 0 || j != 6) && arr[i, j, 0] == "0")
                    {
                        if (arr[i, j - 1, 1] == "1" || arr[i + 1, j, 1] == "1" || arr[i, j + 1, 1] == "1" || arr[i - 1, j, 1] == "1")
                            arr[i, j, 1] = "1";
                    }
                }
            }
            for (int i = 5; i > 0; i--)
            {
                for (int j = 5; j > 0; j--)
                {
                    if ((j != 0 || j != 6) && arr[i, j, 0] == "0")
                    {
                        if (arr[i,j - 1,1]=="1" || arr[i + 1,j,1]=="1" || arr[i,j + 1,1]=="1"|| arr[i - 1,j,1]=="1")
                            arr[i,j,1] = "1";
                    }
                }
            }
            for(int i = 0;i<7; i++)
            {
                for(int j = 0;j<7; j++)
                {
                    if (j != 0) Console.Write(" ");
                    if (arr[i, j, 0] == "X") Console.Write("X");
                    else if (arr[i, j, 1] == "1") Console.Write("0");
                    else Console.Write("I");
                }
                Console.WriteLine();
            }
            
        }
    }
}