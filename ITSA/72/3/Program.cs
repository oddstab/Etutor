using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    bool flag = true;
                    string content = Console.ReadLine();
                    string spl = Console.ReadLine();
                    int row = int.Parse(Console.ReadLine());
                    int len = content.Length;
                    len = len % row != 0 ? (len / row) + 1 : len / row;

                    string[,] data = new string[row, len];

                    int index = 0;
                    int I = len - 1;
                    for (int i = 0; i <len; i++)
                    {
                        for (int j = 0; j < row; j++)
                        {
                            data[j,I ] = flag ? " " : content[index++].ToString();
                            flag = false;
                        }
                        I--;
                    }

                    for(int i = 0;i<row; i++)
                    {
                        for(int j = 0;j<len; j++)
                        {
                            Console.Write(data[i, j]+(j!=len-1?spl:""));
                        }
                        Console.WriteLine();
                    }

                    Console.ReadKey();

                }
                catch
                {
                    break;
                }
            }
        }
    }
}
