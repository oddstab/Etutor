using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR10_中__新通話費率
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ip = Console.ReadLine().Split(',');
            double[] sq = { 186, 386, 586, 986 };
            double month = double.Parse(ip[0]);
            double money = double.Parse(ip[1]);
            double tot = 0, a = 0.9,C =0.09;
            for (int i = 0; i < 4; i++,a -= 0.1, C -= 0.01)
            {
                if (month == sq[i])
                {
                    tot = money * C;
                    if (tot < sq[i]) tot = sq[i];
                    else if (tot <= sq[i] * 2) tot = tot * a;
                    else if (tot > sq[i] * 2) tot = tot * (a - 0.1);
                }      
            }
            Console.WriteLine(Math.Round(tot, MidpointRounding.AwayFromZero));
            Console.ReadKey();
        }
    }
}