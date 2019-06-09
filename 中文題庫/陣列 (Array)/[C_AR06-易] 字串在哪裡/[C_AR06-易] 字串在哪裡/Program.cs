using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR06_易__字串在哪裡
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {       
                string searchstr = Console.ReadLine();
                string ip = Console.ReadLine();
                string[,] ABCarr = new string[ip.Length, ip.Length];
                for (int i = 0; i < ip.Length; i++) ABCarr[0, i] = ip.Substring(i, 1);
                while (true)
                {
                    ip = Console.ReadLine();
                    if (ip == "") break;
                    for(int i =1;i<ip.Length; i++)
                    {
                        for(int j =0;j<ip.Length; j++)
                        {
                            ABCarr[i, j] = ip.Substring(j, 1);
                        }
                    }
                }





                Console.WriteLine();
            }

        }
    }
}
