using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_MM081_易__10進位及16進位
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = Console.ReadLine();
            if (Sixteen(ip)) Console.WriteLine(Convert.ToInt32(ip, 16));
            else Console.WriteLine("0x" + Convert.ToString(int.Parse(ip), 16).ToUpper());
        }
        static bool Sixteen(string x)
        {
            try
            {
                int.Parse(x);
                return false;
            }
            catch
            {
                return true;
            }
        }
    }
}
