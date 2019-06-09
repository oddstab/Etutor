using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR146_易__最大值與最小值
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fint = Console.ReadLine().Split();
            for(int i =0;i<fint.Length; i++)
            {
                for(int j =1;j<fint.Length-i; j++)
                {
                    if(double.Parse(fint[j - 1]) > double.Parse(fint[j]))
                    {
                        string t = fint[j - 1];
                        fint[j - 1] = fint[j];
                        fint[j] = t;
                    }
                }
            }
            Console.WriteLine("maximum:{0:f2}",double.Parse( fint[fint.Length-1]));
            Console.WriteLine("minimum:{0:f2}",double.Parse(fint[0]));
        }
    }
}