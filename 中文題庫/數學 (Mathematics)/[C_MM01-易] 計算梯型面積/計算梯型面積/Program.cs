using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 計算梯型面積
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] trape = Console.ReadLine().Split(' ');
                double up, down, high, totale;
                up = double.Parse(trape[0]);
                down = double.Parse(trape[1]);
                high = double.Parse(trape[2]);
                totale = (up + down) * high / 2;
                Console.WriteLine("Trapezoid area:{0}", totale.ToString("##.0"));
            }
        }
    }
}
