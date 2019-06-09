using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 停車費計算
{
    class Program
    {
        static void Main(string[] args)
        {
            //小時換分鐘
            string[] p = Console.ReadLine().Split();
            int am = int.Parse(p[0]);int pm = int.Parse(p[1]);
            int ptotal = (am * 60) + pm;
            
            //小時換分鐘
            string[] p1 = Console.ReadLine().Split();
            int am1 = int.Parse(p1[0]);int pm1 = int.Parse(p1[1]);
            int p1total = (am1 * 60) + pm1;
            int min = p1total - ptotal; //p1-p=停車的時間

            //停車費計算
            
            if (min>120&&min<240) //大於2hr 小於4hr
            {
                Console.WriteLine(((120/30)*30)); //兩小時
            }
            else if (min > 240)//大於4hr
            {
                Console.WriteLine((4*30)  + (4 * 40)+(((min-240)/30)*60));
            }
            else//2hr以下
            {
                Console.WriteLine(min/30*30);
            }
            Console.ReadKey();
        }
    }
}
