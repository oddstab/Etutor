using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST47_易__跳格字串解密
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] Love = Console.ReadLine().Split(' ');
                string str = "";
                Console.Write(Love[0].Substring(0, 1)+" ");
                for (int i = 1; i < Love.Length; i++)
                {
                    for(int j =0;j<Love[i].Length; j++)
                    {
                        if ((j+1) % 3 == 0) str+=Love[i].Substring(j,1);
                    }
                    str += " ";
                }
                Console.WriteLine(str.TrimEnd(' '));
            }
        }
    }
}