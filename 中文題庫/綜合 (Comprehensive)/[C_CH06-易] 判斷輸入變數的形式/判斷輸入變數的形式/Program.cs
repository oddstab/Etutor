using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判斷輸入變數的形式
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string ip = Console.ReadLine();
                int leng = ip.Length;
                if (leng <= 1) Console.WriteLine("char");
                else if (boolint(ip)) Console.WriteLine("int");
                else if (ip.Substring(ip.Length - 1, 1) == ".") Console.WriteLine("string");
                else if (ip.Substring(0, 1) == ".") Console.WriteLine("string");
                else if (boolflaot(ip)) Console.WriteLine("float");
                else Console.WriteLine("string");
            }
        }
        static bool boolint(string con)
        {
            try
            {
                int oo = int.Parse(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
        static bool boolflaot(string con)
        {
            try
            {
                float oo = float.Parse(con);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
