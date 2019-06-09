using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 進位轉換
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string ip = Console.ReadLine();
                if (ip == "end") break;
                if (!Condition(ip)) Console.WriteLine(Convert.ToInt32(ip, 16));
                else Console.WriteLine(Convert.ToInt32(ip, 8));
            }
        }
        static bool Condition(string X)
        {
            try
            {
                int.Parse(X);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
