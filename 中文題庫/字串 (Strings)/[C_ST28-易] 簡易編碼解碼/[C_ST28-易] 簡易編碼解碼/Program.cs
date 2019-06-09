using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST28_易__簡易編碼解碼
{
    class Program
    {
        static void Main(string[] args)
        {
            string select = Console.ReadLine();
            string sq = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";
            string display = "";
            int len = sq.Length;
            char[] ip = Console.ReadLine().ToUpper().ToCharArray();
            if (select.Substring(0, 1) == "+")
            {
                int num = int.Parse(select.Substring(1));
                for (int i = 0; i < ip.Length; i++)
                {
                    int index = sq.IndexOf(ip[i].ToString());
                    display = sq.Substring(index + num > 26 ? index + num - 27 : index + num, 1);
                    Console.Write(display);
                }
                Console.WriteLine();
            }
            else
            {
                int num = int.Parse(select.Substring(1));
                for (int i = 0; i < ip.Length; i++)
                {
                    int index = sq.IndexOf(ip[i].ToString());
                    display = sq.Substring(index-num<0? index - num + 27 :index-num,1);
                    Console.Write(display);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}