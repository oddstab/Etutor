using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] nm = Console.ReadLine().Split(' ');
                string n = nm[0];
                string n1 = nm[1];
                //string test = "１２３４５６７８９";
                //Console.WriteLine(n1.Substring(0,2));
                int c = 0;
                for (int i = 0; i < 6; i++)
                {
                    if (n1.Substring(i, 2) == n)
                    {
                        c++; 
                    } 
                }
                Console.WriteLine(c);
            }
        }
    }
}
