using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 輸出NxN之結果
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            for (int i=1; i<=x;i++)
            {
                Console.WriteLine(i+"*"+i+"="+i*i);
            }
            Console.ReadKey();
        }
    }
}
