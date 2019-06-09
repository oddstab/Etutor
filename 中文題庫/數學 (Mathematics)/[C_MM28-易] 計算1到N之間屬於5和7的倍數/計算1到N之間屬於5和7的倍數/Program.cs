using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 計算1到N之間屬於5和7的倍數
{
    class Program
    {
        static void Main(string[] args)
        {
            int ip = int.Parse(Console.ReadLine());
            string ANS = "";
            for (int i=1;i<=ip;i++)
            {
                if (i % 5==0 && i % 7==0)
                {
                    //Console.Write(i+" ");
                    ANS+=i+" ";
                }
            }
            //Console.WriteLine();
            //Console.WriteLine(ANS.Substring(0,ANS.Length-1));
            Console.WriteLine(ANS.Remove(ANS.Length - 1, 1));
            Console.ReadKey();
        }
    }
}
