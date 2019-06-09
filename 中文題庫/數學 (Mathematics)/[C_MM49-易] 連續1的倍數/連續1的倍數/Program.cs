using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace 連續1的倍數
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ulong ip1 = ulong.Parse(Console.ReadLine());
                string[] ip3split = new string[ip1];
                ip3split = Console.ReadLine().Split(' ');
                for (ulong i = 0; i < ip1; i++)
                {
                    Console.WriteLine(BInt(decimal.Parse(ip3split[i]), i));
                }

            }
        }
        static ulong BInt(decimal x, ulong i)
        {
            decimal BGulong = 1;
            string onelen = "";
            for (; BGulong % x != 0; BGulong = BGulong * 10 + 1)
            {
                if (BGulong.ToString().Length == 29)
                {
                    onelen += BGulong.ToString();
                    x /= 10;
                    BGulong = 1;
                    
                }
            }
            return (ulong)BGulong.ToString().Length;
            return (ulong)onelen.Length;

        }
    }
}
