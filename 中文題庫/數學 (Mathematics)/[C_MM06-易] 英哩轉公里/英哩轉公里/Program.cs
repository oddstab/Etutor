using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 英哩轉公里
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int  it = int.Parse(Console.ReadLine());

                double  km =it * 1.6;
            
            Console.WriteLine(km.ToString("##.0"));
            Console.Read();
            

        }
    }
}
