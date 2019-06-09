using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST31_易__移除字串中的空白鍵和定位鍵
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.ReadLine().Replace(" ","").Replace("\t",""));
        }
    }
}
