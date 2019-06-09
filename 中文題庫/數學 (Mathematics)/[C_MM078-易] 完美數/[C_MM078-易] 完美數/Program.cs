using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_MM078_易__完美數
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] per = { 6, 28, 496, 8128 };
                string[] ip = Console.ReadLine().Split(' ');
                int nt = 0;bool yn = true;
                string display = "";
                for (int i = int.Parse(ip[0]); i <= int.Parse(ip[1]); i++)
                {
                    if (i > per[nt])nt++;
                    if (i == per[nt])
                    {
                        display += per[nt]+ " ";
                        nt++;yn = false;
                        if (nt == 4) break;
                    }

                }
                if (yn) Console.WriteLine("null");
                else Console.WriteLine(display.TrimEnd(' '));
            }
        }
    }
}
