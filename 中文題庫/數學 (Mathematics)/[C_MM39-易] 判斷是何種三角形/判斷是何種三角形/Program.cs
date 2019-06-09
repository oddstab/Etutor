using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判斷是何種三角形
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //    直角三角形(Right Triangle)
                //    鈍角三角形(Obtuse Triangle)
                //    銳角三角形(Acute Triangle)
                //    無法構成三角形(Not Triangle)
                string[] tri3 = Console.ReadLine().Split(' ');
                double tr1 = double.Parse(tri3[0]);
                double tr2 = double.Parse(tri3[1]);
                double tr3 = double.Parse(tri3[2]);
                if (tr1 + tr2 > tr3)
                {
                    if (tr1 * tr1 + tr2 * tr2 == tr3 * tr3) Console.WriteLine("Right Triangle");
                    if (tr1 * tr1 + tr2 * tr2 < tr3 * tr3) Console.WriteLine("Obtuse Triangle");
                    if (tr1 * tr1 + tr2 * tr2 > tr3 * tr3) Console.WriteLine("Acute Triangle");
                }
                else Console.WriteLine("Not Triangle");
            }            
        }
    }
}
