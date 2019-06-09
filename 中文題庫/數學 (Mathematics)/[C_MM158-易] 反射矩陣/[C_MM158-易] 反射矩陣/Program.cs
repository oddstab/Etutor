using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_MM158_易__反射矩陣
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i =0;i<3; i++)
            {
                string[] x = Console.ReadLine().Split();
                Console.WriteLine("{2} {1} {0}",x[0],x[1],x[2]);
            }
        }
    }
}