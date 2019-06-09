using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST19_易__時間轉換
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int a =0;a<n; a++)
            {               
                string[] T = Console.ReadLine().Split();
                int Dis = int.Parse(T[0]);
                Dis+= Time(T[2]) - Time(T[1]);
                Dis %= 2400;
                if (Dis < 0) Dis += 2400;
                Console.WriteLine(Dis.ToString().PadLeft(4,'0')+" "+T[2]);
            }
        }
        static int Time(string x)
        {
            switch (x)
            {
                case "TW":
                    return 0;
                case "UK":
                    return -800;
                case "JA":
                    return 100; 
                case "USE":
                    return -1200;
                case "USW":
                    return -1400;
                case "USC":
                    return -1300;
            }
            return 0;
        }
    }
}