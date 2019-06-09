using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 最大質數問題
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int x = int.Parse(Console.ReadLine());
                int c=0, mx = 0;
                for (int i =1; i<x;i++)
                {
                    c = 0;//c++完要歸零 不然以後每個都會變成非質數
                    for(int j = 1; j <= i; j++)//跑x-1次 然後用i(x-1)%j看是不是質數
                    {
                        if (i % j == 0) c++; //如果%%等於0的話代表整除 整除超過3次就不是質數
                    }
                    if (c < 3)//質數不會被超過3個數字整除 所以這段被執行到就是質數
                    {
                        mx = i;//讓mx=i 因為i被鎖在裡面
                    }
                }
                Console.WriteLine(mx);

            }
        }
    }
}

