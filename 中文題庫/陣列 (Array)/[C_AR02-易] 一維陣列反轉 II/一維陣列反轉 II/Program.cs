using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一維陣列反轉_II
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string dis = "";
                string[] sixstr = Console.ReadLine().Split(' ');
                int[] six = new int[6];
                for(int i=0; i <= 5; i++)
                {
                    six[i] = int.Parse(sixstr[i]);
                }
                Array.Reverse(six);
                for (int i=0; i <= 5; i++)
                {
                    dis += six[i]+" ";
                    //Console.Write(six[i]+" ");
                }
                Console.Write(dis.TrimEnd(' ')+"\n");
                
            }
        }
    }
}
