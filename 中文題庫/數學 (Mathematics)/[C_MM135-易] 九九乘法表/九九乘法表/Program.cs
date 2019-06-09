using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 九九乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int ip = int.Parse(Console.ReadLine());
                string display = "";
                int[] sortmn = new int[ip * 2];
                string[] Mn;
                int W = 0;
                for (int i = 0; i < ip; i++)
                {
                    Mn = Console.ReadLine().Split(' ');
                    for (int a = 0; a < 2; W++, a++)
                    {
                        sortmn[W] = int.Parse(Mn[a]);
                    }
                }
                for (int a = 0, o = 1, m = 0, n = 1; a < ip; a++, m += 2, n += 2)
                {

                    int aa = 0, tot = 0, QJ = 0;
                    for (int i = 1; i <= 9; i++)
                    {
                        display = "";
                        o = 0;
                        for (int j = sortmn[m]; j <= sortmn[n]; j++, o++)
                        {
                            if (o == 5)
                            {
                                tot += o;
                                QJ = j;
                                break;
                            }
                            //Console.Write("{0} * {1} = {2}{3}{4}", j, i, space = (j * i <= 9) ? " " : "", j * i,"     ");
                            display += j + " * " + i + " = " + (display = (j * i <= 9) ? " " : "") + j * i + "     ";
                        }
                        Console.WriteLine(display.Remove(display.Length - 5));
                        if (tot == 45)
                        {
                            Console.WriteLine("\n");
                            for (i = 1; i <= 9; i++)
                            {
                                display = "";
                                for (aa = QJ; aa <= sortmn[n]; aa++)
                                {
                                    //Console.Write("{0} * {1} = {2}{3}{4}", aa, i, (space = (aa * i <= 9) ? " " : ""), aa * i, "    x");
                                    display += aa + " * " + i + " = " + (display = (aa * i <= 9) ? " " : "") + aa * i + "     ";
                                }
                                Console.WriteLine(display.Remove(display.Length - 5));
                            }
                        }
                    }
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
