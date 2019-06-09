using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST33_易__英文字的分數
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToUpper();
            int sum = 0;
            for (int i = 0; i < str.Length; i++) sum += Convert.ToChar(str.Substring(i, 1)) - 64;
            Console.WriteLine(sum);
        }
    }
}
