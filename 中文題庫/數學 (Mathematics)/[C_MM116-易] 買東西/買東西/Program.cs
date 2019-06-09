using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 買東西
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int ip = int.Parse(Console.ReadLine());
                string[] str=new string[ip.ToString().Length];
                for (int i = 0; i < ip.ToString().Length; i++)
                {
                    str[i] = ip.ToString().Substring(i,1);
                }
                Array.Reverse(str);
                foreach(string o in str) Console.Write(o);
                Console.WriteLine();
            }
        }
    }
}
