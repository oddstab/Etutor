using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 約瑟夫問題
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("請輸入報數值:");
                    int[] people = new int[100];
                    int GG = 100, /*<--GG了   順序-->*/nth = 0;
                    int m = int.Parse(Console.ReadLine());//報數值   ex. m=3 1 2 (3).. 1 2 (3)        
                    if (m <= 0) throw new Exception();
                    for (int i = 0; ; nth++)//i 當成報數
                    {
                        if (nth == 100) nth = 0;//等於100回到第一個還活著的
                        if (people[nth] == 0) i++;//0=活著 如果活著就報數
                        if (i == m)
                        {
                            people[nth] = 1;//1 = GG
                            i = 0;//重報數
                            GG--;//1人GG -1
                            if (GG == 1) break; //alive 1 人
                        }
                    }
                    for (int i = 0; i < 100; i++)//篩出誰是1(alive)
                    {
                        if (people[i] == 0)
                        {
                            Console.WriteLine("\n"+i+"\n");
                            break;
                        }
                    }
                }
                catch
                {
                }  
            }
        }
    }
}
