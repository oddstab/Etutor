using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //大絃嘈嘈＊如急雨＝小絃切切＊如私語
        //４５９９＊０２６＝１５３３＊０７８
        static void Main(string[] args)
        {
            while (true)
            {
                Random rn = new Random();
                int n = int.Parse(Console.ReadLine());
                int[] intran = new int[n];
                for (int i = 0; i < n; i++)
                {
                    intran[i] = rn.Next(99999999);
                }
                switch (Console.ReadLine())
                {
                    case "1":
                        double start = DateTime.Now.Millisecond;
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 1; j < n - i; j++)
                            {
                                if (intran[j - 1] > intran[j])
                                {
                                    int temp = intran[j - 1];
                                    intran[j - 1] = intran[j];
                                    intran[j] = temp;
                                }
                            }
                        }
                        double end = DateTime.Now.Millisecond;
                        Console.WriteLine("\n" + (end - start) + " ms");
                        break;
                    case "2":
                        start = DateTime.Now.Millisecond;
                        Array.Sort(intran);
                        end = DateTime.Now.Millisecond;
                        Console.WriteLine("\n" + (end - start) + " ms");
                        break;
                }
            }           
        }
    }
}