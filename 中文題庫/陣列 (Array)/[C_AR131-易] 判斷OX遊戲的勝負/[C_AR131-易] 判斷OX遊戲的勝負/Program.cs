using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR131_易__判斷OX遊戲的勝負
{
    class Program
    {
        static public int[] ox = new int[2];
        static public int[] ox2 = new int[2];
        static void Main(string[] args)
        {
            while (true)
            {           
                string[,] oxo = new string[3, 3];
                int o = 0;
                int x = 0;

                for (int i = 0; i < 3; i++)
                {
                    string[] str = Console.ReadLine().Split(',');
                    for (int j = 0; j < 3; j++)
                    {
                        oxo[i, j] = str[j];
                    }
                }
                if (oxo[0, 0] + oxo[1, 1] + oxo[2, 2] == "OOO") o++;
                if (oxo[0, 2] + oxo[1, 1] + oxo[2, 0] == "OOO") o++;
                if (oxo[0, 0] + oxo[1, 1] + oxo[2, 2] == "XXX") x++;
                if (oxo[0, 2] + oxo[1, 1] + oxo[2, 0] == "XXX") x++;
                o += Row(oxo)[1] + Colums(oxo)[1];
                x += Row(oxo)[0] + Colums(oxo)[0];
                if (x > o) Console.WriteLine("X");
                else if (x == o) Console.WriteLine(1);
                else Console.WriteLine("O");
            }
        }
        static int[] Row(string[,] oxo)
        {
            ox = new int[2];
            for (int i = 0; i < oxo.GetLength(0); i++)
            {
                if (oxo[i, 0] + oxo[i, 1] + oxo[i, 2] == "XXX") ox[0]++;
                if (oxo[i, 0] + oxo[i, 1] + oxo[i, 2] == "OOO") ox[1]++;
            }
            return ox;
        }
        static int[] Colums(string[,] oxo)
        {
            ox2 = new int[2];
            for (int i = 0; i < oxo.GetLength(0); i++)
            {
                if (oxo[0, i] + oxo[1, i] + oxo[2, i] == "XXX") ox2[0]++;
                if (oxo[0, i] + oxo[1, i] + oxo[2, i] == "OOO") ox2[1]++;
            }
            return ox2;
        }
    }
}