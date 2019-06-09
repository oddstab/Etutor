using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小蝸牛
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //0=N 竹竿len 
                //1 =R 上升的距離&單位 
                //2 =D 下降的距離&單位
                int i = 0;
                string[][] rnd = new string[3][];
                double[] intrnd = new double[3];
                for ( i = 0; i <3; i++) 
                {
                    rnd[i] = Console.ReadLine().Split(' ');
                    while(true)
                    {
                        if (rnd[i][1] == "m")
                        {
                            intrnd[i] = double.Parse(rnd[i][0]) * 100;
                            break;
                        }
                        else
                        {
                            intrnd[i] = double.Parse(rnd[i][0]);
                            break;
                        }
                    }
                }
                for (i = 1; ; i++) 
                {
                    intrnd[0] -= intrnd[1];//R
                    if (intrnd[0] <= 0) break;
                    intrnd[0] += intrnd[2];//D                                    
                }
                Console.WriteLine(i);
                //Console.WriteLine((intrnd[0]-intrnd[1])/(intrnd[1]-intrnd[2])+1);
            }
        }
    }
}
