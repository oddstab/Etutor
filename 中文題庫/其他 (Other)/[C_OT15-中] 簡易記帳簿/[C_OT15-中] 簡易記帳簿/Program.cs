using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_OT15_中__簡易記帳簿
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int money = int.Parse(Console.ReadLine());
            while (true)
            {
                str = Console.ReadLine();
                if (str == "-1") break;
                int i1 = str.IndexOf(" ");
                int i2 = str.IndexOf(" ", i1 + 1);
                int outint = int.Parse(str.Substring(i2));
                string sub = str.Substring(i1 + 1, i2 - i1 - 1);
                if (sub == "outgoing")
                {
                    money -= outint;
                    Console.WriteLine(str + " " + money);
                }
                else
                {
                    money += outint;
                    Console.WriteLine(str + " " + money);
                }
            }
            Console.WriteLine(money);
        }
    }
}