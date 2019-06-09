using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR36_易__星座查詢
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] ip = Console.ReadLine().Split(' ');
                int a = int.Parse(ip[0]);
                int b = int.Parse(ip[1]);
                if ((a == 1 && b >= 21) || (a == 2 && b <= 18)) Console.WriteLine("Aquarius");
                if ((a == 2 && b >= 19) || (a == 3 && b <= 20)) Console.WriteLine("Pisces");
                if ((a == 3 && b >= 21) || (a == 4 && b <= 20)) Console.WriteLine("Aries");
                if ((a == 4 && b >= 21) || (a == 5 && b <= 21)) Console.WriteLine("Taurus");
                if ((a == 5 && b >= 22) || (a == 6 && b <= 21)) Console.WriteLine("Gemini");
                if ((a == 6 && b >= 22) || (a == 7 && b <= 22)) Console.WriteLine("Cancer");
                if ((a == 7 && b >= 23) || (a == 8 && b <= 23)) Console.WriteLine("Leo");
                if ((a == 8 && b >= 24) || (a == 9 && b <= 23)) Console.WriteLine("Virgo");
                if ((a == 9 && b >= 24) || (a == 10 && b <= 23)) Console.WriteLine("Libra");
                if ((a == 10 && b >= 24) || (a == 11 && b <= 22)) Console.WriteLine("Scorpio");
                if ((a == 11 && b >= 23) || (a == 12 && b <= 21)) Console.WriteLine("Sagittarius");
                if ((a == 12 && b >= 22) || (a == 1 && b <= 20)) Console.WriteLine("Capricorn");
            }
        }
    }
}
