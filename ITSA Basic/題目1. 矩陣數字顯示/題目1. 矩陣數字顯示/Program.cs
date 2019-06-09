using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("輸入[1]輸入10000以下的數 [2]自動跑到9999 :");

                string P = Console.ReadLine();
                bool T = true;
                if (P == "1") T = false;                
                else if (P != "2"){ continue; }

                string[] O = { "#####", "#   #", "#   #", "#   #", "#####" };
                string[] o1 = { "    #", "    #", "    #", "    #", "    #" };
                string[] o2 = { "#####", "    #", "#####", "#    ", "#####" };
                string[] o3 = { "#####", "    #", "#####", "    #", "#####" };
                string[] o4 = { "#   #", "#   #", "#####", "    #", "    #" };
                string[] o5 = { "#####", "#    ", "#####", "    #", "#####" };
                string[] o6 = { "#####", "#    ", "#####", "#   #", "#####" };
                string[] o7 = { "#####", "    #", "    #", "    #", "    #" };
                string[] o8 = { "#####", "#   #", "#####", "#   #", "#####" };
                string[] o9 = { "#####", "#   #", "#####", "    #", "#####" };

                string[] A = new string[5];
                string[] B = new string[5];
                string[] C = new string[5];
                string[] D = new string[5];

                int X = 0;
                string TEST = "";

                if (T) { }
                else
                {
                    X = int.Parse(Console.ReadLine());
                    if (X >= 10000) continue ;
                }


                for (int a = 0, o = 0; o < 9999; X++, a++)
                {
                    TEST = X.ToString().PadLeft(4, '0');
                    switch (TEST.Substring(0, 1))
                    {
                        case "0": A = O; break;
                        case "1": A = o1; break;
                        case "2": A = o2; break;
                        case "3": A = o3; break;
                        case "4": A = o4; break;
                        case "5": A = o5; break;
                        case "6": A = o6; break;
                        case "7": A = o7; break;
                        case "8": A = o8; break;
                        case "9": A = o9; break;
                    }
                    switch (TEST.Substring(1, 1))
                    {
                        case "0": B = O; break;
                        case "1": B = o1; break;
                        case "2": B = o2; break;
                        case "3": B = o3; break;
                        case "4": B = o4; break;
                        case "5": B = o5; break;
                        case "6": B = o6; break;
                        case "7": B = o7; break;
                        case "8": B = o8; break;
                        case "9": B = o9; break;
                    }
                    switch (TEST.Substring(2, 1))
                    {
                        case "0": C = O; break;
                        case "1": C = o1; break;
                        case "2": C = o2; break;
                        case "3": C = o3; break;
                        case "4": C = o4; break;
                        case "5": C = o5; break;
                        case "6": C = o6; break;
                        case "7": C = o7; break;
                        case "8": C = o8; break;
                        case "9": C = o9; break;
                    }
                    switch (TEST.Substring(3, 1))
                    {
                        case "0": D = O; break;
                        case "1": D = o1; break;
                        case "2": D = o2; break;
                        case "3": D = o3; break;
                        case "4": D = o4; break;
                        case "5": D = o5; break;
                        case "6": D = o6; break;
                        case "7": D = o7; break;
                        case "8": D = o8; break;
                        case "9": D = o9; break;
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("{0} {1} {2} {3}", A[i], B[i], C[i], D[i]);
                    }
                    Console.WriteLine();
                    if (!T) break;
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
    }
}