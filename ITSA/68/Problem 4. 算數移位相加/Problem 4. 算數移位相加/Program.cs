using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.算數移位相加
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string ip = Console.ReadLine();
                decimal temp = decimal.Parse(ip);
                List<decimal> tot = new List<decimal>();
                for (int i = ip.Length - 1; i > 0; i--)
                {
                    tot.Add(decimal.Parse(ip.Substring(0, i)));
                }
                Console.WriteLine(temp);
            }
        }
    }
}
