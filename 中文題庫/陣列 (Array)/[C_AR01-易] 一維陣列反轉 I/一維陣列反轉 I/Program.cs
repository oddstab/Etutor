using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一維陣列反轉_I
{
    class Program
    {
        static void Main(string[] args)
        {
            //int one = int.Parse(Console.ReadLine());
            //string one = Console.ReadLine();
            ////string con = one.ToString();
            //string[] tot = one.Split(' ');
            //Array.Reverse(tot);
            //for (int i = 0; i < tot.Length; i++)
            //{
            //    Console.Write(tot[i] + " ");
            //}
            //Console.WriteLine(tot.Length - 1);
            //Console.Read();
            string[] one = Console.ReadLine().Split(' ');
            string[] tot = new string[6] { one[0], one[1], one[2], one[3], one[4], one[5] };
            Array.Reverse(tot);
            for (int i = 0; i < tot.Length; i++)
            {
                Console.Write(tot[i] + " ");
            }
            Console.WriteLine(tot.Length - 1);
            //Console.WriteLine();
            Console.ReadKey();
        }
    }
}
